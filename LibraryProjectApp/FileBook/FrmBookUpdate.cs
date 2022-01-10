using Business.Abstract;
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

namespace LibraryProjectApp.FileBook
{
    public partial class FrmBookUpdate : Form
    {
        public FrmBookUpdate()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        public int UpdateId;
        

        FrmBookManager frmBookManager =(FrmBookManager)Application.OpenForms["FrmBookManager"];
        BookManager bookManager = new BookManager(new EfBookDal());
        private ICategoryService _categoryService;
        private void FrmBookUpdate_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
        private void LoadCategories()
        {
            var categoryList = _categoryService.GetAll().Data;
            cbxCategoryUpdate.DataSource = categoryList;
            cbxCategoryUpdate.DisplayMember = "Name";
            cbxCategoryUpdate.ValueMember = "Id";
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Id = UpdateId;
            book.BarcodeNumber = tbxBarkotNo.Text;
            book.Name = tbxBookUpdateName.Text;
            book.Stock =Convert.ToInt32( tbxStockUpdate.Text);
            book.CategoryId =(int) cbxCategoryUpdate.SelectedValue;
            bookManager.Update(book);
            frmBookManager.LoadBookOrCategoryDetails();
            MessageBox.Show("Güncellendi");
        }
    }
}
