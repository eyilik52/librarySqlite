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
    public partial class FrmMainLogin : Form
    {
        public FrmMainLogin()
        {
            InitializeComponent();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.ToolTipTitle = "Hoş Geldiniz!...";
            Aciklama.ToolTipIcon = ToolTipIcon.Warning;
            Aciklama.IsBalloon = true;

            Aciklama.SetToolTip(button2, "Uygulamaya giriş için Kimlik Numaranızı ve Şifrenizi kullanmalısınız...");
            Aciklama.SetToolTip(button3, "Sadece Öğretmen kullanıcıları giriş yapabilir...");
            Aciklama.SetToolTip(button1, "Sadece kütüphane görevlilerinin giriş yapabileceği bir ekrandır...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmGrvli = new FrmLogin();
            frmGrvli.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login.LoginUser loginUser = new Login.LoginUser();
            loginUser.ShowDialog();
            this.Hide();
        }

        

        private static void veritabanıolustur()
        {
            LibraryContext context = new LibraryContext();
            context.Database.EnsureCreated();
            MessageBox.Show("oluşturuldu");
        }
        private static void veritabanıSil()
        {
            LibraryContext context = new LibraryContext();
            context.Database.EnsureDeleted();
            MessageBox.Show("silindi");
        }

       

        private void FrmMainLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.LoginTeacher loginTeacher = new Login.LoginTeacher();
            loginTeacher.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            veritabanıSil();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            veritabanıolustur();
        }
        
    }
}

