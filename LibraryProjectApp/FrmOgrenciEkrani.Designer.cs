﻿
namespace LibraryProjectApp
{
    partial class FrmOgrenciEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciEkrani));
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransActionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.özetGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİçinNotGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.şifreİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okuduğumKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamOkunanSayfaSayısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKurduSıralamamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameSurname.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNameSurname.Location = new System.Drawing.Point(332, 45);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(226, 28);
            this.lblNameSurname.TabIndex = 0;
            this.lblNameSurname.Text = "MEHMET EREN EYİLİK ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Teslim Alınan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(156, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "12";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap İstatistikleriniz : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(411, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(211, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Onaylanan Özet  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(479, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Reddedilen Özet  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(668, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(22, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 295);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dönüt Bekleyen Kitaplarınız :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.sira,
            this.BookName,
            this.Column5,
            this.TransActionDate,
            this.DeliveryDate,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(723, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ReaderId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // sira
            // 
            this.sira.HeaderText = "Sıra";
            this.sira.Name = "sira";
            this.sira.Width = 50;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Kitap Adı";
            this.BookName.Name = "BookName";
            this.BookName.Width = 180;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "AuthorName";
            this.Column5.HeaderText = "Yazar";
            this.Column5.Name = "Column5";
            this.Column5.Width = 180;
            // 
            // TransActionDate
            // 
            this.TransActionDate.DataPropertyName = "TransActionDate";
            this.TransActionDate.HeaderText = "Teslim Tarihi";
            this.TransActionDate.Name = "TransActionDate";
            this.TransActionDate.Visible = false;
            this.TransActionDate.Width = 150;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.DataPropertyName = "DeliveryDate";
            this.DeliveryDate.HeaderText = "Özet Tarihi";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SayfaSayisi";
            this.Column1.HeaderText = "Sayfa Sayısı";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BookId";
            this.Column3.HeaderText = "BookId";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "EscBookId";
            this.Column4.HeaderText = "EscBookId";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "EkranId";
            this.Column6.HeaderText = "EkranId";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.özetGönderToolStripMenuItem,
            this.yenileToolStripMenuItem,
            this.kitapİçinNotGönderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 70);
            // 
            // özetGönderToolStripMenuItem
            // 
            this.özetGönderToolStripMenuItem.Name = "özetGönderToolStripMenuItem";
            this.özetGönderToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.özetGönderToolStripMenuItem.Text = "Özet Gönder";
            this.özetGönderToolStripMenuItem.Click += new System.EventHandler(this.özetGönderToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // kitapİçinNotGönderToolStripMenuItem
            // 
            this.kitapİçinNotGönderToolStripMenuItem.Name = "kitapİçinNotGönderToolStripMenuItem";
            this.kitapİçinNotGönderToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kitapİçinNotGönderToolStripMenuItem.Text = "Kitap için not gönder";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreİşlemleriToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // şifreİşlemleriToolStripMenuItem
            // 
            this.şifreİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreDeğiştirToolStripMenuItem});
            this.şifreİşlemleriToolStripMenuItem.Name = "şifreİşlemleriToolStripMenuItem";
            this.şifreİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.şifreİşlemleriToolStripMenuItem.Text = "Şifre İşlemleri";
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okuduğumKitaplarToolStripMenuItem,
            this.toplamOkunanSayfaSayısıToolStripMenuItem,
            this.kitapKurduSıralamamToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // okuduğumKitaplarToolStripMenuItem
            // 
            this.okuduğumKitaplarToolStripMenuItem.Name = "okuduğumKitaplarToolStripMenuItem";
            this.okuduğumKitaplarToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.okuduğumKitaplarToolStripMenuItem.Text = "Okuduğum kitaplar";
            // 
            // toplamOkunanSayfaSayısıToolStripMenuItem
            // 
            this.toplamOkunanSayfaSayısıToolStripMenuItem.Name = "toplamOkunanSayfaSayısıToolStripMenuItem";
            this.toplamOkunanSayfaSayısıToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.toplamOkunanSayfaSayısıToolStripMenuItem.Text = "Toplam okunan sayfa sayısı";
            // 
            // kitapKurduSıralamamToolStripMenuItem
            // 
            this.kitapKurduSıralamamToolStripMenuItem.Name = "kitapKurduSıralamamToolStripMenuItem";
            this.kitapKurduSıralamamToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.kitapKurduSıralamamToolStripMenuItem.Text = "Kitap Kurdu Sıralamam";
            this.kitapKurduSıralamamToolStripMenuItem.Click += new System.EventHandler(this.kitapKurduSıralamamToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(222, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "HOŞ GELDİNİZ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(246, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "SAYIN :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(68, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // FrmOgrenciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNameSurname);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmOgrenciEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KÜTÜPHANEM GÜVENDE...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOgrenciEkrani_FormClosed);
            this.Load += new System.EventHandler(this.FrmOgrenciEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem özetGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİçinNotGönderToolStripMenuItem;
        public System.Windows.Forms.Label lblNameSurname;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okuduğumKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplamOkunanSayfaSayısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapKurduSıralamamToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransActionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}