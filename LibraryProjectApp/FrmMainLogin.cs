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
            loginUser.Show();
            this.Hide();
        }
    }
}
