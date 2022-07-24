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

namespace LibraryProjectApp
{
    public partial class FrmOgrenciEkrani : Form
    {
        public FrmOgrenciEkrani()
        {
            InitializeComponent();
        }
        ReaderManager readerManager = new ReaderManager(new EfReaderDal());
        public int ReaderId;
        private void FrmOgrenciEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmOgrenciEkrani_Load(object sender, EventArgs e)
        {

        }

        private void özetGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKitapDonut kitapDonut = new FrmKitapDonut();
            var result = readerManager.GetById(ReaderId); 
            kitapDonut.lblReaderName.Text = result.Data.Name + " " + result.Data.Surname;
            kitapDonut.lblBookName.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kitapDonut.lblAuthorName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
            kitapDonut.Show();
        }

        
    }
}
