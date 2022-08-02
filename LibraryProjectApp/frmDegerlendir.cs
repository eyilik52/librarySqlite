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
           var result= _escrowBookDetail.GetById(frmTeacher.detay.Id);
            _escrowBookDetail.Update(new EscrowBookDetail
            {
                Id = result.Id,
                 AnaFikir =result.AnaFikir,
                  BookId= result.BookId,
                   EkranId=0,                    
                     Ozet=result.Ozet,
                      ReaderId=result.Id
            });
            
            
            frmTeacher.listele();
            MessageBox.Show("Test");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //güncelleme komutu yaz
            frmTeacher.detay.EkranId = 1;//red
            frmTeacher.listele();
        }
    }
}
