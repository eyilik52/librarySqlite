using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProjectApp.FileBook
{
    public partial class FrmTakeBackBook : Form
    {
        public FrmTakeBackBook()
        {
            InitializeComponent();
            _escrowBookService = new EscrowBookManager(new EfEscrowBookDal());
        }
        IEscrowBookService _escrowBookService;
        EscrowBookManager _escBookManager = new EscrowBookManager(new EfEscrowBookDal());
        FrmMain frmMain= (FrmMain)Application.OpenForms["FrmMain"];

        private void FrmTakeBackBook_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            var result = _escBookManager.BookDeliveredMember();
            if (result.Success)
            {
                dataGridView1.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeslimAl();
        }

        private void TeslimAl()
        {
            DialogResult dialogResult = MessageBox.Show("Okuyucudan kitabı teslim alıyorsunuz, devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                var result = _escrowBookService.GetById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                result.Data.IsActive = false;
                _escBookManager.Update(result.Data);
                LoadGrid();
                frmMain.LoadDatagrid();
                MessageBox.Show("Kitap teslim alma işlemi başarı ile sonuçlandı.");
            }
            else
            {
                MessageBox.Show("Kitap teslim alma işlemi iptal edildi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocument pDoc = new PrintDocument();
            pDoc.DocumentName = "Diploma Kayıt Örneği";
            pDoc.PrintPage += new PrintPageEventHandler(PDoc_Print);
            PrintPreviewDialog pDialog = new PrintPreviewDialog();
            pDialog.Document = pDoc;
            FisNo = FisNo.Replace("[FisNo]", "23768376484");
            Tarih = Tarih.Replace("[Tarih-Saat]", DateTime.Now.ToString());

            pDialog.ShowDialog();
        }
        #region DİPLOMA KAYIT METNİM
        public string FisNo = "Fiş Numarası: [FisNo]";
        public string Tarih = "Tarih/Saat: [Tarih-Saat]";
        public string unvan;

        public string metin = $"\t Metin";
        public string mudur;
        #endregion
        public void PDoc_Print(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(FisNo, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString(Tarih, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(160, 60));
            e.Graphics.DrawString("ÖN", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 85));
            e.Graphics.DrawString("SON", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 90));
            
            e.Graphics.DrawString(metin, new Font("Arial", 10), Brushes.Black, new Point(20, 180));
            e.Graphics.DrawString($"{DateTime.Now:dd.MM.yyyy}", new Font("Arial", 10), Brushes.Black, new Point(600, 300));
            e.Graphics.DrawString(mudur, new Font("Arial", 10), Brushes.Black, new Point(600, 320));
            e.Graphics.DrawString(unvan, new Font("Arial", 10), Brushes.Black, new Point(560, 340));
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(textBox2.Text))
                {
                    SearchBarcode(textBox2.Text);
                    textBox1.Text = "";
                }
                else
                {
                    LoadGrid();
                }
            }
        }

        public void SearchBarcode(string key)
        {
            var result = _escBookManager.GetBarcodeSearch(key);
            if (result.Success)
            {
                dataGridView1.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        public void SearchBookName(string key)
        {
            var result = _escBookManager.GetBookNameSearch(key);
            if (result.Success)
            {
                dataGridView1.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        public void SearchReaderName(string key)
        {
            var result = _escBookManager.GetReaderNameSearch(key);
            if (result.Success)
            {
                dataGridView1.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }


        private void kitapTeslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeslimAl();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                SearchBookName(textBox1.Text);
            }
            else
            {
                LoadGrid();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                SearchReaderName(textBox3.Text);
            }
            else
            {
                LoadGrid();
            }
        }
    }
}
