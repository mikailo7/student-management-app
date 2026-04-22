using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PametniSat.DataLayer;

namespace PametniSat
{
    public partial class PulsHistoryForm : Form
    {
        int satId;

        public PulsHistoryForm(int id)
        {
            InitializeComponent();

            satId = id;

            LoadPuls();
        }

        void LoadPuls()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                "SELECT Puls, Datum FROM PulsLog WHERE SatId=@id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", satId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridPuls.DataSource = dt;
            }
        }
        private void PulsHistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}