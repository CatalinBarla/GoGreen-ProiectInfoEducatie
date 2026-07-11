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
    public partial class FormLogin : Form
    {
        public event EventHandler LoginSucces;
        public event EventHandler SignUpIncarcat;

        private const string PlaceholderEmail = "Introduce-ti emailul dumneavoastra";
        private const string PlaceholderParola = "Introduce-ti parola dumneavoastra";

        public FormLogin()
        {
            InitializeComponent();
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
        private void tboxEmail_Enter(object sender, EventArgs e)
        {
            if (tboxEmail.Text == PlaceholderEmail)
            {
                tboxEmail.Text = "";
                tboxEmail.ForeColor = Culori.TextColor;
            }
        }

        private void tboxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tboxEmail.Text))
            {
                tboxEmail.Text = PlaceholderEmail;
                tboxEmail.ForeColor = Color.Gray;
            }
        }
        private void tboxParola_Enter(object sender, EventArgs e)
        {
            if (tboxParola.Text == PlaceholderParola)
            {
                tboxParola.Text = "";
                tboxParola.ForeColor = Culori.TextColor;
                tboxParola.PasswordChar = '*';
            }
        }

        private void tboxParola_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tboxParola.Text))
            {
                tboxParola.Text = PlaceholderParola;
                tboxParola.ForeColor = Color.Gray;
                tboxParola.PasswordChar = '\0';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailIntroduis = tboxEmail.Text.Trim();
            string parolaIntroduse = tboxParola.Text;

            if (emailIntroduis == PlaceholderEmail || string.IsNullOrWhiteSpace(emailIntroduis) ||
                parolaIntroduse == PlaceholderParola || string.IsNullOrWhiteSpace(parolaIntroduse))
            {
                MessageBox.Show("Vă rugăm să completați ambele câmpuri.", "Câmpuri incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Utilizatori.LoadInto_utilizatori();

                string parolaCriptata = CripteazaParola(parolaIntroduse);

                Utilizatori utilizatorGasit = Utilizatori._utilizatori.FirstOrDefault(u =>
                    string.Equals(u.Email, emailIntroduis, StringComparison.OrdinalIgnoreCase) &&
                    u.parola == parolaCriptata);

                if (utilizatorGasit != null)
                {
                    Utilizatori.utilizatorlogat = utilizatorGasit;

                    MessageBox.Show($"Autentificare reușită! Bine ai venit, {utilizatorGasit.Nume}!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginSucces?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Emailul sau parola introduse sunt incorecte.", "Eroare autentificare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la conectarea cu baza de date: {ex.Message}", "Eroare conexiune MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpIncarcat?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            AplicaTemeCulori();
            Culori.CuloriSchimbate += Culori_CuloriSchimbate;

            tboxEmail_Leave(null, null);
            tboxParola_Leave(null, null);
        }

        private void AplicaTemeCulori()
        {
            this.BackColor = Culori.Backgroundcolor;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt && (txt.Text == PlaceholderEmail || txt.Text == PlaceholderParola))
                {
                    txt.ForeColor = Color.Gray;
                }
                else
                {
                    c.ForeColor = Culori.TextColor;
                }
            }
        }

        private void Culori_CuloriSchimbate(object sender, EventArgs e)
        {
            AplicaTemeCulori();
        }
    }
}
