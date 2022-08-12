
namespace LibraryProjectApp.FileBook
{
    partial class FrmTakeBackBook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTakeBackBook));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayGetirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTeslimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİTAP GERİ ALINACAK LİSTESİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EscrowBookId";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BarkodNumber";
            this.Column2.HeaderText = "Barkod No";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ReaderName";
            this.Column3.HeaderText = "Okuyucu Adı";
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ReaderSurname";
            this.Column4.HeaderText = "Okuyucu Soyadı";
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BookName";
            this.Column5.HeaderText = "Kitap Adı";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "AuthorName";
            this.Column6.HeaderText = "Yazarı";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TransactionDate";
            this.Column7.HeaderText = "Teslim Tarihi";
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DeliveryDate";
            this.Column8.HeaderText = "İade Tarihi";
            this.Column8.Name = "Column8";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayGetirToolStripMenuItem,
            this.yenileToolStripMenuItem,
            this.kitapTeslimAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 70);
            // 
            // detayGetirToolStripMenuItem
            // 
            this.detayGetirToolStripMenuItem.Name = "detayGetirToolStripMenuItem";
            this.detayGetirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.detayGetirToolStripMenuItem.Text = "Detay Getir";
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            // 
            // kitapTeslimAlToolStripMenuItem
            // 
            this.kitapTeslimAlToolStripMenuItem.Name = "kitapTeslimAlToolStripMenuItem";
            this.kitapTeslimAlToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.kitapTeslimAlToolStripMenuItem.Text = "Kitap Teslim Al";
            this.kitapTeslimAlToolStripMenuItem.Click += new System.EventHandler(this.kitapTeslimAlToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(546, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap ismine göre ara :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 57);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Barkod numarasına göre ara :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(7, 20);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 31);
            this.textBox2.TabIndex = 0;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(276, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 57);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Okuyucu ismine göre ara :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(251, 23);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Teslim Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTakeBackBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTakeBackBook";
            this.Text = "KİTAP GERİ ALMA EKRANI";
            this.Load += new System.EventHandler(this.FrmTakeBackBook_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detayGetirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapTeslimAlToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}