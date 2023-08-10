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
            textBox1 = new TextBox();
            label5 = new Label();
            txtOgrenciNo = new TextBox();
            btnEtutVer = new Button();
            label7 = new Label();
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
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtOgrenciNo);
            groupBox2.Controls.Add(btnEtutVer);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(291, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 195);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(102, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 25);
            textBox1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 28);
            label5.Name = "label5";
            label5.Size = new Size(65, 18);
            label5.TabIndex = 10;
            label5.Text = "Etüt ID: ";
            // 
            // txtOgrenciNo
            // 
            txtOgrenciNo.Location = new Point(102, 56);
            txtOgrenciNo.Name = "txtOgrenciNo";
            txtOgrenciNo.Size = new Size(165, 25);
            txtOgrenciNo.TabIndex = 9;
            // 
            // btnEtutVer
            // 
            btnEtutVer.Location = new Point(102, 150);
            btnEtutVer.Name = "btnEtutVer";
            btnEtutVer.Size = new Size(165, 30);
            btnEtutVer.TabIndex = 8;
            btnEtutVer.Text = "Etüt Ver";
            btnEtutVer.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 59);
            label7.Name = "label7";
            label7.Size = new Size(80, 18);
            label7.TabIndex = 3;
            label7.Text = "Öğrenci No: ";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 213);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(560, 212);
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
            dataGridView1.Size = new Size(554, 188);
            dataGridView1.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(584, 437);
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
        private TextBox textBox1;
        private Label label5;
        private TextBox txtOgrenciNo;
        private Label label7;
    }
}