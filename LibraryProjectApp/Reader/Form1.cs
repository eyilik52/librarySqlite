
using Business.Abstract;
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

namespace LibraryProjectApp.Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadProduct();//Ürünleri Listele
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categoryList = _categoryService.GetAll().Data;
            cbxCategory.DataSource = categoryList;
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "Id";

            var categoryList1 = _categoryService.GetAll().Data;
            cbxCategoryName.DataSource = categoryList;
            cbxCategoryName.DisplayMember = "Name";
            cbxCategoryName.ValueMember = "Id";

            var categoryList2 = _categoryService.GetAll().Data;
            cbxCategoryUpdate.DataSource = categoryList;
            cbxCategoryUpdate.DisplayMember = "Name";
            cbxCategoryUpdate.ValueMember = "Id";
        }

        //private void LoadProduct()
        //{
        //    DgwProduct.DataSource = _productService.GetAll();
        //}

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try //Daha değerler dolmadan yüklemeye çalışacağındanilk seferinde hata almamak için...
            {
                //DgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {


            }

        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtProduct.Text))
            {
                //DgwProduct.DataSource = _productService.GetProductsByProductName(txtProduct.Text);
            }
            else
            {
                //LoadProduct();
            }

        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _productService.Add(new Product
            //    {
            //        CategoryId = Convert.ToInt32(cbxCategoryName.SelectedValue),
            //        ProductName = txtProductName.Text,
            //        QuantityPerUnit = tbxQuantityPerUnit.Text,
            //        UnitPrice = Convert.ToDecimal(txtProductPrice.Text),
            //        UnitsInStock = Convert.ToInt16(tbxProductStock.Text)
            //    }
            //    );
            //    LoadProduct();
            //    MessageBox.Show("Ürün Kaydedildi!...");
            //}
            //catch (Exception exception)
            //{

            //    MessageBox.Show(exception.Message);
            //}

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //_productService.Update(new Product
            //{
            //    ProductId = Convert.ToInt32(DgwProduct.CurrentRow.Cells[0].Value),
            //    ProductName = tbxProductUpdateName.Text,
            //    CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
            //    UnitsInStock = Convert.ToInt16(tbxStockUpdate.Text),
            //    QuantityPerUnit = tbxQualityUpdate.Text,
            //    UnitPrice = Convert.ToDecimal(tbxProductPriceUpdate.Text)
            //});
            //LoadProduct();
            //MessageBox.Show("Ürün Güncellendi!...");
        }

        private void DgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = DgwProduct.CurrentRow;
            tbxProductUpdateName.Text = row.Cells[1].Value.ToString();
            cbxCategoryUpdate.SelectedValue = row.Cells[2].Value;
            tbxStockUpdate.Text = row.Cells[5].Value.ToString();
            tbxQualityUpdate.Text = row.Cells[4].Value.ToString();
            tbxProductPriceUpdate.Text = row.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //_productService.Delete(new Product
            //{
            //     ProductId=Convert.ToInt32(DgwProduct.CurrentRow.Cells[0].Value)
            //});
            //LoadProduct();
            //MessageBox.Show("Ürün Silindi...");
        }
    }
}