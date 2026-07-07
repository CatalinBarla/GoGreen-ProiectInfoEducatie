using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoGreen
{
    internal class Utilizatori
    {
        public static List<Utilizatori> _utilizatori = new List<Utilizatori>();

        public string Nume;
        public string Email;
        public string parola;
        public string DataInregistrare;

        public static Utilizatori utilizatorlogat = null;

        private static string connectionString = "Server=localhost;Database=database;Uid=root;Pwd=;";

        public Utilizatori(string nume, string email, string parola, string dataInregistrare)
        {
            Nume = nume;
            Email = email;
            this.parola = parola;
            DataInregistrare = dataInregistrare;
        }

        public static void LoadInto_utilizatori()
        {
            _utilizatori.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Nume, Email, Parola, DataInregistrare FROM Utilizatori";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nume = reader["Nume"].ToString();
                            string email = reader["Email"].ToString();
                            string parola = reader["Parola"].ToString();
                            string dataInregistrare = reader["DataInregistrare"].ToString();

                            Utilizatori utilizator = new Utilizatori(nume, email, parola, dataInregistrare);
                            _utilizatori.Add(utilizator);
                        }
                    }
                }
            }
        }

        public static void SaveToUtilizatoriDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand del = conn.CreateCommand())
                {
                    del.CommandText = "TRUNCATE TABLE Utilizatori";
                    del.ExecuteNonQuery();
                }

                string query = "INSERT INTO Utilizatori (Nume, Email, Parola, DataInregistrare) VALUES (?Nume, ?Email, ?Parola, ?DataInregistrare)";

                foreach (var utilizator in _utilizatori)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?Nume", utilizator.Nume);
                        cmd.Parameters.AddWithValue("?Email", utilizator.Email);
                        cmd.Parameters.AddWithValue("?Parola", utilizator.parola);
                        cmd.Parameters.AddWithValue("?DataInregistrare", utilizator.DataInregistrare);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
