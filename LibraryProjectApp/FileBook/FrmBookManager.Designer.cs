﻿
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
            this.tbxDolapNo = new System.Windows.Forms.TextBox();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.tbxRafNo = new System.Windows.Forms.TextBox();
            this.tbxDemirbasNo = new System.Windows.Forms.TextBox();
            this.tbxSayfaSayisi = new System.Windows.Forms.TextBox();
            this.tbsBasimYili = new System.Windows.Forms.TextBox();
            this.tbxYayinEvi = new System.Windows.Forms.TextBox();
            this.tbxYazar = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
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
            this.DgwBook.Size = new System.Drawing.Size(758, 197);
            this.DgwBook.TabIndex = 0;
            this.DgwBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwBook_CellDoubleClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.btnCategoryAdd);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.label1);
            this.gbxCategory.Location = new System.Drawing.Point(45, 18);
            this.gbxCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCategory.Size = new System.Drawing.Size(413, 69);
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
            this.gbxBook.Location = new System.Drawing.Point(466, 18);
            this.gbxBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxBook.Name = "gbxBook";
            this.gbxBook.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxBook.Size = new System.Drawing.Size(337, 69);
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
            this.gbxProductAdd.Controls.Add(this.tbxDolapNo);
            this.gbxProductAdd.Controls.Add(this.btnBookAdd);
            this.gbxProductAdd.Controls.Add(this.tbxRafNo);
            this.gbxProductAdd.Controls.Add(this.tbxDemirbasNo);
            this.gbxProductAdd.Controls.Add(this.tbxSayfaSayisi);
            this.gbxProductAdd.Controls.Add(this.tbsBasimYili);
            this.gbxProductAdd.Controls.Add(this.tbxYayinEvi);
            this.gbxProductAdd.Controls.Add(this.tbxYazar);
            this.gbxProductAdd.Controls.Add(this.txtBookName);
            this.gbxProductAdd.Controls.Add(this.label7);
            this.gbxProductAdd.Controls.Add(this.label4);
            this.gbxProductAdd.Controls.Add(this.label6);
            this.gbxProductAdd.Controls.Add(this.label13);
            this.gbxProductAdd.Controls.Add(this.label12);
            this.gbxProductAdd.Controls.Add(this.label11);
            this.gbxProductAdd.Controls.Add(this.label10);
            this.gbxProductAdd.Controls.Add(this.label9);
            this.gbxProductAdd.Controls.Add(this.label8);
            this.gbxProductAdd.Controls.Add(this.label5);
            this.gbxProductAdd.Controls.Add(this.label3);
            this.gbxProductAdd.Location = new System.Drawing.Point(45, 296);
            this.gbxProductAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxProductAdd.Size = new System.Drawing.Size(758, 224);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Kitap Ekle";
            // 
            // cbxCategoryName
            // 
            this.cbxCategoryName.FormattingEnabled = true;
            this.cbxCategoryName.Location = new System.Drawing.Point(498, 70);
            this.cbxCategoryName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCategoryName.Name = "cbxCategoryName";
            this.cbxCategoryName.Size = new System.Drawing.Size(245, 23);
            this.cbxCategoryName.TabIndex = 3;
            // 
            // tbxBarcodeNumber
            // 
            this.tbxBarcodeNumber.Location = new System.Drawing.Point(95, 28);
            this.tbxBarcodeNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxBarcodeNumber.Name = "tbxBarcodeNumber";
            this.tbxBarcodeNumber.Size = new System.Drawing.Size(245, 23);
            this.tbxBarcodeNumber.TabIndex = 2;
            // 
            // tbxBookStock
            // 
            this.tbxBookStock.Location = new System.Drawing.Point(498, 28);
            this.tbxBookStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxBookStock.Name = "tbxBookStock";
            this.tbxBookStock.Size = new System.Drawing.Size(245, 23);
            this.tbxBookStock.TabIndex = 2;
            // 
            // tbxDolapNo
            // 
            this.tbxDolapNo.Location = new System.Drawing.Point(498, 112);
            this.tbxDolapNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxDolapNo.Name = "tbxDolapNo";
            this.tbxDolapNo.Size = new System.Drawing.Size(84, 23);
            this.tbxDolapNo.TabIndex = 2;
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(613, 112);
            this.btnBookAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(130, 103);
            this.btnBookAdd.TabIndex = 1;
            this.btnBookAdd.Text = "Ekle";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // tbxRafNo
            // 
            this.tbxRafNo.Location = new System.Drawing.Point(498, 154);
            this.tbxRafNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxRafNo.Name = "tbxRafNo";
            this.tbxRafNo.Size = new System.Drawing.Size(84, 23);
            this.tbxRafNo.TabIndex = 2;
            // 
            // tbxDemirbasNo
            // 
            this.tbxDemirbasNo.Location = new System.Drawing.Point(498, 196);
            this.tbxDemirbasNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxDemirbasNo.Name = "tbxDemirbasNo";
            this.tbxDemirbasNo.Size = new System.Drawing.Size(84, 23);
            this.tbxDemirbasNo.TabIndex = 2;
            // 
            // tbxSayfaSayisi
            // 
            this.tbxSayfaSayisi.Location = new System.Drawing.Point(95, 196);
            this.tbxSayfaSayisi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxSayfaSayisi.Name = "tbxSayfaSayisi";
            this.tbxSayfaSayisi.Size = new System.Drawing.Size(79, 23);
            this.tbxSayfaSayisi.TabIndex = 2;
            // 
            // tbsBasimYili
            // 
            this.tbsBasimYili.Location = new System.Drawing.Point(275, 196);
            this.tbsBasimYili.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbsBasimYili.Name = "tbsBasimYili";
            this.tbsBasimYili.Size = new System.Drawing.Size(65, 23);
            this.tbsBasimYili.TabIndex = 2;
            // 
            // tbxYayinEvi
            // 
            this.tbxYayinEvi.Location = new System.Drawing.Point(95, 154);
            this.tbxYayinEvi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxYayinEvi.Name = "tbxYayinEvi";
            this.tbxYayinEvi.Size = new System.Drawing.Size(245, 23);
            this.tbxYayinEvi.TabIndex = 2;
            // 
            // tbxYazar
            // 
            this.tbxYazar.Location = new System.Drawing.Point(95, 112);
            this.tbxYazar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxYazar.Name = "tbxYazar";
            this.tbxYazar.Size = new System.Drawing.Size(245, 23);
            this.tbxYazar.TabIndex = 2;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(95, 70);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(245, 23);
            this.txtBookName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Barkot No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kategori: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Stok Adedi:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(414, 110);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Dolap No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 153);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Raf No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(414, 200);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Demirbaş No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 200);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sayfa Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 200);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Basım Yılı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Yayın Evi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yazarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kitap Adı:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(811, 93);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 47);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "SİL";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(357, 16);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(48, 42);
            this.btnCategoryAdd.TabIndex = 2;
            this.btnCategoryAdd.Text = "EKLE";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // FrmBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 532);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxBook);
            this.Controls.Add(this.gbxCategory);
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
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCategoryName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbxDolapNo;
        private System.Windows.Forms.TextBox tbxRafNo;
        private System.Windows.Forms.TextBox tbxDemirbasNo;
        private System.Windows.Forms.TextBox tbxSayfaSayisi;
        private System.Windows.Forms.TextBox tbsBasimYili;
        private System.Windows.Forms.TextBox tbxYayinEvi;
        private System.Windows.Forms.TextBox tbxYazar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCategoryAdd;
    }
}

