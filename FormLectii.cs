using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GoGreen
{
    public partial class FormLectii : Form
    {
        int capitol = 0, lectie = 0;
        string capn, lectn;
        bool lok = true;

        private bool[] Cap1 = new bool[10] { false, false, false, false, false, false, false, false, false, false };
        private bool[] Cap2 = new bool[10] { false, false, false, false, false, false, false, false, false, false };

        public FormLectii()
        {
            InitializeComponent();
            Intrebari.LoadInto_Intrebari();
        }

        private void ComutaCapitol(Panel panel)
        {
            if (panel.Size.Height == 40)
            {
                panel.Size = new Size(panel.Width, 200);
            }
            else
            {
                panel.Size = new Size(panel.Width, 40);
            }
        }

        private void btnCapitol1_Click(object sender, EventArgs e)
        {
            ComutaCapitol(panelCapitol1);
            
        }

        private void btnCapitol2_Click(object sender, EventArgs e)
        {
            ComutaCapitol(panelCapitol2);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(lok == false)
            {
                MessageBox.Show("Trebuie să finalizezi testul curent înainte de a continua!");
                return;
            }

            Button button = (Button)sender;
            capitol = int.Parse(button.Name[button.Name.Length - 1].ToString());
            lectie = int.Parse(button.Name[button.Name.Length - 5].ToString());

            capn = "C" + capitol.ToString();
            lectn = "L" + lectie.ToString();

            if(capitol == 1)
            {
                if (Cap1[lectie] == false)
                {
                    Cap1[lectie] = true;
                    progressBarCap1.Value += 25;
                }
            }
            else if(capitol == 2)
            {
                if (Cap2[lectie] == false)
                {
                    Cap2[lectie] = true;
                    progressBarCap2.Value += 25;
                }
            }

            LoadIntoTextBox();

            if(progressBarCap1.Value == 100 && progressBarCap2.Value == 100)
            {
                if (Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteLectii < 10)
                {
                    Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteLectii += 10;
                    MessageBox.Show("Ai obținut 10 puncte pentru lecții! Continuă să folosești aplicația pentru a obține mai multe!", "Felicitări!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Achievements.UpdateInBazaDeDate();
                }
            }
        }

        private void btnTestMare_Click(object sender, EventArgs e)
        {
            if (progressBarCap1.Value == progressBarCap1.Maximum && progressBarCap2.Value == progressBarCap2.Maximum)
            {
                FormTestMare formTestMare = new FormTestMare();
                this.Hide();
                formTestMare.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Trebuie să finalizezi toate lecțiile pentru a putea accesa testul final!");
            }
        }

        private void FormLectii_Load(object sender, EventArgs e)
        {
            AplicaTemeCulori();
            Culori.CuloriSchimbate += Culori_CuloriSchimbate;
        }

        private void AplicaTemeCulori()
        {
            this.BackColor = Culori.Backgroundcolor;
            foreach (Control c in this.Controls)
            {
                c.ForeColor = Culori.TextColor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Culori_CuloriSchimbate(object sender, EventArgs e)
        {
            AplicaTemeCulori();
        }

        private void LoadIntoTextBox()
        {
            string text = "";
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost;Database=database;Uid=root;Pwd=;"))
            {
                conn.Open();
                string query = "SELECT Text FROM Lectii WHERE Capitol = @capitol AND NumarLectie = @NumarLectie";
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Capitol", capitol);
                    cmd.Parameters.AddWithValue("@NumarLectie", lectie);
                    using (MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Citim textul nativ RTF salvat corect
                            string textBrut = reader["Text"].ToString();

                            // Îl trimitem direct proprietății .Rtf fără nicio altă modificare intermediară
                            richTextBox1.Rtf = textBrut;
                        }
                    }
                }
            }
        }
    }
}

