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
    public partial class frmOkunanKitaplar : Form
    {
        public frmOkunanKitaplar()
        {
            InitializeComponent();
        }
        EscrowBookDetailManager _escBookDetailManager = new EscrowBookDetailManager(new EfEscrowBookDetailDal());

        
            

       

        private void button1_Click(object sender, EventArgs e)
        {
            var result = _escBookDetailManager.GetAll();//Bütün okunan kitaplar
            var Teslimler = result;

            var Kitaplar = Teslimler.Where(p => p.EkranId == 0).OrderBy(Ogrenci => Ogrenci.ReaderId)//sırala
                                     .GroupBy(Ogrenci => Ogrenci.ReaderId)//grupla
                                     .Select(Kitap => new { Sinif = Kitap.Key, OkunmaSayisi = Kitap.Count() });//seç

            foreach (var Satir in Kitaplar)
            {
                //    dataGridView1.Rows[0].Cells[0].Value = Satir.Sinif;

                MessageBox.Show(Satir.Sinif + " İsimli Kitap " + Satir.OkunmaSayisi + " kez okunmuş...");
            }
        }

        private void frmOkunanKitaplar_Load(object sender, EventArgs e)
        {
            
            var result = _escBookDetailManager.GetAll().Where(p => p.ReaderId == 1).Select(satir => new
            {
                konu = satir.Konu,
                ahmet = satir.ReaderId
            });
            foreach (var x in result)
            {
                
                for (int i = 0; i < result.Count(); i++)
                {
                    
                    dataGridView1.Rows[i].Cells[0].Value = x.ahmet;
                    dataGridView1.Rows[i].Cells[1].Value = x.konu;
                    
                }
                
            }
        }
    }
}
