
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtFirstDate = new System.Windows.Forms.DateTimePicker();
            this.dtSecondDate = new System.Windows.Forms.DateTimePicker();
            this.btnBring = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(813, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // dtFirstDate
            // 
            this.dtFirstDate.Location = new System.Drawing.Point(40, 47);
            this.dtFirstDate.Name = "dtFirstDate";
            this.dtFirstDate.Size = new System.Drawing.Size(200, 23);
            this.dtFirstDate.TabIndex = 1;
            // 
            // dtSecondDate
            // 
            this.dtSecondDate.Location = new System.Drawing.Point(275, 47);
            this.dtSecondDate.Name = "dtSecondDate";
            this.dtSecondDate.Size = new System.Drawing.Size(200, 23);
            this.dtSecondDate.TabIndex = 1;
            // 
            // btnBring
            // 
            this.btnBring.Location = new System.Drawing.Point(499, 47);
            this.btnBring.Name = "btnBring";
            this.btnBring.Size = new System.Drawing.Size(105, 23);
            this.btnBring.TabIndex = 2;
            this.btnBring.Text = "GETİR";
            this.btnBring.UseVisualStyleBackColor = true;
            this.btnBring.Click += new System.EventHandler(this.btnBring_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, -5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kitap Kurdunu Bul";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBring);
            this.Controls.Add(this.dtSecondDate);
            this.Controls.Add(this.dtFirstDate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmReports";
            this.Text = "FrmReports";
            this.Load += new System.EventHandler(this.FrmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtFirstDate;
        private System.Windows.Forms.DateTimePicker dtSecondDate;
        private System.Windows.Forms.Button btnBring;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}