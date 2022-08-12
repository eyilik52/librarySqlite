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

namespace LibraryProjectApp.Reports
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        EscrowBookManager _escBookManager = new EscrowBookManager(new EfEscrowBookDal());
       
        private void btnBring_Click(object sender, EventArgs e)
        {
            var result = _escBookManager.GetEscrowBookSearchDate(dtFirstDate.Value,dtSecondDate.Value);
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
            var result = _escBookManager.BookDeliveredMember();//Bütün teslimler
            var Teslimler = result.Data;

            var Kitaplar = Teslimler.OrderBy(Ogrenci => Ogrenci.BookName)//sırala
                                     .GroupBy(Ogrenci => Ogrenci.BookName)//grupla
                                     .Select(Kitap => new { Sinif = Kitap.Key, OkunmaSayisi = Kitap.Count() });//seç

            Console.WriteLine("Sınıf öğrenci sayıları :");
            foreach (var Satir in Kitaplar)
            {                
                MessageBox.Show(Satir.Sinif + " İsimli Kitap "+ Satir.OkunmaSayisi + " kez okunmuş..." );
            }

        }

        private void FrmReports_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void kitapKurduSıralamasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBookReports frmBookReports = new FrmBookReports();
            frmBookReports.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
