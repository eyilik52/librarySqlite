
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
using Entities.Concrete;
using LibraryProjectApp.FileCategory;

namespace LibraryProjectApp.FileBook
{
    public partial class FrmBookOperations : Form
    {
        public FrmBookOperations()
        {
            InitializeComponent();
            
            _categoryService = new CategoryManager(new EfCategoryDal());
            _bookService = new BookManager(new EfBookDal());
        }

        BookManager bookManager = new BookManager(new EfBookDal());


        private ICategoryService _categoryService;
        private IBookService _bookService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadBookOrCategoryDetails();
            GridViewKolonİsimleri();
           
        }

        public void LoadCategories()
        {
            var categoryList = _categoryService.GetAll().Data;
            cbxCategory.DataSource = categoryList;
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "Id";

            var categoryList1 = _categoryService.GetAll().Data;
            cbxCategoryName.DataSource = categoryList1;
            cbxCategoryName.DisplayMember = "Name";
            cbxCategoryName.ValueMember = "Id";
        }

        public void LoadBookOrCategoryDetails()
        {
            DgwBook.DataSource = _bookService.GetBookOrCategoryDetails().Data;
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try //Daha değerler dolmadan yüklemeye çalışacağındanilk seferinde hata almamak için...
            {
                DgwBook.DataSource = _bookService.GetCategorySearch(cbxCategory.Text).Data;
            }
            catch
            {


            }

        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtSearchBookName.Text))
            {
                SearchBook(txtSearchBookName.Text);
            }
            else
            {
                LoadBookOrCategoryDetails();
            }

        }
        
        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.Add(new Book
                {
                    CategoryId = Convert.ToInt32(cbxCategoryName.SelectedValue),
                    BookName = txtBookName.Text,
                    BarcodeNumber = tbxBarcodeNumber.Text,
                    AuthorName = tbxYazar.Text,
                    AssetNumber = Convert.ToInt32(tbxDemirbasNo.Text),
                    CabinetNumber = Convert.ToChar(tbxDolapNo.Text),
                    YearOfPublication = Convert.ToInt32(tbsBasimYili.Text),
                    ShelfNo = Convert.ToInt32(tbxRafNo.Text),
                    NumberOfPages = Convert.ToInt32(tbxSayfaSayisi.Text),
                    Publisher = tbxYayinEvi.Text,
                    Stock = Convert.ToInt32(tbxBookStock.Text)
                }
                );
                LoadBookOrCategoryDetails();
                MessageBox.Show("Kitap kaydetme işlemi başarılı");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

            
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

        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _bookService.Delete(new Book
            {
                Id = Convert.ToInt32(DgwBook.CurrentRow.Cells[0].Value)
            });
            LoadBookOrCategoryDetails();
            MessageBox.Show("Ürün Silindi...");
        }
        public void SearchBook(string key)
        {
            var result = bookManager.GetBookSearch(key);
            if (result.Success)
            {
                DgwBook.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void DgwBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmBookUpdate Update = new FrmBookUpdate();
            var row = DgwBook.CurrentRow;
            Update.UpdateId = Convert.ToInt32(row.Cells[0].Value);
            Update.tbxBarkotNo.Text = row.Cells[1].Value.ToString();
            Update.tbxBookUpdateName.Text = row.Cells[2].Value.ToString();
            Update.cbxCategoryUpdate.SelectedValue = row.Cells[3].Value;
            Update.tbxStockUpdate.Text = row.Cells[4].Value.ToString();
            Update.ShowDialog();
        }

        private void GridViewKolonİsimleri()
        {
            DgwBook.Columns[0].Visible = false;
            DgwBook.Columns[1].HeaderText = "Barkod No";
            DgwBook.Columns[2].HeaderText = "Kitap Adı";
            DgwBook.Columns[3].HeaderText = "Kategori Adı";
            DgwBook.Columns[4].HeaderText = "Adet";


        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            FrmCategoryAdd categoryAdd = new FrmCategoryAdd();
            categoryAdd.ShowDialog();
        }
    }
}