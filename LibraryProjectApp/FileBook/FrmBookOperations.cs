
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
            //GridViewKolonİsimleri();
           
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
                MessageBox.Show("Bir hata oluştu. Hata sebebi tespit edilemedi.");
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
                    BookName = tbxBookName.Text,
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
            //_bookService.Delete(new Book
            //{
            //    Id = Convert.ToInt32(DgwBook.CurrentRow.Cells[0].Value)
            //});
            //LoadBookOrCategoryDetails();
            //MessageBox.Show("Ürün Silindi...");



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
            var result = _bookService.GetById(Convert.ToInt32(DgwBook.CurrentRow.Cells[0].Value));
            tbxBookName.Text = result.Data.BookName;
            tbxBarcodeNumber.Text = result.Data.BarcodeNumber;
            tbxBookStock.Text = result.Data.Stock.ToString();
            tbxDemirbasNo.Text = result.Data.AssetNumber.ToString();
            tbxDolapNo.Text = result.Data.CabinetNumber.ToString();
            tbxYayinEvi.Text = result.Data.Publisher;
            tbxYazar.Text = result.Data.AuthorName;
            tbxSayfaSayisi.Text = result.Data.NumberOfPages.ToString();
            tbsBasimYili.Text = result.Data.YearOfPublication.ToString();
            tbxRafNo.Text = result.Data.ShelfNo.ToString();




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

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Book book = new Book();
            var row = DgwBook.CurrentRow;
            book.Id = Convert.ToInt32(row.Cells[0].Value);
            book.BarcodeNumber = tbxBarcodeNumber.Text;
            book.BookName = tbxBookName.Text;
            book.Stock = Convert.ToInt32(tbxBookStock.Text);
            book.CategoryId = Convert.ToInt32(cbxCategoryName.SelectedValue);
            book.AuthorName = tbxYazar.Text;
            book.AssetNumber = Convert.ToInt32(tbxDemirbasNo.Text);
            book.CabinetNumber = Convert.ToChar(tbxDolapNo.Text);
            book.YearOfPublication = Convert.ToInt32(tbsBasimYili.Text);
            book.ShelfNo = Convert.ToInt32(tbxRafNo.Text);
            book.NumberOfPages = Convert.ToInt32(tbxSayfaSayisi.Text);
            book.Publisher = tbxYayinEvi.Text;
            bookManager.Update(book);
            LoadBookOrCategoryDetails();
            MessageBox.Show("Güncellendi");
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = _bookService.GetById(Convert.ToInt32(DgwBook.CurrentRow.Cells[0].Value));
            result.Data.IsActive = false;
            _bookService.Update(result.Data);

            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            LoadBookOrCategoryDetails();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = _bookService.GetById(Convert.ToInt32(DgwBook.CurrentRow.Cells[0].Value));
            tbxBookName.Text = result.Data.BookName;
            tbxBarcodeNumber.Text = result.Data.BarcodeNumber;
            tbxBookStock.Text = result.Data.Stock.ToString();
            tbxDemirbasNo.Text = result.Data.AssetNumber.ToString();
            tbxDolapNo.Text = result.Data.CabinetNumber.ToString();
            tbxYayinEvi.Text = result.Data.Publisher;
            tbxYazar.Text = result.Data.AuthorName;
            tbxSayfaSayisi.Text = result.Data.NumberOfPages.ToString();
            tbsBasimYili.Text = result.Data.YearOfPublication.ToString();
            tbxRafNo.Text = result.Data.ShelfNo.ToString();
        }

        
    }
}