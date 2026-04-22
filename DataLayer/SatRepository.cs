using System.Collections.Generic;
using System.Data.SqlClient;
using PametniSat.Models;

namespace PametniSat.DataLayer
{
    public class SatRepository
    {
        public List<Sat> GetSatovi(int korisnikId)
        {
            List<Sat> lista = new List<Sat>();

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Satovi WHERE KorisnikId=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", korisnikId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Sat s = new Sat();

                    s.Id = Convert.ToInt32(reader["Id"]);
                    s.KorisnikId = Convert.ToInt32(reader["KorisnikId"]);
                    s.Marka = reader["Marka"].ToString();
                    s.Cena = reader["Cena"] == DBNull.Value ? 0 : Convert.ToDouble(reader["Cena"]);
                    s.Baterija = reader["Baterija"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Baterija"]);
                    s.Koraci = reader["Koraci"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Koraci"]);
                    s.OtkucajiSrca = reader["OtkucajiSrca"] == DBNull.Value ? 0 : Convert.ToInt32(reader["OtkucajiSrca"]);
                    s.SleepMode = reader["SleepMode"] == DBNull.Value ? false : Convert.ToBoolean(reader["SleepMode"]);
                    s.Datum = reader["Datum"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["Datum"]);

                    lista.Add(s);
                }
            }

            return lista;
        }

        public void DeleteSat(int id)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM Satovi WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void NapuniSat(int id)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "UPDATE Satovi SET Baterija = 100 WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void DodajKorake(int id)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "UPDATE Satovi SET Koraci = Koraci + 10 WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void SleepMode(int id)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "UPDATE Satovi SET SleepMode = 1 WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public int OtkucajiSrca(int id)
        {
            Random rand = new Random();

            int puls = rand.Next(60, 140);

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string updateSat =
                "UPDATE Satovi SET OtkucajiSrca=@puls WHERE Id=@id";

                SqlCommand cmd1 = new SqlCommand(updateSat, conn);

                cmd1.Parameters.AddWithValue("@puls", puls);
                cmd1.Parameters.AddWithValue("@id", id);

                cmd1.ExecuteNonQuery();

                string insertLog =
                "INSERT INTO PulsLog (SatId,Puls,Datum) VALUES (@id,@puls,GETDATE())";

                SqlCommand cmd2 = new SqlCommand(insertLog, conn);

                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.Parameters.AddWithValue("@puls", puls);

                cmd2.ExecuteNonQuery();
            }

            return puls;
        }
        public void UpdateDatum(int id)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "UPDATE Satovi SET Datum = GETDATE() WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}