
namespace LibraryProjectApp.FileBook
{
    partial class FrmBookUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.tbxStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxBarkotNo = new System.Windows.Forms.TextBox();
            this.tbxBookUpdateName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.cbxCategoryUpdate);
            this.groupBox1.Controls.Add(this.tbxStockUpdate);
            this.groupBox1.Controls.Add(this.tbxBarkotNo);
            this.groupBox1.Controls.Add(this.tbxBookUpdateName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(41, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(390, 289);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 225);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 33);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(94, 77);
            this.cbxCategoryUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(245, 23);
            this.cbxCategoryUpdate.TabIndex = 3;
            // 
            // tbxStockUpdate
            // 
            this.tbxStockUpdate.Location = new System.Drawing.Point(94, 158);
            this.tbxStockUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxStockUpdate.Name = "tbxStockUpdate";
            this.tbxStockUpdate.Size = new System.Drawing.Size(245, 23);
            this.tbxStockUpdate.TabIndex = 2;
            // 
            // tbxBarkotNo
            // 
            this.tbxBarkotNo.Location = new System.Drawing.Point(94, 114);
            this.tbxBarkotNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxBarkotNo.Name = "tbxBarkotNo";
            this.tbxBarkotNo.Size = new System.Drawing.Size(245, 23);
            this.tbxBarkotNo.TabIndex = 2;
            // 
            // tbxBookUpdateName
            // 
            this.tbxBookUpdateName.Location = new System.Drawing.Point(94, 36);
            this.tbxBookUpdateName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxBookUpdateName.Name = "tbxBookUpdateName";
            this.tbxBookUpdateName.Size = new System.Drawing.Size(245, 23);
            this.tbxBookUpdateName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Barkot No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kategori: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Stok Adedi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Kitap Adı:";
            // 
            // FrmBookUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 346);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBookUpdate";
            this.Text = "FrmBookUpdate";
            this.Load += new System.EventHandler(this.FrmBookUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.ComboBox cbxCategoryUpdate;
        public System.Windows.Forms.TextBox tbxStockUpdate;
        public System.Windows.Forms.TextBox tbxBarkotNo;
        public System.Windows.Forms.TextBox tbxBookUpdateName;
    }
}