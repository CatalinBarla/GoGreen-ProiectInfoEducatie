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
using System.IO;

namespace GoGreen
{
    public partial class FormLogin : Form
    {
        public event EventHandler LoginSucces;
        public event EventHandler SignUpIncarcat;
        public FormLogin()
        {
            InitializeComponent();
            tboxEmail.Enter += tboxEmail_Enter;
            tboxEmail.Leave += tboxEmail_Leave;
            tboxParola.Enter += tboxParola_Enter;
            tboxParola.Leave += tboxParola_Leave;
            btnLogin.Click += btnLogin_Click;
            btnSignUp.Click += btnSignUp_Click;
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
            tboxEmail.Text = "";
            tboxEmail.ForeColor = Color.Black;
        }

        private void tboxEmail_Leave(object sender, EventArgs e)
        {
            if (tboxEmail.Text == "")
            {
                tboxEmail.Text = "Introduce-ti emailul dumneavoastra";
                tboxEmail.ForeColor = Color.Gray;
            }
        }

        private void tboxParola_Enter(object sender, EventArgs e)
        {
            tboxParola.Text = "";
            tboxParola.ForeColor = Color.Black;
            tboxParola.PasswordChar = '*';
        }

        private void tboxParola_Leave(object sender, EventArgs e)
        {
            if (tboxParola.Text == "")
            {
                tboxParola.Text = "Introduce-ti parola dumneavoastra";
                tboxParola.ForeColor = Color.Gray;
                tboxParola.PasswordChar = '\0';
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tboxEmail.Text;
            string parola = CripteazaParola(tboxParola.Text);

            Utilizatori utilizator = Utilizatori._utilizatori.FirstOrDefault(u => u.Email == email);

            if (utilizator == null)
            {
                MessageBox.Show("Email inexistent!");
                tboxEmail.Text = "Introduce-ti emailul dumneavoastra";
                tboxEmail.ForeColor = Color.Gray;
                tboxParola.Text = "Introduce-ti parola dumneavoastra";
                tboxParola.ForeColor = Color.Gray;
                tboxParola.PasswordChar = '\0';
                return;
            }

            if (utilizator.parola == parola)
            {
                MessageBox.Show("Login successful!");
                Utilizatori.utilizatorlogat = utilizator;
                LoginSucces?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                MessageBox.Show("Email sau parola incorecta!");
                tboxEmail.Text = "";
                tboxParola.Text = "";
                return;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        { 
            SignUpIncarcat?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
