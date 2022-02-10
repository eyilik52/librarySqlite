
namespace LibraryProjectApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxBookBuyerList = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.bntClose = new System.Windows.Forms.Button();
            this.ımgButon = new System.Windows.Forms.ImageList(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBookOperations = new System.Windows.Forms.Button();
            this.btnmember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxBookBuyerList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column4,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(867, 258);
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
            this.Column2.DataPropertyName = "ReaderName";
            this.Column2.HeaderText = "ADI";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ReaderSurname";
            this.Column3.HeaderText = "SOYADI";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BookName";
            this.Column6.HeaderText = "KİTAP ADI";
            this.Column6.Name = "Column6";
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "AuthorName";
            this.Column7.HeaderText = "YAZAR ADI";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TransactionDate";
            this.Column4.HeaderText = "TESLİM TARİHİ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DeliveryDate";
            this.Column5.HeaderText = "İADE TARİHİ";
            this.Column5.Name = "Column5";
            // 
            // gbxBookBuyerList
            // 
            this.gbxBookBuyerList.Controls.Add(this.dataGridView1);
            this.gbxBookBuyerList.Location = new System.Drawing.Point(12, 135);
            this.gbxBookBuyerList.Name = "gbxBookBuyerList";
            this.gbxBookBuyerList.Size = new System.Drawing.Size(873, 280);
            this.gbxBookBuyerList.TabIndex = 2;
            this.gbxBookBuyerList.TabStop = false;
            this.gbxBookBuyerList.Text = "KİTAP TESLİM ALANLAR :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetting);
            this.groupBox1.Controls.Add(this.bntClose);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnBookOperations);
            this.groupBox1.Controls.Add(this.btnmember);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetting.Location = new System.Drawing.Point(626, 22);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(114, 79);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "Ayarlar";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // bntClose
            // 
            this.bntClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntClose.ImageIndex = 0;
            this.bntClose.ImageList = this.ımgButon;
            this.bntClose.Location = new System.Drawing.Point(750, 22);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(114, 79);
            this.bntClose.TabIndex = 0;
            this.bntClose.Text = "Çıkış";
            this.bntClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.btnClose);
            // 
            // ımgButon
            // 
            this.ımgButon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımgButon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımgButon.ImageStream")));
            this.ımgButon.TransparentColor = System.Drawing.Color.Transparent;
            this.ımgButon.Images.SetKeyName(0, "exit.png");
            this.ımgButon.Images.SetKeyName(1, "book.png");
            this.ımgButon.Images.SetKeyName(2, "kitap al.png");
            this.ımgButon.Images.SetKeyName(3, "kitap ver.png");
            this.ımgButon.Images.SetKeyName(4, "rapor.png");
            this.ımgButon.Images.SetKeyName(5, "person.png");
            // 
            // button6
            // 
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.ImageIndex = 4;
            this.button6.ImageList = this.ımgButon;
            this.button6.Location = new System.Drawing.Point(502, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 79);
            this.button6.TabIndex = 0;
            this.button6.Text = "Raporlar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.ImageIndex = 2;
            this.button5.ImageList = this.ımgButon;
            this.button5.Location = new System.Drawing.Point(378, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 79);
            this.button5.TabIndex = 0;
            this.button5.Text = "Kitap Al";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.ImageIndex = 3;
            this.button4.ImageList = this.ımgButon;
            this.button4.Location = new System.Drawing.Point(254, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 79);
            this.button4.TabIndex = 0;
            this.button4.Text = "Kitap Ver";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBookOperations
            // 
            this.btnBookOperations.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBookOperations.ImageIndex = 1;
            this.btnBookOperations.ImageList = this.ımgButon;
            this.btnBookOperations.Location = new System.Drawing.Point(130, 22);
            this.btnBookOperations.Name = "btnBookOperations";
            this.btnBookOperations.Size = new System.Drawing.Size(114, 79);
            this.btnBookOperations.TabIndex = 0;
            this.btnBookOperations.Text = "Kitap İşlemleri";
            this.btnBookOperations.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBookOperations.UseVisualStyleBackColor = true;
            this.btnBookOperations.Click += new System.EventHandler(this.btnBookOperations_Click);
            // 
            // btnmember
            // 
            this.btnmember.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmember.ImageIndex = 5;
            this.btnmember.ImageList = this.ımgButon;
            this.btnmember.Location = new System.Drawing.Point(6, 22);
            this.btnmember.Name = "btnmember";
            this.btnmember.Size = new System.Drawing.Size(114, 79);
            this.btnmember.TabIndex = 0;
            this.btnmember.Text = "Üye İşlemleri";
            this.btnmember.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmember.UseVisualStyleBackColor = true;
            this.btnmember.Click += new System.EventHandler(this.btnMember);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBookBuyerList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "DİVANTÜRK ŞEHİT İRFAN ÜNCELİ İLKOKULU ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxBookBuyerList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbxBookBuyerList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBookOperations;
        private System.Windows.Forms.Button btnmember;
        private System.Windows.Forms.ImageList ımgButon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnSetting;
    }
}

