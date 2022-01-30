using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using LibraryProjectApp.FileBook;
using LibraryProjectApp.FileReader;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        EscrowBookManager _escBookManager = new EscrowBookManager(new EfEscrowBookDal());


        private void Form1_Load(object sender, EventArgs e)
        {
            //veritabanıSil();
            //veritabanıolustur();
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

        private static void veritabanıolustur()
        {
            LibraryContext context = new LibraryContext();
            context.Database.EnsureCreated();
            MessageBox.Show("oluşturuldu");
        }
        private static void veritabanıSil()
        {
            LibraryContext context = new LibraryContext();
            context.Database.EnsureDeleted();
            MessageBox.Show("silindi");
        }        

        private void btnBookOperations_Click(object sender, EventArgs e)
        {
            FrmBookOperations frmBookManager = new FrmBookOperations();
            frmBookManager.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmReaderOperations frmReaderOperations = new FrmReaderOperations();
            frmReaderOperations.ShowDialog();
        }

        private void btnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGiveBook frmGiveBook = new FrmGiveBook();
            frmGiveBook.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmTakeBackBook frmTakeBackBook = new FrmTakeBackBook();
            frmTakeBackBook.ShowDialog();
        }
    }
}
