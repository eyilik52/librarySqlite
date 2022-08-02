
namespace LibraryProjectApp
{
    partial class FrmKitapDonut
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxEtkiOlay = new System.Windows.Forms.TextBox();
            this.tbxAnaFikir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(300, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "HOŞ GELDİNİZ";
            // 
            // lblReaderName
            // 
            this.lblReaderName.AutoSize = true;
            this.lblReaderName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReaderName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReaderName.Location = new System.Drawing.Point(78, 19);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(226, 28);
            this.lblReaderName.TabIndex = 2;
            this.lblReaderName.Text = "MEHMET EREN EYİLİK ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "SAYIN ";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAuthorName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAuthorName.Location = new System.Drawing.Point(136, 56);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(187, 28);
            this.lblAuthorName.TabIndex = 2;
            this.lblAuthorName.Text = "Nazan BEKİROĞLU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yazar :";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBookName.Location = new System.Drawing.Point(136, 28);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(109, 28);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Nar ağacı ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kitap Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblAuthorName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblBookName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(7, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dönüt verilecek Kitap Bilgileri :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxEtkiOlay);
            this.groupBox2.Controls.Add(this.tbxAnaFikir);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(13, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 323);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dönüt Giriş Ekranı :";
            // 
            // tbxEtkiOlay
            // 
            this.tbxEtkiOlay.Location = new System.Drawing.Point(6, 173);
            this.tbxEtkiOlay.Multiline = true;
            this.tbxEtkiOlay.Name = "tbxEtkiOlay";
            this.tbxEtkiOlay.Size = new System.Drawing.Size(772, 144);
            this.tbxEtkiOlay.TabIndex = 2;
            // 
            // tbxAnaFikir
            // 
            this.tbxAnaFikir.Location = new System.Drawing.Point(130, 35);
            this.tbxAnaFikir.Multiline = true;
            this.tbxAnaFikir.Name = "tbxAnaFikir";
            this.tbxAnaFikir.Size = new System.Drawing.Size(648, 104);
            this.tbxAnaFikir.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ana Fikri :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sizi En Çok Etkileyen Olay :";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(843, 330);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(136, 161);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "İNCELENMESİ İÇİN GÖNDER";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(843, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 128);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmKitapDonut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(991, 509);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReaderName);
            this.Controls.Add(this.label1);
            this.Name = "FrmKitapDonut";
            this.Text = "KİTAP KURDU DÖNÜT EKRANI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblReaderName;
        public System.Windows.Forms.Label lblAuthorName;
        public System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox tbxEtkiOlay;
        public System.Windows.Forms.TextBox tbxAnaFikir;
    }
}