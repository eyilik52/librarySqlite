
namespace LibraryProjectApp.Book
{
    partial class FrmBookManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxBook = new System.Windows.Forms.GroupBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.cbxCategoryName = new System.Windows.Forms.ComboBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxProductStock = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxBook.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgwProduct
            // 
            this.DgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwProduct.Location = new System.Drawing.Point(45, 103);
            this.DgwProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgwProduct.Name = "DgwProduct";
            this.DgwProduct.Size = new System.Drawing.Size(835, 197);
            this.DgwProduct.TabIndex = 0;
            this.DgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.label1);
            this.gbxCategory.Location = new System.Drawing.Point(45, 18);
            this.gbxCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCategory.Size = new System.Drawing.Size(403, 69);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(108, 27);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(242, 23);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori :";
            // 
            // gbxBook
            // 
            this.gbxBook.Controls.Add(this.txtProduct);
            this.gbxBook.Controls.Add(this.label2);
            this.gbxBook.Location = new System.Drawing.Point(477, 18);
            this.gbxBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxBook.Name = "gbxBook";
            this.gbxBook.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxBook.Size = new System.Drawing.Size(403, 69);
            this.gbxBook.TabIndex = 2;
            this.gbxBook.TabStop = false;
            this.gbxBook.Text = "Kitap Adına Göre Ara";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(84, 32);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(242, 23);
            this.txtProduct.TabIndex = 1;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Adı";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.cbxCategoryName);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxProductStock);
            this.gbxProductAdd.Controls.Add(this.txtProductPrice);
            this.gbxProductAdd.Controls.Add(this.txtProductName);
            this.gbxProductAdd.Controls.Add(this.btnProductAdd);
            this.gbxProductAdd.Controls.Add(this.label5);
            this.gbxProductAdd.Controls.Add(this.label7);
            this.gbxProductAdd.Controls.Add(this.label4);
            this.gbxProductAdd.Controls.Add(this.label6);
            this.gbxProductAdd.Controls.Add(this.label3);
            this.gbxProductAdd.Location = new System.Drawing.Point(45, 342);
            this.gbxProductAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxProductAdd.Size = new System.Drawing.Size(835, 158);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // cbxCategoryName
            // 
            this.cbxCategoryName.FormattingEnabled = true;
            this.cbxCategoryName.Location = new System.Drawing.Point(94, 77);
            this.cbxCategoryName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCategoryName.Name = "cbxCategoryName";
            this.cbxCategoryName.Size = new System.Drawing.Size(245, 23);
            this.cbxCategoryName.TabIndex = 3;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(492, 77);
            this.tbxQuantityPerUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(245, 23);
            this.tbxQuantityPerUnit.TabIndex = 2;
            // 
            // tbxProductStock
            // 
            this.tbxProductStock.Location = new System.Drawing.Point(492, 32);
            this.tbxProductStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxProductStock.Name = "tbxProductStock";
            this.tbxProductStock.Size = new System.Drawing.Size(245, 23);
            this.tbxProductStock.TabIndex = 2;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(94, 114);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(245, 23);
            this.txtProductPrice.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(94, 36);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(245, 23);
            this.txtProductName.TabIndex = 2;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(564, 114);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(130, 30);
            this.btnProductAdd.TabIndex = 1;
            this.btnProductAdd.Text = "Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fiyat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Birim Adedi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kategori: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Stok Adedi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(753, 308);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 36);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "SİL";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(609, 308);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 36);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // FrmBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 532);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxBook);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.DgwProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmBookManager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxBook.ResumeLayout(false);
            this.gbxBook.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.GroupBox gbxBook;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxProductStock;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCategoryName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
    }
}

