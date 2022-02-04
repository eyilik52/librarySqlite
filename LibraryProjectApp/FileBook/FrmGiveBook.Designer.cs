
namespace LibraryProjectApp.FileBook
{
    partial class FrmGiveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiveBook));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwMember = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgwBook = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.tbxBarkotNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.tbxKimlikNo = new System.Windows.Forms.TextBox();
            this.tbxNameSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).BeginInit();
            this.grpBook.SuspendLayout();
            this.grpMember.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwMember);
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Listesi";
            // 
            // dgwMember
            // 
            this.dgwMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgwMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMember.Location = new System.Drawing.Point(3, 19);
            this.dgwMember.Name = "dgwMember";
            this.dgwMember.RowTemplate.Height = 25;
            this.dgwMember.Size = new System.Drawing.Size(229, 433);
            this.dgwMember.TabIndex = 0;
            this.dgwMember.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMember_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Surname";
            this.Column3.HeaderText = "Soyadı";
            this.Column3.Name = "Column3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwBook);
            this.groupBox2.Location = new System.Drawing.Point(712, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 450);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Listesi";
            // 
            // dgwBook
            // 
            this.dgwBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column5});
            this.dgwBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwBook.Location = new System.Drawing.Point(3, 19);
            this.dgwBook.Name = "dgwBook";
            this.dgwBook.Size = new System.Drawing.Size(229, 428);
            this.dgwBook.TabIndex = 0;
            this.dgwBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBook_CellDoubleClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Id";
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BookName";
            this.Column4.HeaderText = "Kitap Adı";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "AuthorName";
            this.Column5.HeaderText = "Yazar Adı";
            this.Column5.Name = "Column5";
            // 
            // grpBook
            // 
            this.grpBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBook.Controls.Add(this.tbxBarkotNumber);
            this.grpBook.Controls.Add(this.label4);
            this.grpBook.Controls.Add(this.tbxBookName);
            this.grpBook.Controls.Add(this.label5);
            this.grpBook.Location = new System.Drawing.Point(252, 199);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(455, 156);
            this.grpBook.TabIndex = 1;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Kitap Bilgileri";
            // 
            // tbxBarkotNumber
            // 
            this.tbxBarkotNumber.Location = new System.Drawing.Point(204, 51);
            this.tbxBarkotNumber.Name = "tbxBarkotNumber";
            this.tbxBarkotNumber.Size = new System.Drawing.Size(187, 23);
            this.tbxBarkotNumber.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Barkot Numarası";
            // 
            // tbxBookName
            // 
            this.tbxBookName.Location = new System.Drawing.Point(204, 91);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(187, 23);
            this.tbxBookName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kitap Adı";
            // 
            // grpMember
            // 
            this.grpMember.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpMember.Controls.Add(this.tbxKimlikNo);
            this.grpMember.Controls.Add(this.tbxNameSurname);
            this.grpMember.Controls.Add(this.label3);
            this.grpMember.Controls.Add(this.label2);
            this.grpMember.Location = new System.Drawing.Point(252, 53);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(455, 140);
            this.grpMember.TabIndex = 1;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Üye Bilgileri";
            // 
            // tbxKimlikNo
            // 
            this.tbxKimlikNo.Location = new System.Drawing.Point(201, 46);
            this.tbxKimlikNo.Name = "tbxKimlikNo";
            this.tbxKimlikNo.Size = new System.Drawing.Size(187, 23);
            this.tbxKimlikNo.TabIndex = 2;
            // 
            // tbxNameSurname
            // 
            this.tbxNameSurname.Location = new System.Drawing.Point(201, 86);
            this.tbxNameSurname.Name = "tbxNameSurname";
            this.tbxNameSurname.Size = new System.Drawing.Size(187, 23);
            this.tbxNameSurname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adı Soyadı ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC Kimlik Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(358, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMANET KİTAP VERME EKRANI";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeliveryDate.Location = new System.Drawing.Point(143, 71);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(28, 32);
            this.lblDeliveryDate.TabIndex = 3;
            this.lblDeliveryDate.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(27, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 43);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(310, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 90);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ödünç Kitap Ver";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Emanet günü giriniz :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblDeliveryDate);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(252, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 142);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teslim tarihi belirleme";
            // 
            // FrmGiveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGiveBook";
            this.Text = "KİTAP VER";
            this.Load += new System.EventHandler(this.FrmGiveBook_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).EndInit();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwMember;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgwBook;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox tbxBarkotNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxKimlikNo;
        private System.Windows.Forms.TextBox tbxNameSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}