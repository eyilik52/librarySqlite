
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
        private void FrmGiveBook_Load(object sender, EventArgs e)
        {
            lblDeliveryDate.Text = DateTime.Today.ToShortDateString();
           dgwMember.DataSource= _readerService.GetAll().Data;
            dgwBook.DataSource = _bookService.GetAll().Data;
        }

        private void dgwMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           tbxKimlikNo.Text=dgwMember.CurrentRow.Cells[1].Value.ToString();
            tbxNameSurname.Text = dgwMember.CurrentRow.Cells[2].Value.ToString()+" "+dgwMember.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgwBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBarkotNumber.Text = dgwBook.CurrentRow.Cells[1].Value.ToString();
            tbxBookName.Text = dgwBook.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
               lblDeliveryDate.Text= DateTime.Now.AddDays(+Convert.ToInt32(textBox1.Text)).ToShortDateString();
            }
            else
            {
                lblDeliveryDate.Text = DateTime.Today.ToShortDateString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean IsThere=false;
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
            if (IsThere==false)
            {
                try
                {
                    _escrowBookService.Add(new EscrowBook
                    {
                        BookId = Convert.ToInt32(dgwBook.CurrentRow.Cells[0].Value),
                        ReaderId = Convert.ToInt32(dgwMember.CurrentRow.Cells[0].Value),
                        DeliveryDate = Convert.ToDateTime(lblDeliveryDate.Text),
                        TransactionDate = DateTime.Now
                    }
                    );
                    MessageBox.Show("Kitap Teslim işlemi başarılı");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                   MessageBox.Show("Üye teslim etmesi gereken kitabı teslim etmemiş, Tekrar kitap verilemez...");
            }   
        }
    }
}
