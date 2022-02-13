using Entities.Concrete;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProjectApp.Reports
{
    public partial class FrmReportMember : Form
    {
        public FrmReportMember()
        {
            InitializeComponent();
        }
        



        private void button1_Click(object sender, EventArgs e)
        {
            ////ileti merkezi mesaj atma...
            //SmsApiService smsApi = new SmsApiService();
            //smsApi.SmsSender(tbxTelephone.Text, tbxMessage.Text);

            try

                 {       
                         // Kullanici adi, parola ve Originator kullanilarak bir sms paketi olusturulur.
                         MutluCell mutluCell = new MutluCell("BELEN12","belen000672","BEKO BELEN");
                         

                         // eger ileri tarihli sms gonderilecekse tarh parametreli asagidai Consturctor kullanilabilir
                         // ornek: 2066-11-20 saat 19:30:00 'da gonder
                         //SMSPaketi smspak = new SMSPaketi("user","123456","MUTLUCELL", new DateTime(2006,11,20,19,30,0));

                         

                         // mesajin gidecegi numaralar bir array'e doldurulur
                         // numara formati onemli degildir, bosluklu parantezli, sifirli, sifirsiz, +90li vs olabilir
                         String[] numaralar = {"5462835236"};

                         

                         // gidecek mesaj metni ve numaralar pakaete eklenir. 
                         // bu sekilde bir sms paketine birden fazla mesaj eklenebilir
                         mutluCell.addSMS("Merhaba. Bu bir denemedir.",numaralar);                        

                         // sonuc eger mesaj basarili ise # ile baslayan bir mesaj ID'dir. 
                         // bir hata olusmussa XML dokumaninda belirtilen hata kodlarindan biri doner

                         String sonuc = mutluCell.gonder();
                         MessageBox.Show( sonuc );

 

                         //Raporun cekilmesi
                         // rapor kullanici adi, parola ve mesaj gonderme isleminde sonuc olarak donen 
                         // message ID ile cekilir. XML dokumaninda belirtilen formatta doner

                         String rapor = MutluCell.rapor("BELEN12", "belen000672", 156675);
                         MessageBox.Show( rapor );
                 }

                 catch(Exception ex){

                         MessageBox.Show( "Hata: " + ex );

                 }
		}

        private void button1_Click_1(object sender, EventArgs e)
        {
            String rapor = MutluCell.rapor("BELEN12", "belen000672", 2);
            MessageBox.Show(rapor);
        }
    }
}
