using Business.Abstract;
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

namespace LibraryProjectApp.Login
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        UserManager _userManager = new UserManager(new EfUserDal());
        ReaderManager _readerManager = new ReaderManager(new EfReaderDal());
        EscrowBookManager _escBookManager = new EscrowBookManager(new EfEscrowBookDal());


         
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmOgrenciEkrani ogrenciEkrani = new FrmOgrenciEkrani();          



            if (cmbUserName.Text != "" && tbxPassword.Text != "")
            {
                var resultgiris = _readerManager.checkLogin(cmbUserName.Text, tbxPassword.Text);
                if (resultgiris.Success)
                {
                    var reader = _readerManager.GetByReaderTc(cmbUserName.Text).Data;
                    //var active = _readerManager.GetByLoginReaderId(reader.Id).Data;
                    if (reader.IsActive != false)
                    {
                        
                        ogrenciEkrani.ReaderId = reader.Id;
                        ogrenciEkrani.lblNameSurname.Text = reader.Name + " " + reader.Surname;
                        var result2 = _escBookManager.GetBooksInMember(reader.Id);
                        //üyelerin elindeki kitabı ekrana yazıdıryoruz.
                        ogrenciEkrani.dataGridView1.DataSource = result2.Data;
                        ogrenciEkrani.ReaderId = reader.Id;
                        ogrenciEkrani.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bloke edilmiş hesap");
                    }
                }
                else
                {
                    MessageBox.Show(resultgiris.Message);
                }
            }
            else
            {
                MessageBox.Show("Lutfen bos alan birakmayiniz.");
            }




            #region ESKİ KODLARIM

            //if (result.Data.Password == tbxPassword.Text)
            //{
            //    Cursor.Current = Cursors.WaitCursor;                
                
            //    ogrenciEkrani.lblNameSurname.Text = result.Data.Name +" "+ result.Data.Surname;
            //    var result2 = _escBookManager.GetBooksInMember(result.Data.Id);
            //    //üyelerin elindeki kitabı ekrana yazıdıryoruz.
            //    ogrenciEkrani.dataGridView1.DataSource = result2.Data;
            //    ogrenciEkrani.ReaderId= result.Data.Id;
            //    ogrenciEkrani.Show();
            //    this.Hide();                      


            //        Cursor.Current = Cursors.Default;
            //}
            //else
            //{
            //    MessageBox.Show("Hatalı Şifre Girdiniz");
            //}

            #endregion
        }

        private void LoginUser_Load(object sender, EventArgs e)
        {
            var userList = _readerManager.GetAll().Data;
            cmbUserName.DataSource = userList;
            cmbUserName.DisplayMember = "Surname";
            cmbUserName.ValueMember = "Id";
        }
    }
}
