using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GoGreen
{
    internal class Intrebari
    {
        public static List<Intrebari> _intrebari = new List<Intrebari>();

        public string Capitol;
        public string Lectie;
        public string Enunt;
        public string RaspunsA;
        public string RaspunsB;
        public string RaspunsC;
        public string RaspunsCorect;

        public static string connectionString = "Server=localhost;Database=database;Uid=root;Pwd=;";
        public static string filePath = Path.Combine(Application.StartupPath, "res", "Teste", "Toate.txt");


        public Intrebari(string capitol, string lectie, string enunt, string ra, string rb, string rc, string rcorect)
        {
            Capitol = capitol;
            Lectie = lectie;
            Enunt = enunt;
            RaspunsA = ra;
            RaspunsB = rb;
            RaspunsC = rc;
            RaspunsCorect = rcorect;
        }

        public static void LoadInto_Intrebari()
        {
            _intrebari.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Capitol, Lectie, Enunt, ra, rb, rc, RaspunsCorect FROM intrebari";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string capitol = reader["Capitol"].ToString();
                            string lectie = reader["Lectie"].ToString();
                            string enunt = reader["Enunt"].ToString();
                            string raspunsA = reader["ra"].ToString();
                            string raspunsB = reader["rb"].ToString();
                            string raspunsC = reader["rc"].ToString();
                            string raspunsCorect = reader["RaspunsCorect"].ToString();

                            Intrebari intrebare = new Intrebari(capitol, lectie, enunt, raspunsA, raspunsB, raspunsC, raspunsCorect);
                            _intrebari.Add(intrebare);
                        }
                    }
                }
            }
        }

        public static void LoadInto_IntrebariFromFile()
        {
            _intrebari.Clear();
            if (System.IO.File.Exists(filePath))
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 7)
                    {
                        Intrebari intrebare = new Intrebari(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]);
                        _intrebari.Add(intrebare);
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
                    del.CommandText = "TRUNCATE TABLE intrebari";
                    del.ExecuteNonQuery();
                }

                string query = "INSERT INTO intrebari (Capitol, Lectie, Enunt, ra, rb, rc, RaspunsCorect) VALUES (?Capitol, ?Lectie, ?Enunt, ?RaspunsA, ?RaspunsB, ?RaspunsC, ?RaspunsCorect)";

                foreach (var intrebare in _intrebari)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?Capitol", intrebare.Capitol);
                        cmd.Parameters.AddWithValue("?Lectie", intrebare.Lectie);
                        cmd.Parameters.AddWithValue("?Enunt", intrebare.Enunt);
                        cmd.Parameters.AddWithValue("?RaspunsA", intrebare.RaspunsA);
                        cmd.Parameters.AddWithValue("?RaspunsB", intrebare.RaspunsB);
                        cmd.Parameters.AddWithValue("?RaspunsC", intrebare.RaspunsC);
                        cmd.Parameters.AddWithValue("?RaspunsCorect", intrebare.RaspunsCorect);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


        public static void Randomise_List()
        {
            Random rand = new Random();
            for (int i = _intrebari.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                Intrebari temp = _intrebari[i];
                _intrebari[i] = _intrebari[j];
                _intrebari[j] = temp;
            }
        }
    }
}
