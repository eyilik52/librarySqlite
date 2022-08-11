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
    public partial class frmDegerlendir : Form
    {
        public frmDegerlendir()
        {
            InitializeComponent();
        }
        frmTeacherScreen frmTeacher = (frmTeacherScreen)Application.OpenForms["frmTeacherScreen"];
        EscrowBookDetailManager _escrowBookDetail = new EscrowBookDetailManager(new EfEscrowBookDetailDal());
        LibraryContext lbcontext = new LibraryContext();
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            DialogResult resultOnay = MessageBox.Show("Onaylama işlemine devam etmeniz durumunda ilgili kitap öğrencinin okuduğu kitap listesine eklenecektir. Bu işlem geri alınamaz. Yine de bilgileri göndermek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (resultOnay==DialogResult.Yes)
            {
                var result = _escrowBookDetail.GetById(frmTeacher.detay.Id);
                _escrowBookDetail.Update(new EscrowBookDetail
                {

                    Id = result.Id,
                    AnaFikir = result.AnaFikir,
                    BookId = result.BookId,
                    EkranId = 0,
                    Konu = result.Konu,
                    ReaderId = result.ReaderId,
                    AnlaticiTuru = result.AnlaticiTuru,
                    SizceKitapSonu = result.SizceKitapSonu,
                    Tavsiye = result.Tavsiye,
                    Zaman = result.Zaman,
                    EniyiIfade = result.EniyiIfade,
                    KisiKadrosu = result.KisiKadrosu,
                    KitapBegenildimi = result.KitapBegenildimi,
                    Mekan = result.KitapBegenildimi,
                    Notu = cmbDegerlendir.SelectedIndex + 1

                });


                frmTeacher.listele();
                MessageBox.Show("Öğrenci özeti onaylandı, değerlendirme notu veritabanına işlendi.","Onay Ekranı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Onay işlemi iptal edildi.","İptal Ekranı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DialogResult resultRed = MessageBox.Show("Onaylamanız durumunda kitabın okunduğuna onay vermemiş olacaksınız ve kitap yeniden öğrenci ekranına gönderilecektir. Bu işlem geri alınamaz. Yine de bilgileri göndermek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (resultRed==DialogResult.Yes)
            {
                var result = _escrowBookDetail.GetById(frmTeacher.detay.Id);
                result.EkranId = 1;
                _escrowBookDetail.Update(result);
                frmTeacher.listele();
            }
            else
            {
                MessageBox.Show("Red işlemi iptal edildi.", "Çıkış Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }
    }
}
