using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
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

namespace LibraryProjectApp.FileReader
{
    public partial class FrmReaderOperations : Form
    {
        public FrmReaderOperations()
        {
            InitializeComponent();
            _readerService = new ReaderManager(new EfReaderDal());
        }

        private IReaderService _readerService;

        ReaderManager Rmanager = new ReaderManager(new EfReaderDal());
        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _readerService.Add(new Reader
                {
                    Tc = tbxIdentityNo.Text,
                    Name = tbxName.Text,
                    Surname = tbxSurname.Text,
                    Phone = tbxPhoneNumber.Text,
                    Mail = tbxMailAdresess.Text,
                    Address = tbxAdresess.Text,
                    DateOfRegistration = dtDateOfRegistration.Value,
                    ClassRoombranch = Convert.ToChar(cmbBransh.Text),
                    ClassRoomId = (int)nmrcClass.Value
                }
                );
                LoadReaderDetails();
                MessageBox.Show("Okyucu kaydetme işlemi başarılı");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void FrmReaderOperations_Load(object sender, EventArgs e)
        {
            LoadReaderDetails();
        }

        private void LoadReaderDetails()
        {
            DgwBook.DataSource = _readerService.GetReaderDetails().Data;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Reader Update = new Reader();
            var row = DgwBook.CurrentRow;
            Update.Id = Convert.ToInt32(row.Cells[0].Value);
            Update.Name = tbxName.Text;
            Update.Surname=tbxSurname.Text;
            Update.Mail = tbxMailAdresess.Text;
            Update.Phone = tbxPhoneNumber.Text;            
            Update.Tc = tbxIdentityNo.Text;
            Update.ClassRoomId =Convert.ToInt32( nmrcClass.Value);
            Update.ClassRoombranch =Convert.ToChar(cmbBransh.Text);
            Update.Address = tbxAdresess.Text;
            Update.DateOfRegistration = dtDateOfRegistration.Value;

            Rmanager.Update(Update);
            LoadReaderDetails();
            MessageBox.Show("Güncelleme İşlemi Başarılı...");
        }

        private void DgwBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var result = _readerService.GetById(Convert.ToInt32( DgwBook.CurrentRow.Cells[0].Value));
            tbxName.Text = result.Data.Name;
            tbxSurname.Text = result.Data.Surname;
            tbxMailAdresess.Text = result.Data.Address;
            tbxPhoneNumber.Text = result.Data.Phone;
            nmrcClass.Value = result.Data.ClassRoomId;
            tbxIdentityNo.Text = result.Data.Tc;
            cmbBransh.Text = result.Data.ClassRoombranch.ToString();
            tbxAdresess.Text = result.Data.Address;
            dtDateOfRegistration.Value = result.Data.DateOfRegistration;
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                if (cbxCategory.Text=="TÜMÜNÜ GETİR")
                {
                    LoadReaderDetails();
                }
                else
                {
                    DgwBook.DataSource = _readerService.GetClassSearch(Convert.ToInt32(cbxCategory.Text)).Data;
                }
                
            }
            catch
            {


            }
        }

        private void txtSearchReaderName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearchReaderName.Text))
            {
                SearchName(txtSearchReaderName.Text);
            }
            else
            {
                LoadReaderDetails();
            }
        }

        public void SearchName(string key)
        {
            var result = Rmanager.GetNameSearch(key);
            if (result.Success)
            {
                DgwBook.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        public void SearchSurname(string key)
        {
            var result = Rmanager.GetSurnameSearch(key);
            if (result.Success)
            {
                DgwBook.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void txtSearchReaderSurname_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearchReaderSurname.Text))
            {
                SearchSurname(txtSearchReaderSurname.Text);
            }
            else
            {
                LoadReaderDetails();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _readerService.Delete(new Reader
            {
                Id = Convert.ToInt32(DgwBook.CurrentRow.Cells[0].Value)
            });
            LoadReaderDetails();
            MessageBox.Show("Ürün Silindi...");
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadReaderDetails();
        }

       

        
    }
}
