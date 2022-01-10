
namespace LibraryProjectApp.FileBook
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
            this.DgwBook = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxBook = new System.Windows.Forms.GroupBox();
            this.txtSearchBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.cbxCategoryName = new System.Windows.Forms.ComboBox();
            this.tbxBarcodeNumber = new System.Windows.Forms.TextBox();
            this.tbxBookStock = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgwBook)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxBook.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgwBook
            // 
            this.DgwBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwBook.Location = new System.Drawing.Point(45, 93);
            this.DgwBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgwBook.Name = "DgwBook";
            this.DgwBook.Size = new System.Drawing.Size(835, 197);
            this.DgwBook.TabIndex = 0;
            this.DgwBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwBook_CellDoubleClick);
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
            this.gbxBook.Controls.Add(this.txtSearchBookName);
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
            // txtSearchBookName
            // 
            this.txtSearchBookName.Location = new System.Drawing.Point(84, 32);
            this.txtSearchBookName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchBookName.Name = "txtSearchBookName";
            this.txtSearchBookName.Size = new System.Drawing.Size(242, 23);
            this.txtSearchBookName.TabIndex = 1;
            this.txtSearchBookName.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
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
            this.gbxProductAdd.Controls.Add(this.tbxBarcodeNumber);
            this.gbxProductAdd.Controls.Add(this.tbxBookStock);
            this.gbxProductAdd.Controls.Add(this.txtBookName);
            this.gbxProductAdd.Controls.Add(this.label7);
            this.gbxProductAdd.Controls.Add(this.label4);
            this.gbxProductAdd.Controls.Add(this.label6);
            this.gbxProductAdd.Controls.Add(this.label3);
            this.gbxProductAdd.Location = new System.Drawing.Point(45, 296);
            this.gbxProductAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxProductAdd.Size = new System.Drawing.Size(835, 224);
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
            // tbxBarcodeNumber
            // 
            this.tbxBarcodeNumber.Location = new System.Drawing.Point(492, 77);
            this.tbxBarcodeNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxBarcodeNumber.Name = "tbxBarcodeNumber";
            this.tbxBarcodeNumber.Size = new System.Drawing.Size(245, 23);
            this.tbxBarcodeNumber.TabIndex = 2;
            // 
            // tbxBookStock
            // 
            this.tbxBookStock.Location = new System.Drawing.Point(492, 32);
            this.tbxBookStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxBookStock.Name = "tbxBookStock";
            this.tbxBookStock.Size = new System.Drawing.Size(245, 23);
            this.tbxBookStock.TabIndex = 2;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(94, 36);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(245, 23);
            this.txtBookName.TabIndex = 2;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(897, 157);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(130, 30);
            this.btnProductAdd.TabIndex = 1;
            this.btnProductAdd.Text = "Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Barkot No :";
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
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kitap Adı:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(906, 93);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 47);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "SİL";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // FrmBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 532);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxBook);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.DgwBook);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmBookManager";
            this.Text = "KİTAP YÖNETİM ALANI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwBook)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxBook.ResumeLayout(false);
            this.gbxBook.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwBook;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.GroupBox gbxBook;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.TextBox tbxBarcodeNumber;
        private System.Windows.Forms.TextBox tbxBookStock;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCategoryName;
        private System.Windows.Forms.Button btnRemove;
    }
}

