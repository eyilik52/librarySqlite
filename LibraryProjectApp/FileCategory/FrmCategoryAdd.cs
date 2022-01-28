using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using LibraryProjectApp.FileBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProjectApp.FileCategory
{
    public partial class FrmCategoryAdd : Form
    {
        public FrmCategoryAdd()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        FrmBookOperations frmBookManager = (FrmBookOperations)Application.OpenForms["FrmBookOperations"];
        private ICategoryService _categoryService;
        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            _categoryService.Add(new Category
            {
                Name = tbxCategoryAdd.Text
            });
            MessageBox.Show("Kitap kaydetme işlemi başarılı");
            tbxCategoryAdd.Text = "";
            frmBookManager.LoadCategories();
           
            
        }
    }
}
