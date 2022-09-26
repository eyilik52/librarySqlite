using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using LibraryProjectApp.FileBook;
using LibraryProjectApp.FileReader;
using LibraryProjectApp.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProjectApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        EscrowBookManager _escBookManager = new EscrowBookManager(new EfEscrowBookDal());

        List < BookDeliveredMember> Kullanici;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDatagrid();
        }

        public void LoadDatagrid()
        {
            var result = _escBookManager.NonDeliveredMember();
            Kullanici = result.Data.ToList();
            if (result.Success)
            {
                dataGridView1.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }


        private void btnBookOperations_Click(object sender, EventArgs e)
        {
            FrmBookOperations frmBookManager = new FrmBookOperations();
            frmBookManager.ShowDialog();
        }

        private void btnMember(object sender, EventArgs e)
        {
            FrmReaderOperations frmReaderOperations = new FrmReaderOperations();
            frmReaderOperations.ShowDialog();
        }

        private void btnClose(object sender, EventArgs e)
        {
            FrmMainLogin frmMainLogin = new FrmMainLogin();
            frmMainLogin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGiveBook frmGiveBook = new FrmGiveBook();
            frmGiveBook.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmTakeBackBook frmTakeBackBook = new FrmTakeBackBook();
            frmTakeBackBook.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmReports frmReports = new FrmReports();
            frmReports.ShowDialog();

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mesajGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMesageSend frmMesage = new FrmMesageSend();
            frmMesage.ShowDialog();
        }
        EscrowBookManager _escBookManager2 = new EscrowBookManager(new EfEscrowBookDal());
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BookTeslimAl();

        }

        private void BookTeslimAl()
        {
            DialogResult dialogResult = MessageBox.Show("Okuyucudan kitabı teslim alıyorsunuz, devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                var result = _escBookManager2.GetById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                result.Data.IsActive = false;
                _escBookManager.Update(result.Data);

                LoadDatagrid();
                MessageBox.Show("Kitap teslim alma işlemi başarı ile sonuçlandı.");
            }
            else
            {
                MessageBox.Show("Kitap teslim alma işlemi iptal edildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void kitapTeslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookTeslimAl();
        }
    }
}
