
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxBookBuyerList = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntClose = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBookOperations = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxBookBuyerList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(867, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbxBookBuyerList
            // 
            this.gbxBookBuyerList.Controls.Add(this.dataGridView1);
            this.gbxBookBuyerList.Location = new System.Drawing.Point(13, 118);
            this.gbxBookBuyerList.Name = "gbxBookBuyerList";
            this.gbxBookBuyerList.Size = new System.Drawing.Size(873, 280);
            this.gbxBookBuyerList.TabIndex = 2;
            this.gbxBookBuyerList.TabStop = false;
            this.gbxBookBuyerList.Text = "KİTAP TESLİM ALANLAR :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntClose);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnBookOperations);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(606, 22);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(114, 56);
            this.bntClose.TabIndex = 0;
            this.bntClose.Text = "Çıkış";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.btnClose);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(486, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 56);
            this.button6.TabIndex = 0;
            this.button6.Text = "Raporlar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(366, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 56);
            this.button5.TabIndex = 0;
            this.button5.Text = "Kitap Al";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 56);
            this.button4.TabIndex = 0;
            this.button4.Text = "Kitap Ver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBookOperations
            // 
            this.btnBookOperations.Location = new System.Drawing.Point(126, 22);
            this.btnBookOperations.Name = "btnBookOperations";
            this.btnBookOperations.Size = new System.Drawing.Size(114, 56);
            this.btnBookOperations.TabIndex = 0;
            this.btnBookOperations.Text = "Kitap İşlemleri";
            this.btnBookOperations.UseVisualStyleBackColor = true;
            this.btnBookOperations.Click += new System.EventHandler(this.btnBookOperations_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 56);
            this.button2.TabIndex = 0;
            this.button2.Text = "Üye İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBookBuyerList);
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
        private System.Windows.Forms.Button button2;
    }
}

