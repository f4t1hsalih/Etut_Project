using System.Data;
using System.Data.SqlClient;

namespace Etut_Project
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            dersListesi();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=krsDbEtut;Integrated Security=True");

        void dersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_subjects", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.ValueMember = "subject_id";
            cmbDers.DisplayMember = "subject_name";
            cmbDers.DataSource = dt;
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
            }
        }


    }
}