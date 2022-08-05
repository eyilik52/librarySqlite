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

namespace LibraryProjectApp
{
    public partial class FrmKitapDonut : Form
    {
        public FrmKitapDonut()
        {
            InitializeComponent();
        }
        EscrowBookDetailManager _escrowBookDetail = new EscrowBookDetailManager(new EfEscrowBookDetailDal());
        EscrowBookManager _escrowBookManager = new EscrowBookManager(new EfEscrowBookDal());
        FrmOgrenciEkrani frmOgrenciEkrani = (FrmOgrenciEkrani)Application.OpenForms["FrmOgrenciEkrani"];

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (frmOgrenciEkrani._escrowBookDetail.Count==0)
            {
                _escrowBookDetail.Add(new EscrowBookDetail
                {
                    AnaFikir = tbxAnaFikir.Text,
                    Konu = tbxKonu.Text,
                    ReaderId = frmOgrenciEkrani._reader.Id,
                    BookId=frmOgrenciEkrani._book.Id,
                    AnlaticiTuru=tbxAnlaticiTur.Text,
                    EniyiIfade=tbxEniyiIfade.Text,
                    KisiKadrosu=tbxKisiKadrosu.Text,
                    KitapBegenildimi=tbxBegenildimi.Text,
                    Mekan=tbxMekan.Text,
                    SizceKitapSonu=tbxKitapSonu.Text,
                    Tavsiye=tbxTavsiye.Text,
                    Zaman=tbxZaman.Text 
                });
                MessageBox.Show("Yeni kayıt oluşturuldu.");
            }
            else
            {
                _escrowBookDetail.Update(new EscrowBookDetail
                {
                    Id = frmOgrenciEkrani._escrowBookDetail[0].Id,
                    AnaFikir = tbxAnaFikir.Text,
                    Konu = tbxKonu.Text,
                    ReaderId = frmOgrenciEkrani._reader.Id,
                    BookId = frmOgrenciEkrani._escrowBookDetail[0].BookId,
                    EkranId = 1

                }) ;
                MessageBox.Show("Güncelleme Yapıldı.");
            }
            

            MessageBox.Show("Bilgiler kaydedildi. İncelenmesi için ilgili butona tıklayarak bilgileri gönderebilirsiniz.");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try//bookId kısmı arada gelmiyor. 
            {
                _escrowBookDetail.Update(new EscrowBookDetail
                {
                    Id = frmOgrenciEkrani._escrowBookDetail[0].Id,
                    AnaFikir = tbxAnaFikir.Text,
                    Konu = tbxKonu.Text,
                    ReaderId = frmOgrenciEkrani._reader.Id,
                    BookId = frmOgrenciEkrani._escrowBookDetail[0].BookId,// hatalı satır
                    EkranId = 2

                });
                //_escrowBookManager.Update(new EscrowBook
                //{
                //    Id = frmOgrenciEkrani._getBookInMember[0].EscBookId,
                //    EkranId = 2
                //});
                //EscrowBook escrow = new EscrowBook();
                //escrow.Id = frmOgrenciEkrani._getBookInMember[0].EscBookId;
                //escrow.EkranId = 2;
                //_escrowBookManager.Update(escrow);



                frmOgrenciEkrani.BookInMemeber();
                btnSave.Enabled = false;
                btnSend.Enabled = false;

                MessageBox.Show("Güncelleme Yapıldı.");
            }
            catch 
            {

                MessageBox.Show("Program bir hatayla karşılaştı. Lütfen Sayfayı kapatıp yeniden gönderim yapınız. Eğer kaydetme işlemi yaptıysanız verileriniz kaybolmadı...");
            }
            
        }
    }
}
