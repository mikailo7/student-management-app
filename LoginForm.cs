using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using PametniSat.DataLayer;

namespace PametniSat
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        /* private void btnLogin_Click(object sender, EventArgs e)
         {
             using (SqlConnection conn = Database.GetConnection())
             {
                 conn.Open();

                 string query = "SELECT * FROM Korisnici WHERE Ime=@ime AND Lozinka=@lozinka";

                 SqlCommand cmd = new SqlCommand(query, conn);

                 cmd.Parameters.AddWithValue("@ime", txtUsername.Text);
                 cmd.Parameters.AddWithValue("@lozinka", txtPassword.Text);

                 SqlDataReader reader = cmd.ExecuteReader();

                 if (reader.Read())
                 {
                     int id = (int)reader["Id"];

                     MessageBox.Show("Login uspešan");

                     MainForm main = new MainForm(id);
                     main.Show();

                     this.Hide();
                 }
                 else
                 {
                     MessageBox.Show("Pogrešan login");
                 }
             }
         }*/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int korisnikId = -1;

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "SELECT Id FROM Korisnici WHERE Ime=@ime AND Lozinka=@lozinka";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ime", txtUsername.Text);
                cmd.Parameters.AddWithValue("@lozinka", txtPassword.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    korisnikId = Convert.ToInt32(reader["Id"]);
                }

                reader.Close();
            }

            if (korisnikId != -1)
            {
                MessageBox.Show("Login uspešan");

                MainForm main = new MainForm(korisnikId);
                main.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Pogrešan login");
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}