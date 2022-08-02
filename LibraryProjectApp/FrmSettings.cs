using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        
        UserManager userManager = new UserManager(new EfUserDal());
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "" && txtPhone.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtAgainPassword.Text != "")
            {
                if (txtPassword.Text == txtAgainPassword.Text)
                {
                    try
                    {
                        if (!userManager.GetAll().Any(x => x.UserName == txtUserName.Text))
                        {
                            User user = new User();
                            user.Name = txtName.Text;
                            user.Surname = txtSurname.Text;
                            user.Phone = txtPhone.Text;
                            user.Mail = txtMail.Text;
                            user.Password = txtPassword.Text;
                            user.UserName = txtUserName.Text;
                            user.positionId =Convert.ToInt32( nmrPozisyon.Value);
                            //user.Satis = checkSatis.Checked;
                            //user.Rapor = checkRapor.Checked;
                            //user.Stok = checkStok.Checked;
                            //user.UrunGiris = checkUrun.Checked;
                            //user.Ayarlar = checkAyarlar.Checked;
                            //user.FiyatGuncelle = checkFiyat.Checked;
                            //user.Yedekleme = checkYedekleme.Checked;
                            userManager.Add(user);
                            MessageBox.Show("Kullanıcı Eklendi");                            
                            UserList();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı zaten kayıtlı");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Hata oluştu.");
                    }

                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen alanları doldurunuz." + "\nAd \nSoyad \nTelefon\nKullanıcı Adı\nŞifre \nŞifre Tekrar");
            }

            
        }
        private void UserList()
        {
            var result = userManager.GetAll();
            dataGridView1.DataSource = result.Select(x => new
            {
                x.UserId,
                x.Name,
                x.Surname,
                x.UserName,
                x.Phone,
                x.Mail,
                x.Password
            }).ToList();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            UserList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = userManager.GetById(Convert.ToInt32(dataGridView1.CurrentRow.Cells["UserId"].Value));
            result.IsActive = false;
            userManager.Update(result);

            MessageBox.Show("Kullanıcı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UserList();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "" && txtPhone.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtAgainPassword.Text != "")
            {
                if (txtPassword.Text == txtAgainPassword.Text)
                {
                    try
                    {
                        User user = new User();
                        user.UserId = (int)dataGridView1.CurrentRow.Cells["UserId"].Value;
                        user.Name = txtName.Text;
                        user.Surname = txtSurname.Text;
                        user.Phone = txtPhone.Text;
                        user.Mail = txtMail.Text;
                        user.Password = txtPassword.Text;
                        user.UserName = txtUserName.Text;
                        user.positionId =Convert.ToInt32( nmrPozisyon.Value);
                        //user.Satis = checkSatis.Checked;
                        //user.Rapor = checkRapor.Checked;
                        //user.Stok = checkStok.Checked;
                        //user.UrunGiris = checkUrun.Checked;
                        //user.Ayarlar = checkAyarlar.Checked;
                        //user.FiyatGuncelle = checkFiyat.Checked;
                        //user.Yedekleme = checkYedekleme.Checked;
                        userManager.Update(user);
                        MessageBox.Show("Kullanıcı Güncellendi");                        
                        UserList();

                    }
                    catch
                    {
                        MessageBox.Show("Hata oluştu.");
                    }

                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen alanları doldurunuz." + "\nAd \nSoyad \nTelefon\nKullanıcı Adı\nŞifre \nŞifre Tekrar");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["UserId"].Value;
            var result = userManager.GetById(id);
            txtName.Text = result.Name;
            txtSurname.Text = result.Surname;
            txtUserName.Text = result.UserName;
            txtPassword.Text = result.Password;
            txtAgainPassword.Text = result.Password;
            txtPhone.Text = result.Phone;
            txtMail.Text = result.Mail;
            //checkSatis.Checked = (bool)result.Satis;
            //checkFiyat.Checked = (bool)result.FiyatGuncelle;
            //checkUrun.Checked = (bool)result.UrunGiris;
            //checkYedekleme.Checked = (bool)result.Yedekleme;
            //checkRapor.Checked = (bool)result.Rapor;
            //checkAyarlar.Checked = (bool)result.Ayarlar;
            //checkStok.Checked = (bool)result.Stok;
        }
    }
}
