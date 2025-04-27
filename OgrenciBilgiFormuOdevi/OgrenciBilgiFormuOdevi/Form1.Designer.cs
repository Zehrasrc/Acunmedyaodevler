namespace OgrenciBilgiFormuOdevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtDepartment = new TextBox();
            listView1 = new ListView();
            ColumnHeaderAd = new ColumnHeader();
            ColumnHeaderSoyad = new ColumnHeader();
            ColumnHeaderBolum = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            btnKaydet = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            checkBoxKadın = new CheckBox();
            checkBoxErkek = new CheckBox();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            maskedtxtNumara = new MaskedTextBox();
            columnHeader2 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(100, 49);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(74, 88);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(67, 166);
            label3.Name = "label3";
            label3.Size = new Size(139, 23);
            label3.TabIndex = 2;
            label3.Text = "Öğrenci Bölümü:";
            // 
            // txtName
            // 
            txtName.Location = new Point(246, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(167, 27);
            txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(246, 88);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(167, 27);
            txtSurname.TabIndex = 4;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(246, 162);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(167, 27);
            txtDepartment.TabIndex = 5;
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnHeaderAd, ColumnHeaderSoyad, ColumnHeaderBolum, columnHeader1, columnHeader2 });
            listView1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            listView1.Location = new Point(60, 248);
            listView1.Name = "listView1";
            listView1.Size = new Size(671, 174);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ColumnHeaderAd
            // 
            ColumnHeaderAd.Text = "Öğrenci Adı";
            // 
            // ColumnHeaderSoyad
            // 
            ColumnHeaderSoyad.Text = "Öğrenci Soyadı";
            // 
            // ColumnHeaderBolum
            // 
            ColumnHeaderBolum.Text = "Öğrenci Bölümü";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cinsiyet";
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(588, 428);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(146, 32);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(567, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(130, 130);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 9;
            label4.Text = "Cinsiyet:";
            // 
            // checkBoxKadın
            // 
            checkBoxKadın.AutoSize = true;
            checkBoxKadın.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            checkBoxKadın.Location = new Point(246, 130);
            checkBoxKadın.Name = "checkBoxKadın";
            checkBoxKadın.Size = new Size(75, 27);
            checkBoxKadın.TabIndex = 10;
            checkBoxKadın.Text = "Kadın";
            checkBoxKadın.UseVisualStyleBackColor = true;
            // 
            // checkBoxErkek
            // 
            checkBoxErkek.AutoSize = true;
            checkBoxErkek.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            checkBoxErkek.Location = new Point(339, 129);
            checkBoxErkek.Name = "checkBoxErkek";
            checkBoxErkek.Size = new Size(74, 27);
            checkBoxErkek.TabIndex = 11;
            checkBoxErkek.Text = "Erkek";
            checkBoxErkek.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 38);
            panel1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(32, 8);
            label5.Name = "label5";
            label5.Size = new Size(173, 25);
            label5.TabIndex = 0;
            label5.Text = "Öğrenci Bilgi Formu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.Location = new Point(67, 209);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 13;
            label6.Text = "Öğrenci Numarası:";
            // 
            // maskedtxtNumara
            // 
            maskedtxtNumara.Location = new Point(244, 208);
            maskedtxtNumara.Mask = "(999) 000-0000";
            maskedtxtNumara.Name = "maskedtxtNumara";
            maskedtxtNumara.Size = new Size(169, 27);
            maskedtxtNumara.TabIndex = 14;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Öğrenci No";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(779, 465);
            Controls.Add(maskedtxtNumara);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(checkBoxErkek);
            Controls.Add(checkBoxKadın);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnKaydet);
            Controls.Add(listView1);
            Controls.Add(txtDepartment);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Öğrenci Bilgi Formu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtDepartment;
        private ListView listView1;
        private ColumnHeader ColumnHeaderAd;
        private ColumnHeader ColumnHeaderSoyad;
        private ColumnHeader ColumnHeaderBolum;
        private Button btnKaydet;
        private PictureBox pictureBox1;
        private Label label4;
        private CheckBox checkBoxKadın;
        private CheckBox checkBoxErkek;
        private Panel panel1;
        private Label label5;
        private ColumnHeader columnHeader1;
        private Label label6;
        private MaskedTextBox maskedtxtNumara;
        private ColumnHeader columnHeader2;
    }
}
