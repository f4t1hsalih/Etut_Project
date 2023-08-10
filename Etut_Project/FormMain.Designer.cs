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
            chbIptal = new CheckBox();
            lblOgrenci = new Label();
            lblOgretmen = new Label();
            btnEtutDetay = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            groupBox1.Size = new Size(272, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnEtutOlustur
            // 
            btnEtutOlustur.Location = new Point(88, 150);
            btnEtutOlustur.Name = "btnEtutOlustur";
            btnEtutOlustur.Size = new Size(165, 30);
            btnEtutOlustur.TabIndex = 8;
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
            mskSaat.TabIndex = 7;
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
            cmbOgretmen.TabIndex = 4;
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
            cmbDers.TabIndex = 2;
            cmbDers.SelectedIndexChanged += cmbDers_SelectedIndexChanged;
            // 
            // mskTarih
            // 
            mskTarih.Location = new Point(88, 88);
            mskTarih.Mask = "00/00/0000";
            mskTarih.Name = "mskTarih";
            mskTarih.Size = new Size(165, 25);
            mskTarih.TabIndex = 1;
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
            groupBox2.Controls.Add(chbIptal);
            groupBox2.Controls.Add(lblOgrenci);
            groupBox2.Controls.Add(lblOgretmen);
            groupBox2.Controls.Add(btnEtutDetay);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(291, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(209, 195);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // chbIptal
            // 
            chbIptal.AutoSize = true;
            chbIptal.Location = new Point(111, 106);
            chbIptal.Name = "chbIptal";
            chbIptal.Size = new Size(55, 22);
            chbIptal.TabIndex = 11;
            chbIptal.Text = "İptal";
            chbIptal.UseVisualStyleBackColor = true;
            // 
            // lblOgrenci
            // 
            lblOgrenci.AutoSize = true;
            lblOgrenci.Location = new Point(111, 75);
            lblOgrenci.Name = "lblOgrenci";
            lblOgrenci.Size = new Size(35, 18);
            lblOgrenci.TabIndex = 10;
            lblOgrenci.Text = "Null";
            // 
            // lblOgretmen
            // 
            lblOgretmen.AutoSize = true;
            lblOgretmen.Location = new Point(111, 43);
            lblOgretmen.Name = "lblOgretmen";
            lblOgretmen.Size = new Size(35, 18);
            lblOgretmen.TabIndex = 9;
            lblOgretmen.Text = "Null";
            // 
            // btnEtutDetay
            // 
            btnEtutDetay.Location = new Point(22, 138);
            btnEtutDetay.Name = "btnEtutDetay";
            btnEtutDetay.Size = new Size(165, 30);
            btnEtutDetay.TabIndex = 8;
            btnEtutDetay.Text = "Etüt Detay";
            btnEtutDetay.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 107);
            label6.Name = "label6";
            label6.Size = new Size(58, 18);
            label6.TabIndex = 5;
            label6.Text = "Durum: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 75);
            label7.Name = "label7";
            label7.Size = new Size(59, 18);
            label7.TabIndex = 3;
            label7.Text = "Öğrenci: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 43);
            label8.Name = "label8";
            label8.Size = new Size(71, 18);
            label8.TabIndex = 0;
            label8.Text = "Öğretmen: ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 213);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(487, 212);
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
            dataGridView1.Size = new Size(481, 188);
            dataGridView1.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(511, 437);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
        private CheckBox chbIptal;
        private Label lblOgrenci;
        private Label lblOgretmen;
        private Button btnEtutDetay;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
    }
}