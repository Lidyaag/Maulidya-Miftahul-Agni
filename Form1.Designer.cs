namespace ProjectUjian
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtpemasukan = new TextBox();
            txtdesk1 = new TextBox();
            txtpengeluaran = new TextBox();
            txtdeks2 = new TextBox();
            btnsubmit = new Button();
            txttanggal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 54);
            label1.Name = "label1";
            label1.Size = new Size(699, 36);
            label1.TabIndex = 0;
            label1.Text = "APLIKASI MANAGEMEN KEUANGAN PRIBADI";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(220, 117);
            label2.Name = "label2";
            label2.Size = new Size(484, 27);
            label2.TabIndex = 1;
            label2.Text = "Kelola Pemasukan dan Pengeluaran Anda Disini!";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 197);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 2;
            label3.Text = "Tanggal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 245);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 3;
            label4.Text = "Pemasukan";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Location = new Point(169, 295);
            label5.Name = "label5";
            label5.Size = new Size(108, 58);
            label5.TabIndex = 4;
            label5.Text = "Deskripsi Pemasukan";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 379);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 5;
            label6.Text = "Pengeluaran";
            // 
            // label7
            // 
            label7.Location = new Point(169, 427);
            label7.Name = "label7";
            label7.Size = new Size(142, 60);
            label7.TabIndex = 6;
            label7.Text = "Deskripsi Pengeluaran";
            // 
            // txtpemasukan
            // 
            txtpemasukan.Location = new Point(311, 242);
            txtpemasukan.Name = "txtpemasukan";
            txtpemasukan.Size = new Size(431, 31);
            txtpemasukan.TabIndex = 18;
            txtpemasukan.TextChanged += txtpemasukan_TextChanged;
            // 
            // txtdesk1
            // 
            txtdesk1.Location = new Point(311, 309);
            txtdesk1.Name = "txtdesk1";
            txtdesk1.Size = new Size(431, 31);
            txtdesk1.TabIndex = 19;
            txtdesk1.TextChanged += txtdesk1_TextChanged;
            // 
            // txtpengeluaran
            // 
            txtpengeluaran.Location = new Point(311, 379);
            txtpengeluaran.Name = "txtpengeluaran";
            txtpengeluaran.Size = new Size(431, 31);
            txtpengeluaran.TabIndex = 20;
            txtpengeluaran.TextChanged += txtpengeluaran_TextChanged;
            // 
            // txtdeks2
            // 
            txtdeks2.Location = new Point(311, 437);
            txtdeks2.Name = "txtdeks2";
            txtdeks2.Size = new Size(431, 31);
            txtdeks2.TabIndex = 21;
            txtdeks2.TextChanged += txtdeks2_TextChanged;
            // 
            // btnsubmit
            // 
            btnsubmit.Location = new Point(575, 507);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(167, 41);
            btnsubmit.TabIndex = 22;
            btnsubmit.Text = "Tambah Data";
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // txttanggal
            // 
            txttanggal.Location = new Point(311, 197);
            txttanggal.Name = "txttanggal";
            txttanggal.Size = new Size(431, 31);
            txttanggal.TabIndex = 23;
            txttanggal.TextChanged += txttanggal_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 619);
            Controls.Add(txttanggal);
            Controls.Add(btnsubmit);
            Controls.Add(txtdeks2);
            Controls.Add(txtpengeluaran);
            Controls.Add(txtdesk1);
            Controls.Add(txtpemasukan);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtpemasukan;
        private TextBox txtdesk1;
        private TextBox txtpengeluaran;
        private TextBox txtdeks2;
        private Button btnsubmit;
        private TextBox txttanggal;
    }
}
