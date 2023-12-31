using System.Data;
using System.Data.SqlClient;

namespace Etut_Project
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            DersListesi();
            EtutListesi();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=krsDbEtut;Integrated Security=True");

        private bool DersVarmi(string lesson)
        {
            con.Open();
            string komut = "select count(*) from tbl_subjects where subject_name=@p1";
            SqlCommand cmd = new SqlCommand(komut, con);
            cmd.Parameters.AddWithValue("@p1", lesson);
            int kayitSayisi = (int)cmd.ExecuteScalar();
            con.Close();
            //Bu kod ders mevcutsa false, mevcut de�ilse true d�nd�r�r.
            return kayitSayisi > 0 ? false : true;

        }

        private void DersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_subjects", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.ValueMember = "subject_id";
            cmbDers.DisplayMember = "subject_name";
            cmbDers.DataSource = dt;

            cmbOgrtBrans.ValueMember = "subject_id";
            cmbOgrtBrans.DisplayMember = "subject_name";
            cmbOgrtBrans.DataSource = dt;
        }

        private void EtutListesi()
        {
            string komut = "execute EtutOlustur";
            SqlDataAdapter da = new SqlDataAdapter(komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void EtutTemizle()
        {
            mskTarih.Clear();
            mskSaat.Clear();
            txtEtutID.Clear();
            txtOgrenciNo.Clear();
        }

        private void OgrenciTemizle()
        {
            txtOgrAd.Clear();
            txtOgrSoyad.Clear();
            txtOgrSinif.Clear();
            mskOgrTelefon.Clear();
            txtOgrMail.Clear();
            pictureBox1.ImageLocation = null;
        }

        private void OgretmenTemizle()
        {
            txtOgrtAd.Clear();
            txtOgrtSoyad.Clear();
            cmbOgrtBrans.SelectedValue = 1;
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             Kullan�m 1
             SqlDataAdapter da = new SqlDataAdapter("select tch_id, (first_name + ' ' + last_name) as name from tbl_teachers where subject_id=" + cmbDers.SelectedValue, con);
             DataTable dt = new DataTable();
             da.Fill(dt);
             cmbOgretmen.ValueMember = "tch_id";
             cmbOgretmen.DisplayMember = "name";
             cmbOgretmen.DataSource = dt;
            */

            //Kullan�m 2
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_teachers WHERE subject_id = " + cmbDers.SelectedValue, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // "first_name" ve "last_name" s�tunlar�n� birle�tirerek yeni bir s�tun ekleyin
            dt.Columns.Add("FullName", typeof(string), "first_name + ' ' + last_name");

            cmbOgretmen.ValueMember = "tch_id";
            cmbOgretmen.DisplayMember = "FullName"; // Olu�turdu�unuz yeni s�tunu DisplayMember olarak kullan�n
            cmbOgretmen.DataSource = dt;
        }

        private void btnEtutOlustur_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(cmbDers.SelectedValue) == 0 || Convert.ToInt16(cmbOgretmen.SelectedValue) == 0 || mskTarih.Text == "  .  ." || mskSaat.Text == "  :")
            {
                MessageBox.Show("Her yeri doldurdu�unuzdan emin olun!");
            }
            else
            {
                con.Open();
                string komut = "insert into tbl_etut(subject_id,tch_id,date,hour) values (@p1,@p2,@p3,@p4)";
                SqlCommand cmd = new SqlCommand(komut, con);
                cmd.Parameters.AddWithValue("@p1", cmbDers.SelectedValue);
                cmd.Parameters.AddWithValue("@p2", cmbOgretmen.SelectedValue);
                cmd.Parameters.AddWithValue("@p3", mskTarih.Text);
                cmd.Parameters.AddWithValue("@p4", mskSaat.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("��leminiz Ba�ar�yla Ger�ekle�ti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EtutListesi();
                EtutTemizle();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtEtutID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnEtutVer_Click(object sender, EventArgs e)
        {
            if (txtEtutID.Text != "" && txtOgrenciNo.Text != "")
            {
                con.Open();
                string komut = "update tbl_etut set std_id = @p1, situation = @p2 where etut_id = @p3";
                SqlCommand cmd = new SqlCommand(komut, con);
                cmd.Parameters.AddWithValue("@p1", txtOgrenciNo.Text);
                cmd.Parameters.AddWithValue("@p2", true);
                cmd.Parameters.AddWithValue("@p3", txtEtutID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Et�t ��renciye Verildi", "Bilgi");
                con.Close();
                EtutTemizle();
            }
            else
            {
                MessageBox.Show("T�m De�erleri Doldurdu�unuzdan Emin Olun");
            }
            EtutListesi();
        }

        private void btnFotografYukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            if (txtOgrAd.Text != "" && txtOgrSoyad.Text != "" && txtOgrSinif.Text != "" && txtOgrMail.Text != "")
            {
                con.Open();
                string komut = "insert into tbl_students(first_name, last_name, photo, phone_number, mail) values (@p1, @p2, @p3, @p4, @p5)";
                SqlCommand cmd = new SqlCommand(komut, con);
                cmd.Parameters.AddWithValue("@p1", txtOgrAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                if (pictureBox1.ImageLocation != null) cmd.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
                else cmd.Parameters.AddWithValue("@p3", "");
                cmd.Parameters.AddWithValue("@p4", mskOgrTelefon.Text);
                cmd.Parameters.AddWithValue("@p5", txtOgrMail.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("��renci Ba�ar�yla Kaydedildi");
                con.Close();
                OgrenciTemizle();
            }
            else
            {
                MessageBox.Show("L�tfen Alanlar� Bo� B�rakmay�n�z");
            }

        }

        private void btnOgretmenKaydet_Click(object sender, EventArgs e)
        {
            if (txtOgrtAd.Text != "" && txtOgrtSoyad.Text != "")
            {
                con.Open();
                string komut = "insert into tbl_teachers(first_name, last_name, subject_id) values (@p1, @p2, @p3)";
                SqlCommand cmd = new SqlCommand(komut, con);
                cmd.Parameters.AddWithValue("@p1", txtOgrtAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtOgrtSoyad.Text);
                cmd.Parameters.AddWithValue("@p3", cmbOgrtBrans.SelectedValue);
                cmd.ExecuteNonQuery();
                MessageBox.Show("��retmen Ba�ar�yla Kaydedildi");
                con.Close();
                OgretmenTemizle();
            }
            else
            {
                MessageBox.Show("L�tfen Alanlar� Bo� B�rakmay�n�z");
            }

        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            string dersAdi = txtDersAdi.Text.Trim().ToUpper();

            //E�er bo�sa veya bo�luktan olu�uyorsa true d�nd�r�r. False yapmak i�in '!' kullan�l�r.
            //Yani bo� de�il ise bunlar� yap bo� ise mesaj ver.
            if (!string.IsNullOrWhiteSpace(dersAdi))
            {
                if (DersVarmi(dersAdi))
                {
                    con.Open();
                    string komut = "insert into tbl_subjects(subject_name) values (@p1)";
                    SqlCommand cmd = new SqlCommand(komut, con);
                    cmd.Parameters.AddWithValue("@p1", dersAdi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ders Ba�ar�yla Kaydedildi");
                    con.Close();
                    txtDersAdi.Clear();
                }
                else
                {
                    MessageBox.Show("Bu Ders Veritaban�nda Zaten Var!");
                }
            }
            else
            {
                MessageBox.Show("L�tfen Bir Ders Ad� Giriniz!");
            }

        }
    }
}