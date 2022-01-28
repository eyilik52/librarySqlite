
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

namespace LibraryProjectApp.FileBook
{
    public partial class FrmGiveBook : Form
    {
        public FrmGiveBook()
        {
            InitializeComponent();
            _bookService = new BookManager(new EfBookDal());
            _readerService = new ReaderManager(new EfReaderDal());
        }
        IBookService _bookService;
        IReaderService _readerService;
        private void FrmGiveBook_Load(object sender, EventArgs e)
        {
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
    }
}
