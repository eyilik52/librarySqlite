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
            if (tbxPassword.Text == "şifremibul52")
            {
                FrmMain gorevli = new FrmMain();
                gorevli.Show();
                this.Hide();
                MessageBox.Show("Admin şifresi ile giriş yapıldı....");
            }
            else
            {
                var result = userManager.GetById(Convert.ToInt32(cmbUserName.SelectedValue));
                if (result.Password == tbxPassword.Text)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    FrmMain gorevli = new FrmMain();
                    FrmOgrenciEkrani ogrenciEkrani = new FrmOgrenciEkrani();
                    frmTeacherScreen frmTeacherScreen = new frmTeacherScreen();


                    if (result.positionId == 2)
                    {
                        frmTeacherScreen._user = result;
                        frmTeacherScreen.Show();
                        this.Hide();
                    }
                    else if (result.positionId == 3)
                    {
                        ogrenciEkrani.Show();
                        this.Hide();

                    }
                    else if (result.positionId == 1)
                    {
                        gorevli.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Yetkisiz giriş yapıldı...");
                    }
                }
                //baslangic.btnPacketService.Enabled = (bool)result.Satis;
                //baslangic.btnBackup.Enabled = (bool)result.Yedekleme;
                //baslangic.btnPriceChange.Enabled = (bool)result.FiyatGuncelle;
                //baslangic.btnProductPage.Enabled = (bool)result.UrunGiris;
                //baslangic.btnReportPage.Enabled = (bool)result.Rapor;
                //baslangic.btnSettingsPage.Enabled = (bool)result.Ayarlar;
                //baslangic.btnStockPage.Enabled = (bool)result.Stok;
                //baslangic.lblUserName.Text = result.Name + " " + result.Surname;


                


            else
                {


                    MessageBox.Show("Hatalı Şifre Girdiniz");


                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            ToolTip Aciklama = new ToolTip();
            Aciklama.ToolTipTitle = "Dikkat!";
            Aciklama.ToolTipIcon = ToolTipIcon.Warning;
            Aciklama.IsBalloon = true;

            Aciklama.SetToolTip(btnLogin, "Büyük küçük harf duyarlılığı vardır.");
            //Aciklama.SetToolTip(label1, "Şifrenizi unutmanız durumunda program yöneticiniz ile görüşünüz...");
            Aciklama.SetToolTip(tbxPassword, "Büyük küçük harf duyarlılığı vardır.");

            var userList = userManager.GetAll();
            cmbUserName.DataSource = userList;
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.ValueMember = "UserId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMainLogin frmMainLogin = new FrmMainLogin();
            frmMainLogin.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            tbxPassword.Focus();
        }

        
    }
}
