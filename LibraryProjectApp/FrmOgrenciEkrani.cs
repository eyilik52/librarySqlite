using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class FrmOgrenciEkrani : Form
    {
        public FrmOgrenciEkrani()
        {
            InitializeComponent();
        }

        ReaderManager readerManager = new ReaderManager(new EfReaderDal());
        public Reader _reader;
        public Book _book;
        public List<EscrowBookDetail> _escrowBookDetail;
        public List<GetBooksInMember> _getBookInMember;

        EscrowBookManager _escBookManager = new EscrowBookManager(new EfEscrowBookDal());
        EscrowBookDetailManager _escrowBookDetailManager = new EscrowBookDetailManager(new EfEscrowBookDetailDal());

        EscrowBookDetailManager detayManager = new EscrowBookDetailManager(new EfEscrowBookDetailDal());
        BookManager _bookManager = new BookManager(new EfBookDal());

        private void FrmOgrenciEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void FrmOgrenciEkrani_Load(object sender, EventArgs e)
        {
            lblNameSurname.Text = _reader.Name + " " + _reader.Surname;         

            BookInMemeber();

            
        }

        public void BookInMemeber()//üyelerin elindeki kitabı ekrana yazıdıryoruz.
        {
            var result2 = _escrowBookDetailManager.GetBooksInMember(_reader.Id);         
            dataGridView1.DataSource = result2.Data;
            _getBookInMember = result2.Data;
        }

        

        private void özetGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKitapDonut kitapDonut = new FrmKitapDonut();
             
            kitapDonut.lblReaderName.Text = _reader.Name + " " + _reader.Surname;
            kitapDonut.lblBookName.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kitapDonut.lblAuthorName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            int bookId=Convert.ToInt32( dataGridView1.CurrentRow.Cells[3].Value);
           var book = _bookManager.GetById(bookId).Data;
            _book = book;
            var result = detayManager.GetReaderandBookId(_reader.Id,_book.Id);
            _escrowBookDetail = result;

            

            if (result.Count==0)
            {
                kitapDonut.Show();
            }
            else
            {
                kitapDonut.tbxAnaFikir.Text = result[0].AnaFikir;
                kitapDonut.tbxEtkiOlay.Text = result[0].Ozet;
                kitapDonut.Show();
            }
            
        }

        
    }
}
