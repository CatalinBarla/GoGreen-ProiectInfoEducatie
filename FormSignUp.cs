using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoGreen
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void chkAfiseazaParola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfiseazaParola.Checked)
            {
                tboxParola.PasswordChar = '\0';
                chkAfiseazaParola.Text = "👁";
            }
            else
            {
                tboxParola.PasswordChar = '*';
                chkAfiseazaParola.Text = "🙈";
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tboxEmail.Text == "" || tboxNume.Text == "" || tboxParola.Text == "")
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii!","Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (tboxParola.Text.Length < 6)
            {
                MessageBox.Show("Parola trebuie să aibă cel puțin 6 caractere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tboxEmail.Text.FirstOrDefault(c => c == '@') == default(char) || tboxEmail.Text.FirstOrDefault(c => c == '.') == default(char))
            {
                MessageBox.Show("Adresa de email nu este validă!","Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            string email = tboxEmail.Text;

            if (Utilizatori._utilizatori.Any(u => u.Email == email))
            {
                MessageBox.Show("Acest email este deja folosit!");
                return;
            }

            Utilizatori utilizator = new Utilizatori(tboxNume.Text, tboxEmail.Text, CripteazaParola(tboxParola.Text), DateTime.Now.ToString("dd/MM/yyyy"));
            Utilizatori._utilizatori.Add(utilizator);
            Utilizatori.utilizatorlogat = utilizator;
            Utilizatori.SaveToUtilizatoriDB();

            MessageBox.Show("Contul a fost creat cu succes!");
            this.Close();
        }
        private string CripteazaParola(string parolaBruta)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(parolaBruta);
                byte[] hashBytes = sha256Hash.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void FormSignUp_Load(object sender, EventArgs e)
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
        private void Culori_CuloriSchimbate(object sender, EventArgs e)
        {
            AplicaTemeCulori();
        }
    }
}
