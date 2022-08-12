
namespace LibraryProjectApp.Reports
{
    partial class FrmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReports));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFirstDate = new System.Windows.Forms.DateTimePicker();
            this.dtSecondDate = new System.Windows.Forms.DateTimePicker();
            this.btnBring = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kütüphaneKitapListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enÇokOkunanKiitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okuyucuRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enÇokOkuyanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enAzOkuyanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKurduSıralamasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(57, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(774, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "EscrowBookId";
            this.Column7.HeaderText = "Id";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "BarkodNumber";
            this.Column8.HeaderText = "Barkot";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BookName";
            this.Column1.HeaderText = "Kitap Adı";
            this.Column1.Name = "Column1";
            this.Column1.Width = 135;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "AuthorName";
            this.Column4.HeaderText = "Yazar Adı";
            this.Column4.Name = "Column4";
            this.Column4.Width = 135;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ReaderName";
            this.Column2.HeaderText = "Okuyucu Adı";
            this.Column2.Name = "Column2";
            this.Column2.Width = 135;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ReaderSurname";
            this.Column3.HeaderText = "Soyadı";
            this.Column3.Name = "Column3";
            this.Column3.Width = 135;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TransactionDate";
            this.Column5.HeaderText = "Aldığı Tarih";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DeliveryDate";
            this.Column6.HeaderText = "Teslim Tarihi";
            this.Column6.Name = "Column6";
            // 
            // dtFirstDate
            // 
            this.dtFirstDate.Location = new System.Drawing.Point(90, 37);
            this.dtFirstDate.Name = "dtFirstDate";
            this.dtFirstDate.Size = new System.Drawing.Size(200, 23);
            this.dtFirstDate.TabIndex = 1;
            // 
            // dtSecondDate
            // 
            this.dtSecondDate.Location = new System.Drawing.Point(352, 37);
            this.dtSecondDate.Name = "dtSecondDate";
            this.dtSecondDate.Size = new System.Drawing.Size(200, 23);
            this.dtSecondDate.TabIndex = 1;
            // 
            // btnBring
            // 
            this.btnBring.BackColor = System.Drawing.Color.Gold;
            this.btnBring.ForeColor = System.Drawing.Color.Black;
            this.btnBring.Location = new System.Drawing.Point(614, 33);
            this.btnBring.Name = "btnBring";
            this.btnBring.Size = new System.Drawing.Size(128, 30);
            this.btnBring.TabIndex = 2;
            this.btnBring.Text = "GETİR";
            this.btnBring.UseVisualStyleBackColor = false;
            this.btnBring.Click += new System.EventHandler(this.btnBring_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFirstDate);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnBring);
            this.groupBox1.Controls.Add(this.dtSecondDate);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 432);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih aralığına göre kütüphane hareketliliği :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapRaporlarıToolStripMenuItem,
            this.okuyucuRaporlarıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapRaporlarıToolStripMenuItem
            // 
            this.kitapRaporlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kütüphaneKitapListesiToolStripMenuItem,
            this.enÇokOkunanKiitaplarToolStripMenuItem});
            this.kitapRaporlarıToolStripMenuItem.Name = "kitapRaporlarıToolStripMenuItem";
            this.kitapRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.kitapRaporlarıToolStripMenuItem.Text = "Kitap Raporları";
            // 
            // kütüphaneKitapListesiToolStripMenuItem
            // 
            this.kütüphaneKitapListesiToolStripMenuItem.Name = "kütüphaneKitapListesiToolStripMenuItem";
            this.kütüphaneKitapListesiToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.kütüphaneKitapListesiToolStripMenuItem.Text = "Kütüphane Kitap Listesi";
            // 
            // enÇokOkunanKiitaplarToolStripMenuItem
            // 
            this.enÇokOkunanKiitaplarToolStripMenuItem.Name = "enÇokOkunanKiitaplarToolStripMenuItem";
            this.enÇokOkunanKiitaplarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.enÇokOkunanKiitaplarToolStripMenuItem.Text = "En Çok Okunan Kitaplar";
            // 
            // okuyucuRaporlarıToolStripMenuItem
            // 
            this.okuyucuRaporlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enÇokOkuyanlarToolStripMenuItem,
            this.enAzOkuyanlarToolStripMenuItem,
            this.kitapKurduSıralamasıToolStripMenuItem});
            this.okuyucuRaporlarıToolStripMenuItem.Name = "okuyucuRaporlarıToolStripMenuItem";
            this.okuyucuRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.okuyucuRaporlarıToolStripMenuItem.Text = "Okuyucu Raporları";
            // 
            // enÇokOkuyanlarToolStripMenuItem
            // 
            this.enÇokOkuyanlarToolStripMenuItem.Name = "enÇokOkuyanlarToolStripMenuItem";
            this.enÇokOkuyanlarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.enÇokOkuyanlarToolStripMenuItem.Text = "En Çok Okuyanlar";
            // 
            // enAzOkuyanlarToolStripMenuItem
            // 
            this.enAzOkuyanlarToolStripMenuItem.Name = "enAzOkuyanlarToolStripMenuItem";
            this.enAzOkuyanlarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.enAzOkuyanlarToolStripMenuItem.Text = "En Az Okuyanlar";
            // 
            // kitapKurduSıralamasıToolStripMenuItem
            // 
            this.kitapKurduSıralamasıToolStripMenuItem.Name = "kitapKurduSıralamasıToolStripMenuItem";
            this.kitapKurduSıralamasıToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.kitapKurduSıralamasıToolStripMenuItem.Text = "Kitap Kurdu Sıralaması";
            this.kitapKurduSıralamasıToolStripMenuItem.Click += new System.EventHandler(this.kitapKurduSıralamasıToolStripMenuItem_Click);
            // 
            // FrmReports
            // 
            this.AcceptButton = this.btnBring;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(874, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmReports";
            this.Text = "DETAYLI RAPOR EKRANI";
            this.Load += new System.EventHandler(this.FrmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtFirstDate;
        private System.Windows.Forms.DateTimePicker dtSecondDate;
        private System.Windows.Forms.Button btnBring;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kütüphaneKitapListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enÇokOkunanKiitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okuyucuRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enÇokOkuyanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enAzOkuyanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapKurduSıralamasıToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}