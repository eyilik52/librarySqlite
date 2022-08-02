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

        public Book _book;
        public Reader _reader;
        public EscrowBookDetail detay;
        private void frmTeacherScreen_Load(object sender, EventArgs e)
        {
            listele();

        }

        public void listele()
        {
            var result = _escrowBookDetailManager.GetTeacherScreen();
            if (result.Count!=0)
            {
                detay = result[0];
                for (int i = 0; i < result.Count; i++)
                {
                    int readerId = result[i].ReaderId;
                    int bookId = result[i].BookId;
                    _book = _bookManager.GetById(bookId).Data;
                    _reader = _readerManager.GetById(readerId).Data;

                    dataGridView1.Rows[i].Cells[1].Value = result[i].Id;
                    dataGridView1.Rows[i].Cells[2].Value = _book.BookName;
                    dataGridView1.Rows[i].Cells[3].Value = _book.AuthorName;
                    dataGridView1.Rows[i].Cells[4].Value = _reader.Name;
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
            frmDeger.lblReaderName.Text = _reader.Name + " " + _reader.Surname;
            frmDeger.lblBookName.Text = _book.BookName;
            frmDeger.lblAuthorName.Text = _book.AuthorName;
            frmDeger.tbxAnaFikir.Text = detay.AnaFikir;
            frmDeger.tbxEtkiOlay.Text = detay.Ozet;
            frmDeger.Show();
        }
    }
}
