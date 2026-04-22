using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using PametniSat.DataLayer;

namespace PametniSat
{
    public partial class DodajSatForm : Form
    {
        int korisnikId;

        public DodajSatForm(int id)
        {
            InitializeComponent();

            korisnikId = id;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                @"INSERT INTO Satovi
                (KorisnikId,Marka,Cena,Baterija,Koraci,OtkucajiSrca,SleepMode,Datum)
                VALUES
                (@kid,@marka,@cena,@bat,@kor,@puls,@sleep,GETDATE())";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@kid", korisnikId);
                cmd.Parameters.AddWithValue("@marka", txtMarka.Text);
                cmd.Parameters.AddWithValue("@cena", Convert.ToDouble(txtCena.Text));
                cmd.Parameters.AddWithValue("@bat", Convert.ToInt32(txtBaterija.Text));
                cmd.Parameters.AddWithValue("@kor", Convert.ToInt32(txtKoraci.Text));
                cmd.Parameters.AddWithValue("@puls", Convert.ToInt32(txtPuls.Text));
                cmd.Parameters.AddWithValue("@sleep", chkSleep.Checked);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Sat dodat!");

            this.Close();
        }

        private void DodajSatForm_Load(object sender, EventArgs e)
        {

        }
    }
}