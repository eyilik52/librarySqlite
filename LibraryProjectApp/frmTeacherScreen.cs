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
    public partial class frmTeacherScreen : Form
    {
        public frmTeacherScreen()
        {
            InitializeComponent();
        }

        EscrowBookDetailManager _escrowBookDetailManager = new EscrowBookDetailManager(new EfEscrowBookDetailDal());
        BookManager _bookManager = new BookManager(new EfBookDal());
        ReaderManager _readerManager = new ReaderManager(new EfReaderDal());
        public User _user;

        public Book _book;
        public Reader _reader;
        public EscrowBookDetail detay;
        private void frmTeacherScreen_Load(object sender, EventArgs e)
        {
            lblNameSurname.Text = _user.Name + " " + _user.Surname;
            listele();
        }

        public void listele()
        {
            dataGridView1.Rows.Clear();
            var result = _escrowBookDetailManager.GetTeacherScreen();
            if (result.Count!=0)
            {
                detay = result[0];
                
                for (int i = 0; i < result.Count; i++)
                {
                    int readerId = result[i].ReaderId;
                    _reader = _readerManager.GetById(readerId).Data;
                    int bookId = result[i].BookId;
                    _book = _bookManager.GetById(bookId).Data;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[1].Value = result[i].Id;
                    dataGridView1.Rows[i].Cells[2].Value = _book.BookName;
                    dataGridView1.Rows[i].Cells[3].Value = _book.AuthorName;
                    dataGridView1.Rows[i].Cells[4].Value = _reader.Name;
                    dataGridView1.Rows[i].Cells[4].Value = _reader.Surname;
                }
            }
            else
            {
                dataGridView1.DataSource = "";
            }          
            
        }

        private void ozetdegerlendir_Click(object sender, EventArgs e)
        {
            frmDegerlendir frmDeger = new frmDegerlendir();
            frmDeger.lblReaderName.Text = _user.Name + " " + _user.Surname;
            frmDeger.lblBookName.Text = _book.BookName;
            frmDeger.lblAuthorName.Text = _book.AuthorName;
            frmDeger.tbxAnaFikir.Text = detay.AnaFikir;
            frmDeger.tbxKonu.Text = detay.Konu;
            frmDeger.tbxAnlaticiTur.Text = detay.AnlaticiTuru;
            frmDeger.tbxBegenildimi.Text = detay.KitapBegenildimi;
            frmDeger.tbxEniyiIfade.Text = detay.EniyiIfade;
            frmDeger.tbxKisiKadrosu.Text = detay.KisiKadrosu;
            frmDeger.tbxZaman.Text = detay.Zaman;
            frmDeger.tbxMekan.Text = detay.Mekan;
            frmDeger.tbxTavsiye.Text = detay.Tavsiye;
            frmDeger.tbxKitapSonu.Text = detay.SizceKitapSonu;
            frmDeger.Show();
        }

        private void frmTeacherScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
