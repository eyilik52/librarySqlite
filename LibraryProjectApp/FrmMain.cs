using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using LibraryProjectApp.Book;
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
        BookManager bookManager = new BookManager(new EfBookDal());


        private void Form1_Load(object sender, EventArgs e)
        {
            //veritabanıolustur();
            var result = bookManager.GetAll();
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
            MessageBox.Show("oluştueruldsu");
        }
        private static void veritabanıSil()
        {
            LibraryContext context = new LibraryContext();
            context.Database.EnsureDeleted();
            MessageBox.Show("silindi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBookManager frmBookManager = new FrmBookManager();
            frmBookManager.ShowDialog();
        }
    }
}
