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
    public partial class FrmKitapKurduSiralama : Form
    {
        public FrmKitapKurduSiralama()
        {
            InitializeComponent();
        }
        EscrowBookDetailManager _escrowBookDetailManager = new EscrowBookDetailManager(new EfEscrowBookDetailDal());
        ReaderManager Rmanager = new ReaderManager(new EfReaderDal());

        private void FrmBookReports_Load(object sender, EventArgs e)
        {
            

            //listView1.View = View.Details;
            //listView1.GridLines = true;
            //listView1.FullRowSelect = true;


            //listView1.Columns.Add("Adı", 100);
            //listView1.Columns.Add("Soyadı", 130);
            //listView1.Columns.Add("Onaylanan Kitap", 70);
            //listView1.Columns.Add("Toplam Notu", 70);

            List<int> okunanKitap = new List<int>(); 
            List<int> ReaderId = new List<int>();
            int ToplamNotu;
            var result = _escrowBookDetailManager.GetKitapKurdu();
            for (int i = 0; i < result.Count; i++)
            {
                okunanKitap.Add(result[i].BookId);
                ReaderId.Add(result[i].ReaderId);
            }
            
            for (int i = 0; i < ReaderId.Count; i++)
            {               

                var resultReader = Rmanager.GetById(ReaderId[i]);
                int okuduguKitapSayisi= okunanKitap[i];
                ToplamNotu = _escrowBookDetailManager.Notlar(resultReader.Data.Id);
                dataGridView1.ColumnCount = 5;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = resultReader.Data.Name;
                dataGridView1.Rows[i].Cells[2].Value = resultReader.Data.Surname;
                dataGridView1.Rows[i].Cells[3].Value = okunanKitap[i].ToString();
                dataGridView1.Rows[i].Cells[4].Value = ToplamNotu.ToString();

                //Listview içindir.

                //string[] row = { resultReader.Data.Name, resultReader.Data.Surname, okunanKitap[i].ToString(), ToplamNotu.ToString() };
                //var satir = new ListViewItem(row);
                //listView1.Items.Add(satir);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int notlar= _escrowBookDetailManager.Notlar(1);
            MessageBox.Show(notlar.ToString());
        }
    }
}
