using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GoGreen
{
    internal class Achievements
    {
        public int PuncteCarbon;
        public int PuncteKcal;
        public int PunctePoster;
        public int PuncteLectii;
        public int PuncteMeteo;
        public int PuncteCulori;
        public string EmailUtilizator;

        public static List<Achievements> _achievements = new List<Achievements>();
        public static Achievements GetAchievementsByEmail(string email)
        {
            return _achievements.FirstOrDefault(a => a.EmailUtilizator == email);
        }

        private static string connectionString = "Server=localhost;Database=database;Uid=root;Pwd=;";

        // Constructor public (Pentru înregistrări NOI)
        public Achievements(int puncteCarbon, int puncteKcal, int punctePoster, int puncteLectii, int puncteMeteo, int puncteCulori, string email)
        {
            PuncteCarbon = puncteCarbon;
            PuncteKcal = puncteKcal;
            PunctePoster = punctePoster;
            PuncteLectii = puncteLectii;
            PuncteMeteo = puncteMeteo;
            PuncteCulori = puncteCulori;
            EmailUtilizator = email;

            _achievements.Add(this);

            SalveazaInBazaDeDate();
        }

        private Achievements(int puncteCarbon, int puncteKcal, int punctePoster, int puncteLectii, int puncteMeteo, int puncteCulori, string email, bool vineDinBazaDeDate)
        {
            PuncteCarbon = puncteCarbon;
            PuncteKcal = puncteKcal;
            PunctePoster = punctePoster;
            PuncteLectii = puncteLectii;
            PuncteMeteo = puncteMeteo;
            PuncteCulori = puncteCulori;
            EmailUtilizator = email;

            _achievements.Add(this);
        }

        private void SalveazaInBazaDeDate()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO achievements 
                                    (PuncteCarbon, PuncteKcal, PunctePoster, PuncteLectii, PuncteMeteo, PuncteCulori, EmailUtilizator) 
                                    VALUES 
                                    (@carbon, @kcal, @poster, @lectii, @meteo, @culori, @email)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@carbon", this.PuncteCarbon);
                        cmd.Parameters.AddWithValue("@kcal", this.PuncteKcal);
                        cmd.Parameters.AddWithValue("@poster", this.PunctePoster);
                        cmd.Parameters.AddWithValue("@lectii", this.PuncteLectii);
                        cmd.Parameters.AddWithValue("@meteo", this.PuncteMeteo);
                        cmd.Parameters.AddWithValue("@culori", this.PuncteCulori);
                        cmd.Parameters.AddWithValue("@email", this.EmailUtilizator);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Eroare la salvarea realizărilor în baza de date: " + ex.Message);
            }
        }
        public static void UpdateInBazaDeDate()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    Achievements achievements = GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email);

                    string query = @"UPDATE achievements 
                                    SET PuncteCarbon = @carbon, 
                                        PuncteKcal = @kcal, 
                                        PunctePoster = @poster, 
                                        PuncteLectii = @lectii, 
                                        PuncteMeteo = @meteo, 
                                        PuncteCulori = @culori 
                                    WHERE EmailUtilizator = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@carbon", achievements.PuncteCarbon);
                        cmd.Parameters.AddWithValue("@kcal", achievements.PuncteKcal);
                        cmd.Parameters.AddWithValue("@poster", achievements.PunctePoster);
                        cmd.Parameters.AddWithValue("@lectii", achievements.PuncteLectii);
                        cmd.Parameters.AddWithValue("@meteo", achievements.PuncteMeteo);
                        cmd.Parameters.AddWithValue("@culori", achievements.PuncteCulori);
                        cmd.Parameters.AddWithValue("@email", Utilizatori.utilizatorlogat.Email);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Eroare la actualizarea realizărilor în baza de date: " + ex.Message);
            }
        }

        // FUNCȚIA DE ÎNCĂRCARE
        public static void LoadIntoList()
        {
            try
            {
                _achievements.Clear();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT PuncteCarbon, PuncteKcal, PunctePoster, PuncteLectii, PuncteMeteo, PuncteCulori, EmailUtilizator FROM achievements";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int carbon = Convert.ToInt32(reader["PuncteCarbon"]);
                                int kcal = Convert.ToInt32(reader["PuncteKcal"]);
                                int poster = Convert.ToInt32(reader["PunctePoster"]);
                                int lectii = Convert.ToInt32(reader["PuncteLectii"]);
                                int meteo = Convert.ToInt32(reader["PuncteMeteo"]);
                                int culori = Convert.ToInt32(reader["PuncteCulori"]);
                                string email = reader["EmailUtilizator"].ToString();

                                new Achievements(carbon, kcal, poster, lectii, meteo, culori, email, true);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Eroare la încărcarea realizărilor din baza de date: " + ex.Message);
            }
        }
        public static Achievements GetByEmail(string email)
        {
            return _achievements.FirstOrDefault(a => a.EmailUtilizator.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
    }
}
