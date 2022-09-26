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
            //YENİLEMEYİDE AKTİF ET

        }

        public void BookInMemeber()//üyelerin elindeki kitabı ekrana yazıdıryoruz.
        {
            var result2 = _escrowBookDetailManager.GetBooksInMember(_reader.Id);
            

            _getBookInMember = result2.Data;
            dataGridView1.DataSource = result2.Data;
            //if (result2.Data.Count!=0)
            //{
            //    for (int i = 0; i < result2.Data.Count; i++)
            //    {
            //        //kİTAP BİLGİSİNİ DATAGRİDDEN ALIP TEKRAR DATAGRİD DOLDURUYORUM.
            //        int bookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            //        //int bookId = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

            //        var book = _bookManager.GetById(bookId).Data;
            //        _book = book;

            //        var resultNew = _escrowBookDetailManager.GetBooksInMemberKesin(_reader.Id, _book.Id);
            //        dataGridView1.DataSource = resultNew.Data;
            //    }
                
            //}
            
        }       

        private void özetGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            
                FrmKitapDonut kitapDonut = new FrmKitapDonut();

                kitapDonut.lblReaderName.Text = _reader.Name + " " + _reader.Surname;
                kitapDonut.lblBookName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                kitapDonut.lblAuthorName.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                int bookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                var book = _bookManager.GetById(bookId).Data;
                _book = book;
                var result = detayManager.GetReaderandBookId(_reader.Id, _book.Id);
                _escrowBookDetail = result;



                if (result.Count == 0)
                {
                    kitapDonut.Show();
                }
                else
                {
                kitapDonut.tbxAnaFikir.Text = result[0].AnaFikir;
                kitapDonut.tbxKonu.Text = result[0].Konu;
                kitapDonut.tbxAnaFikir.Text = result[0].AnaFikir;
                kitapDonut.tbxKonu.Text = result[0].Konu;
                kitapDonut.tbxAnlaticiTur.Text = result[0].AnlaticiTuru;
                kitapDonut.tbxBegenildimi.Text = result[0].KitapBegenildimi;
                kitapDonut.tbxEniyiIfade.Text = result[0].EniyiIfade;
                kitapDonut.tbxKisiKadrosu.Text = result[0].KisiKadrosu;
                kitapDonut.tbxZaman.Text = result[0].Zaman;
                kitapDonut.tbxMekan.Text = result[0].Mekan;
                kitapDonut.tbxTavsiye.Text = result[0].Tavsiye;
                kitapDonut.tbxKitapSonu.Text = result[0].SizceKitapSonu;
                kitapDonut.Show();                
                }
            //}
            //catch 
            //{

            //    MessageBox.Show("Herhangi bir seçim yapılmadı. ");
            //}
            
            
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookInMemeber();
        }

        private void kitapKurduSıralamamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.FrmKitapKurduSiralama frmBook = new Reports.FrmKitapKurduSiralama();
            frmBook.ShowDialog();
        }
    }
}
