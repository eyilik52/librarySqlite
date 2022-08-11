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
                    BookId = frmOgrenciEkrani._book.Id,
                    AnlaticiTuru = tbxAnlaticiTur.Text,
                    EniyiIfade = tbxEniyiIfade.Text,
                    KisiKadrosu = tbxKisiKadrosu.Text,
                    KitapBegenildimi = tbxBegenildimi.Text,
                    Mekan = tbxMekan.Text,
                    SizceKitapSonu = tbxKitapSonu.Text,
                    Tavsiye = tbxTavsiye.Text,
                    Zaman = tbxZaman.Text,
                    EkranId = 1

                });
                MessageBox.Show("Güncelleme Yapıldı.");
            }
            MessageBox.Show("Bilgiler kaydedildi. İncelenmesi için ilgili butona tıklayarak bilgileri gönderebilirsiniz.", "Uyarı", MessageBoxButtons.OK);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try//bookId kısmı arada gelmiyor. 
            {
                DialogResult resultOnay = MessageBox.Show("Girdiğiniz bilgiler değerlendirici öğretmen ekranına düşecektir. Bu işlem geri alınamaz. Yine de bilgileri göndermek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,MessageBoxDefaultButton.Button3 );
                if (resultOnay==DialogResult.Yes)
                {
                    var result = _escrowBookDetail.GetById(frmOgrenciEkrani._escrowBookDetail[0].Id);
                    result.EkranId = 2;
                    _escrowBookDetail.Update(result);
                    frmOgrenciEkrani.BookInMemeber();
                    btnSave.Enabled = false;
                    btnSend.Enabled = false;
                    MessageBox.Show("Güncelleme Yapıldı.");
                }
                else
                {
                    MessageBox.Show("Gönderim işlemi iptal edildi.");
                }
                
            }
            catch 
            {

                MessageBox.Show("Program bir hatayla karşılaştı. Lütfen Sayfayı kapatıp yeniden gönderim yapınız. Eğer kaydetme işlemi yaptıysanız verileriniz kaybolmadı...");
            }
            
        }

        
    }
}
