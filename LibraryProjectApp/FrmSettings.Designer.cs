
namespace LibraryProjectApp
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Kullanici = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmrPozisyon = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAgainPassword = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SmsAyar = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.YedekIslemleri = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Kullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPozisyon)).BeginInit();
            this.SmsAyar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.YedekIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Kullanici);
            this.tabControl1.Controls.Add(this.SmsAyar);
            this.tabControl1.Controls.Add(this.YedekIslemleri);
            this.tabControl1.Location = new System.Drawing.Point(0, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // Kullanici
            // 
            this.Kullanici.Controls.Add(this.dataGridView1);
            this.Kullanici.Controls.Add(this.groupBox1);
            this.Kullanici.Location = new System.Drawing.Point(4, 24);
            this.Kullanici.Name = "Kullanici";
            this.Kullanici.Padding = new System.Windows.Forms.Padding(3);
            this.Kullanici.Size = new System.Drawing.Size(789, 421);
            this.Kullanici.TabIndex = 0;
            this.Kullanici.Text = "Kullanıcı İşlemleri";
            this.Kullanici.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(392, 403);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmrPozisyon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAgainPassword);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 356);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kullanıcı Ekle";
            // 
            // nmrPozisyon
            // 
            this.nmrPozisyon.Location = new System.Drawing.Point(139, 250);
            this.nmrPozisyon.Name = "nmrPozisyon";
            this.nmrPozisyon.Size = new System.Drawing.Size(108, 23);
            this.nmrPozisyon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(223, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Kaydet";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(124, 279);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(29, 279);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-Posta";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(139, 97);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(138, 23);
            this.txtPhone.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(139, 127);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(138, 23);
            this.txtMail.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Şifre";
            // 
            // txtAgainPassword
            // 
            this.txtAgainPassword.Location = new System.Drawing.Point(139, 220);
            this.txtAgainPassword.Name = "txtAgainPassword";
            this.txtAgainPassword.PasswordChar = '*';
            this.txtAgainPassword.Size = new System.Drawing.Size(138, 23);
            this.txtAgainPassword.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "pozisyon Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Şifre Tekrar";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(139, 189);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(138, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(139, 65);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(138, 23);
            this.txtSurname.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(139, 158);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(138, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // SmsAyar
            // 
            this.SmsAyar.Controls.Add(this.dataGridView2);
            this.SmsAyar.Controls.Add(this.groupBox2);
            this.SmsAyar.Location = new System.Drawing.Point(4, 24);
            this.SmsAyar.Name = "SmsAyar";
            this.SmsAyar.Padding = new System.Windows.Forms.Padding(3);
            this.SmsAyar.Size = new System.Drawing.Size(789, 421);
            this.SmsAyar.TabIndex = 1;
            this.SmsAyar.Text = "Sms Gönderim Ayarları";
            this.SmsAyar.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(366, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(416, 259);
            this.dataGridView2.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 266);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kullanıcı Ekle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "ile görüşünüz.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "* Sistem mutlucell mesaj sistemine göre hazırlanmıştır. ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(323, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "* Farklı bir mesaj sistemi kullanmak istiyorsanız, yazılımcınız ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kullanıcı Adı :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sms Başlığı :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Şifre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(138, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Şifre Tekrar";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(138, 23);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 34);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 23);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(139, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 23);
            this.textBox5.TabIndex = 1;
            // 
            // YedekIslemleri
            // 
            this.YedekIslemleri.Controls.Add(this.button5);
            this.YedekIslemleri.Controls.Add(this.button4);
            this.YedekIslemleri.Location = new System.Drawing.Point(4, 24);
            this.YedekIslemleri.Name = "YedekIslemleri";
            this.YedekIslemleri.Padding = new System.Windows.Forms.Padding(3);
            this.YedekIslemleri.Size = new System.Drawing.Size(789, 421);
            this.YedekIslemleri.TabIndex = 2;
            this.YedekIslemleri.Text = "Yedekleme İşlemleri";
            this.YedekIslemleri.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 43);
            this.button4.TabIndex = 0;
            this.button4.Text = "Veritabanı Oluştur";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(32, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 43);
            this.button5.TabIndex = 0;
            this.button5.Text = "Veritabanını sil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 461);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettings";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.Kullanici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPozisyon)).EndInit();
            this.SmsAyar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.YedekIslemleri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Kullanici;
        private System.Windows.Forms.TabPage SmsAyar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage YedekIslemleri;
        public System.Windows.Forms.TextBox txtMail;
        public System.Windows.Forms.TextBox txtAgainPassword;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.MaskedTextBox txtPhone;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmrPozisyon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}