namespace Etut_Project
{
    partial class FormMain
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
            groupBox1 = new GroupBox();
            btnEtutOlustur = new Button();
            mskSaat = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            cmbOgretmen = new ComboBox();
            label2 = new Label();
            cmbDers = new ComboBox();
            mskTarih = new MaskedTextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtEtutID = new TextBox();
            label5 = new Label();
            txtOgrenciNo = new TextBox();
            btnEtutVer = new Button();
            label7 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            btnDersKaydet = new Button();
            txtDersAdi = new TextBox();
            label6 = new Label();
            groupBox5 = new GroupBox();
            btnOgrenciKaydet = new Button();
            mskOgrTelefon = new MaskedTextBox();
            txtOgrMail = new TextBox();
            label12 = new Label();
            label11 = new Label();
            txtOgrSinif = new TextBox();
            label10 = new Label();
            txtOgrSoyad = new TextBox();
            label9 = new Label();
            txtOgrAd = new TextBox();
            label8 = new Label();
            groupBox6 = new GroupBox();
            btnFotografYukle = new Button();
            pictureBox1 = new PictureBox();
            groupBox7 = new GroupBox();
            btnOgretmenKaydet = new Button();
            cmbOgrtBrans = new ComboBox();
            label13 = new Label();
            txtOgrtSoyad = new TextBox();
            label14 = new Label();
            txtOgrtAd = new TextBox();
            label15 = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEtutOlustur);
            groupBox1.Controls.Add(mskSaat);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbOgretmen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbDers);
            groupBox1.Controls.Add(mskTarih);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnEtutOlustur
            // 
            btnEtutOlustur.Location = new Point(88, 150);
            btnEtutOlustur.Name = "btnEtutOlustur";
            btnEtutOlustur.Size = new Size(165, 30);
            btnEtutOlustur.TabIndex = 4;
            btnEtutOlustur.Text = "Etüt Oluştur";
            btnEtutOlustur.UseVisualStyleBackColor = true;
            btnEtutOlustur.Click += btnEtutOlustur_Click;
            // 
            // mskSaat
            // 
            mskSaat.Location = new Point(88, 119);
            mskSaat.Mask = "00:00";
            mskSaat.Name = "mskSaat";
            mskSaat.Size = new Size(165, 25);
            mskSaat.TabIndex = 3;
            mskSaat.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 122);
            label4.Name = "label4";
            label4.Size = new Size(40, 18);
            label4.TabIndex = 6;
            label4.Text = "Saat: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 91);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 5;
            label3.Text = "Tarih: ";
            // 
            // cmbOgretmen
            // 
            cmbOgretmen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgretmen.FormattingEnabled = true;
            cmbOgretmen.Location = new Point(88, 56);
            cmbOgretmen.Name = "cmbOgretmen";
            cmbOgretmen.Size = new Size(165, 26);
            cmbOgretmen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 59);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 3;
            label2.Text = "Öğretmen: ";
            // 
            // cmbDers
            // 
            cmbDers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDers.FormattingEnabled = true;
            cmbDers.Location = new Point(88, 24);
            cmbDers.Name = "cmbDers";
            cmbDers.Size = new Size(165, 26);
            cmbDers.TabIndex = 0;
            cmbDers.SelectedIndexChanged += cmbDers_SelectedIndexChanged;
            // 
            // mskTarih
            // 
            mskTarih.Location = new Point(88, 88);
            mskTarih.Mask = "00/00/0000";
            mskTarih.Name = "mskTarih";
            mskTarih.Size = new Size(165, 25);
            mskTarih.TabIndex = 2;
            mskTarih.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 18);
            label1.TabIndex = 0;
            label1.Text = "Ders: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEtutID);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtOgrenciNo);
            groupBox2.Controls.Add(btnEtutVer);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(291, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 145);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // txtEtutID
            // 
            txtEtutID.Enabled = false;
            txtEtutID.Location = new Point(102, 33);
            txtEtutID.Name = "txtEtutID";
            txtEtutID.Size = new Size(165, 25);
            txtEtutID.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 36);
            label5.Name = "label5";
            label5.Size = new Size(65, 18);
            label5.TabIndex = 10;
            label5.Text = "Etüt ID: ";
            // 
            // txtOgrenciNo
            // 
            txtOgrenciNo.Location = new Point(102, 64);
            txtOgrenciNo.Name = "txtOgrenciNo";
            txtOgrenciNo.Size = new Size(165, 25);
            txtOgrenciNo.TabIndex = 9;
            // 
            // btnEtutVer
            // 
            btnEtutVer.Location = new Point(102, 95);
            btnEtutVer.Name = "btnEtutVer";
            btnEtutVer.Size = new Size(165, 30);
            btnEtutVer.TabIndex = 8;
            btnEtutVer.Text = "Etüt Ver";
            btnEtutVer.UseVisualStyleBackColor = true;
            btnEtutVer.Click += btnEtutVer_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 67);
            label7.Name = "label7";
            label7.Size = new Size(80, 18);
            label7.TabIndex = 3;
            label7.Text = "Öğrenci No: ";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 227);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(801, 211);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(795, 187);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDersKaydet);
            groupBox4.Controls.Add(txtDersAdi);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(291, 163);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(281, 65);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            // 
            // btnDersKaydet
            // 
            btnDersKaydet.Location = new Point(194, 24);
            btnDersKaydet.Name = "btnDersKaydet";
            btnDersKaydet.Size = new Size(81, 30);
            btnDersKaydet.TabIndex = 12;
            btnDersKaydet.Text = "Kaydet";
            btnDersKaydet.UseVisualStyleBackColor = true;
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(78, 27);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(111, 25);
            txtDersAdi.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 32);
            label6.Name = "label6";
            label6.Size = new Size(69, 18);
            label6.TabIndex = 12;
            label6.Text = "Ders Adı: ";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnOgrenciKaydet);
            groupBox5.Controls.Add(mskOgrTelefon);
            groupBox5.Controls.Add(txtOgrMail);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(txtOgrSinif);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(txtOgrSoyad);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(txtOgrAd);
            groupBox5.Controls.Add(label8);
            groupBox5.Location = new Point(578, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(235, 216);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "Öğrenci Kayıt";
            // 
            // btnOgrenciKaydet
            // 
            btnOgrenciKaydet.Location = new Point(87, 179);
            btnOgrenciKaydet.Name = "btnOgrenciKaydet";
            btnOgrenciKaydet.Size = new Size(131, 30);
            btnOgrenciKaydet.TabIndex = 5;
            btnOgrenciKaydet.Text = "Öğrenci Kaydet";
            btnOgrenciKaydet.UseVisualStyleBackColor = true;
            btnOgrenciKaydet.Click += btnOgrenciKaydet_Click;
            // 
            // mskOgrTelefon
            // 
            mskOgrTelefon.Location = new Point(87, 117);
            mskOgrTelefon.Mask = "(999) 000-0000";
            mskOgrTelefon.Name = "mskOgrTelefon";
            mskOgrTelefon.Size = new Size(131, 25);
            mskOgrTelefon.TabIndex = 3;
            // 
            // txtOgrMail
            // 
            txtOgrMail.Location = new Point(87, 148);
            txtOgrMail.Name = "txtOgrMail";
            txtOgrMail.Size = new Size(131, 25);
            txtOgrMail.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(38, 151);
            label12.Name = "label12";
            label12.Size = new Size(43, 18);
            label12.TabIndex = 22;
            label12.Text = "Mail: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 120);
            label11.Name = "label11";
            label11.Size = new Size(58, 18);
            label11.TabIndex = 20;
            label11.Text = "Telefon: ";
            // 
            // txtOgrSinif
            // 
            txtOgrSinif.Location = new Point(87, 86);
            txtOgrSinif.MaxLength = 2;
            txtOgrSinif.Name = "txtOgrSinif";
            txtOgrSinif.Size = new Size(131, 25);
            txtOgrSinif.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 89);
            label10.Name = "label10";
            label10.Size = new Size(43, 18);
            label10.TabIndex = 18;
            label10.Text = "Sınıf: ";
            // 
            // txtOgrSoyad
            // 
            txtOgrSoyad.Location = new Point(87, 55);
            txtOgrSoyad.Name = "txtOgrSoyad";
            txtOgrSoyad.Size = new Size(131, 25);
            txtOgrSoyad.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 58);
            label9.Name = "label9";
            label9.Size = new Size(50, 18);
            label9.TabIndex = 16;
            label9.Text = "Soyad: ";
            // 
            // txtOgrAd
            // 
            txtOgrAd.Location = new Point(87, 24);
            txtOgrAd.Name = "txtOgrAd";
            txtOgrAd.Size = new Size(131, 25);
            txtOgrAd.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 27);
            label8.Name = "label8";
            label8.Size = new Size(34, 18);
            label8.TabIndex = 14;
            label8.Text = "Ad: ";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnFotografYukle);
            groupBox6.Controls.Add(pictureBox1);
            groupBox6.Location = new Point(819, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(232, 216);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "Öğrenci Fotoğraf Seç";
            // 
            // btnFotografYukle
            // 
            btnFotografYukle.Location = new Point(54, 173);
            btnFotografYukle.Name = "btnFotografYukle";
            btnFotografYukle.Size = new Size(131, 30);
            btnFotografYukle.TabIndex = 25;
            btnFotografYukle.Text = "Fotoğraf Yükle";
            btnFotografYukle.UseVisualStyleBackColor = true;
            btnFotografYukle.Click += btnFotografYukle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btnOgretmenKaydet);
            groupBox7.Controls.Add(cmbOgrtBrans);
            groupBox7.Controls.Add(label13);
            groupBox7.Controls.Add(txtOgrtSoyad);
            groupBox7.Controls.Add(label14);
            groupBox7.Controls.Add(txtOgrtAd);
            groupBox7.Controls.Add(label15);
            groupBox7.Location = new Point(819, 227);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(232, 211);
            groupBox7.TabIndex = 15;
            groupBox7.TabStop = false;
            groupBox7.Text = "Öğretmen Kayıt";
            // 
            // btnOgretmenKaydet
            // 
            btnOgretmenKaydet.Location = new Point(83, 139);
            btnOgretmenKaydet.Name = "btnOgretmenKaydet";
            btnOgretmenKaydet.Size = new Size(131, 30);
            btnOgretmenKaydet.TabIndex = 26;
            btnOgretmenKaydet.Text = "Öğretmen Kaydet";
            btnOgretmenKaydet.UseVisualStyleBackColor = true;
            btnOgretmenKaydet.Click += btnOgretmenKaydet_Click;
            // 
            // cmbOgrtBrans
            // 
            cmbOgrtBrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgrtBrans.FormattingEnabled = true;
            cmbOgrtBrans.Location = new Point(83, 107);
            cmbOgrtBrans.Name = "cmbOgrtBrans";
            cmbOgrtBrans.Size = new Size(131, 26);
            cmbOgrtBrans.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(34, 110);
            label13.Name = "label13";
            label13.Size = new Size(49, 18);
            label13.TabIndex = 25;
            label13.Text = "Brans: ";
            // 
            // txtOgrtSoyad
            // 
            txtOgrtSoyad.Location = new Point(83, 76);
            txtOgrtSoyad.Name = "txtOgrtSoyad";
            txtOgrtSoyad.Size = new Size(131, 25);
            txtOgrtSoyad.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(27, 79);
            label14.Name = "label14";
            label14.Size = new Size(50, 18);
            label14.TabIndex = 22;
            label14.Text = "Soyad: ";
            // 
            // txtOgrtAd
            // 
            txtOgrtAd.Location = new Point(83, 45);
            txtOgrtAd.Name = "txtOgrtAd";
            txtOgrtAd.Size = new Size(131, 25);
            txtOgrtAd.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(43, 48);
            label15.Name = "label15";
            label15.Size = new Size(34, 18);
            label15.TabIndex = 20;
            label15.Text = "Ad: ";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1063, 450);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etüt Programı";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private ComboBox cmbOgretmen;
        private Label label2;
        private ComboBox cmbDers;
        private MaskedTextBox mskTarih;
        private Label label1;
        private Button btnEtutOlustur;
        private MaskedTextBox mskSaat;
        private GroupBox groupBox2;
        private Button btnEtutVer;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private TextBox txtEtutID;
        private Label label5;
        private TextBox txtOgrenciNo;
        private Label label7;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Button btnDersKaydet;
        private TextBox txtDersAdi;
        private Label label6;
        private TextBox txtOgrMail;
        private Label label12;
        private Label label11;
        private TextBox txtOgrSinif;
        private Label label10;
        private TextBox txtOgrSoyad;
        private Label label9;
        private TextBox txtOgrAd;
        private Label label8;
        private Button btnOgrenciKaydet;
        private MaskedTextBox mskOgrTelefon;
        private PictureBox pictureBox1;
        private Button btnFotografYukle;
        private TextBox txtOgrtSoyad;
        private Label label14;
        private TextBox txtOgrtAd;
        private Label label15;
        private Button btnOgretmenKaydet;
        private ComboBox cmbOgrtBrans;
        private Label label13;
        private OpenFileDialog openFileDialog1;
    }
}