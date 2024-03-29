﻿
using Business.Abstract;
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

namespace LibraryProjectApp.FileBook
{
    public partial class FrmGiveBook : Form
    {
        public FrmGiveBook()
        {
            InitializeComponent();
            _bookService = new BookManager(new EfBookDal());
            _readerService = new ReaderManager(new EfReaderDal());
            _escrowBookService = new EscrowBookManager(new EfEscrowBookDal());
        }
        IBookService _bookService;
        IReaderService _readerService;
        IEscrowBookService _escrowBookService;
        EscrowBookDetailManager _escrowBookDetail = new EscrowBookDetailManager(new EfEscrowBookDetailDal());//detay tablosu için
        FrmMain frmMain = (FrmMain)Application.OpenForms["FrmMain"];
        private void FrmGiveBook_Load(object sender, EventArgs e)
        {
            lblDeliveryDate.Text = DateTime.Today.ToShortDateString();
            dgwMember.DataSource = _readerService.GetAll().Data;
            dgwBook.DataSource = _bookService.GetAll().Data;
        }

        private void dgwMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKimlikNo.Text = dgwMember.CurrentRow.Cells[1].Value.ToString();
            tbxNameSurname.Text = dgwMember.CurrentRow.Cells[2].Value.ToString() + " " + dgwMember.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgwBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBarkotNumber.Text = dgwBook.CurrentRow.Cells[1].Value.ToString();
            tbxBookName.Text = dgwBook.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    lblDeliveryDate.Text = DateTime.Now.AddDays(+Convert.ToInt32(textBox1.Text)).ToShortDateString();
                }
                else
                {
                    lblDeliveryDate.Text = DateTime.Today.ToShortDateString();
                }
            }
            catch
            {
                string a = textBox1.Text;
                MessageBox.Show(a + " Bir sayı değildir. Lütfen kitabın geri alınacağı gün bilgisini giriniz...", "Hatalı Bilgi Girişi Yaptınız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbxNameSurname.Text == "" && tbxBookName.Text == "")
            {
                MessageBox.Show("Kitap ve Okuyucu ismi girişi yapılmadı...", "Veri Eksikliği", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Boolean IsThere = false;
                var result = _escrowBookService.GetAllEscrowReaderId(Convert.ToInt32(dgwMember.CurrentRow.Cells[0].Value));

                for (int i = 0; i < result.Data.Count; i++)
                {
                    //int newReaderId = result.Data[i].ReaderId;
                    if (result.Data[i].IsActive == true)
                    {
                        IsThere = true;
                        break;
                    }

                }
                if (IsThere == false)
                {
                    //try
                    //{
                        _escrowBookService.Add(new EscrowBook
                        {
                            BookId = Convert.ToInt32(dgwBook.CurrentRow.Cells[0].Value),
                            ReaderId = Convert.ToInt32(dgwMember.CurrentRow.Cells[0].Value),
                            DeliveryDate = Convert.ToDateTime(lblDeliveryDate.Text),
                            TransactionDate = DateTime.Now,
                             EkranId = 1
                        }
                        );
                      
                        
                        _escrowBookDetail.Add(new EscrowBookDetail//detay tablosunu burada oluştur
                        {
                            ReaderId = Convert.ToInt32(dgwMember.CurrentRow.Cells[0].Value),
                            BookId = Convert.ToInt32(dgwBook.CurrentRow.Cells[0].Value),
                            EkranId =1 
                        });
                        frmMain.LoadDatagrid();
                        MessageBox.Show("Okuyucu için dönüt tablosu oluşturuldu.");


                        MessageBox.Show("Kitap Teslim işlemi başarılı bir şekilde gerçekleştirildi.");
                    //}
                    //catch (Exception exception)
                    //{
                    //    MessageBox.Show(exception.Message);
                    //}
                }
                else
                {
                    MessageBox.Show("Üye teslim etmesi gereken kitabı teslim etmemiş, Tekrar kitap verilemez...");
                }



            }
        }

        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxKimlikNo.Text = dgwMember.CurrentRow.Cells[1].Value.ToString();
            tbxNameSurname.Text = dgwMember.CurrentRow.Cells[2].Value.ToString() + " " + dgwMember.CurrentRow.Cells[3].Value.ToString();
        }

        private void seçToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbxBarkotNumber.Text = dgwBook.CurrentRow.Cells[1].Value.ToString();
            tbxBookName.Text = dgwBook.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
