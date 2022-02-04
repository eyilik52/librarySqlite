using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        UserManager userManager = new UserManager(new EfUserDal());
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = userManager.GetById(Convert.ToInt32(cmbUserName.SelectedValue));
            if (result.Password == tbxPassword.Text)
            {
                Cursor.Current = Cursors.WaitCursor;
                FrmMain baslangic = new FrmMain();
                //baslangic.btnPacketService.Enabled = (bool)result.Satis;
                //baslangic.btnBackup.Enabled = (bool)result.Yedekleme;
                //baslangic.btnPriceChange.Enabled = (bool)result.FiyatGuncelle;
                //baslangic.btnProductPage.Enabled = (bool)result.UrunGiris;
                //baslangic.btnReportPage.Enabled = (bool)result.Rapor;
                //baslangic.btnSettingsPage.Enabled = (bool)result.Ayarlar;
                //baslangic.btnStockPage.Enabled = (bool)result.Stok;
                //baslangic.lblUserName.Text = result.Name + " " + result.Surname;
                baslangic.Show();
                this.Hide();
                Cursor.Current = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Hatalı Şifre Girdiniz");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var userList = userManager.GetAll();
            cmbUserName.DataSource = userList;
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.ValueMember = "UserId";
        }
    }
}
