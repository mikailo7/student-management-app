using System.Data.SqlClient;
using PametniSat.Models;

namespace PametniSat.DataLayer
{
    public class KorisnikRepository
    {
        public Korisnik Login(string ime, string lozinka)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Korisnici WHERE Ime=@ime AND Lozinka=@lozinka";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ime", ime);
                cmd.Parameters.AddWithValue("@lozinka", lozinka);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Korisnik k = new Korisnik();

                    k.Id = (int)reader["Id"];
                    k.Ime = reader["Ime"].ToString();
                    k.Lozinka = reader["Lozinka"].ToString();

                    return k;
                }

                return null;
            }
        }
        public void Register(string ime, string lozinka)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO Korisnici (Ime, Lozinka) VALUES (@ime,@lozinka)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ime", ime);
                cmd.Parameters.AddWithValue("@lozinka", lozinka);

                cmd.ExecuteNonQuery();
            }
        }
        public bool PostojiKorisnik(string ime)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Korisnici WHERE Ime=@ime";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ime", ime);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }
    }
}