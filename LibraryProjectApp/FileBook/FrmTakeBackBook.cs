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
    public partial class FrmTakeBackBook : Form
    {
        public FrmTakeBackBook()
        {
            InitializeComponent();
            _escrowBookService = new EscrowBookManager(new EfEscrowBookDal());
        }
        IEscrowBookService _escrowBookService;
        EscrowBookManager _escBookManager = new EscrowBookManager(new EfEscrowBookDal());
        private void FrmTakeBackBook_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            var result = _escBookManager.BookDeliveredMember();
            if (result.Success)
            {
                dataGridView1.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = _escrowBookService.GetById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            //result.Data.IsActive = false;
            _escBookManager.Update(new EscrowBook
            {
                Id=result.Data.Id,
                IsActive = false
            }) ;
            LoadGrid();
            MessageBox.Show("Kitap teslim alma işlemi başarı ile sonuçlandı.");
        }
    }
}
