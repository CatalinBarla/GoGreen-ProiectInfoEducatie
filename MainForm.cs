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
    public partial class MainForm : Form
    {
        public static string connectionString = "Server=localhost;Database=database;Uid=root;Pwd=;";
        public MainForm()
        {
            InitializeComponent();
            Utilizatori.LoadInto_utilizatori();
            Achievements.LoadIntoList();
            IncarcaFormularInPanel(new FormLogin());
        }
        public void IncarcaFormularInPanel(Form formularNou)
        {
            while (panelCentral.Controls.Count > 0)
            {
                panelCentral.Controls.RemoveAt(0);
            }

            if (formularNou is FormLogin loginForm)
            {
                loginForm.LoginSucces += LoginForm_LoginSucces;
                loginForm.SignUpIncarcat += LoginForm_SignUpIncarcat;
            }

            formularNou.TopLevel = false;
            formularNou.FormBorderStyle = FormBorderStyle.None;
            formularNou.Dock = DockStyle.Fill;

            this.panelCentral.Controls.Add(formularNou);
            this.panelCentral.Tag = formularNou;
            formularNou.Show();
        }

        private void LoginForm_SignUpIncarcat(object sender, EventArgs e)
        {
            IncarcaFormularInPanel(new FormSignUp());
        }
        private void LoginForm_LoginSucces(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;

        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblStangaClick(object sender, EventArgs e)
        {

        }

        private void btnDelogare_Click(object sender, EventArgs e)
        {
            if (Utilizatori.utilizatorlogat == null)
            {
                MessageBox.Show("Nu există niciun utilizator logat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Sunteți sigur că doriți să vă delogați?", "Confirmare delogare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Utilizatori.utilizatorlogat = null;
                IncarcaFormularInPanel(new FormLogin());

                Culori.Backgroundcolor = Culori.DefaultColor;
                Culori.TextColor = Color.Black;
                Utilizatori.gen = null;
            }
        }

        private void lblLectii_Click(object sender, EventArgs e)
        {
            if (Utilizatori.utilizatorlogat != null)
            {
                FormLectii op = new FormLectii();
                Hide(); op.ShowDialog(); Show();
            }
            else
            {
                MessageBox.Show("Va rugam sa va logati pentru a accesa aceasta sectiune.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Utilizatori.utilizatorlogat == null)
            {
                MessageBox.Show("Nu există niciun utilizator logat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IncarcaFormularInPanel(new FormLogin());
        }

        private void btnCalculatorCarbon_Click(object sender, EventArgs e)
        {
            if (Utilizatori.utilizatorlogat == null)
            {
                MessageBox.Show("Nu există niciun utilizator logat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IncarcaFormularInPanel(new FormCarbon());
        }

        private void btnCalculatorKcal_Click(object sender, EventArgs e)
        {
            if (Utilizatori.utilizatorlogat == null)
            {
                MessageBox.Show("Nu există niciun utilizator logat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IncarcaFormularInPanel(new FormCalculatorCalorii());
        }

        private void btnPoster_Click(object sender, EventArgs e)
        {
            if (Utilizatori.utilizatorlogat == null)
            {
                MessageBox.Show("Nu există niciun utilizator logat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           IncarcaFormularInPanel(new FormAfis());
        }

        private void btnLectii_Click(object sender, EventArgs e)
        {
            if (Utilizatori.utilizatorlogat == null)
            {
                MessageBox.Show("Nu există niciun utilizator logat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormLectii op = new FormLectii();
            Hide(); op.ShowDialog(); Show();
        }

        private void btnMeteo_Click(object sender, EventArgs e)
        {
            if (Utilizatori.utilizatorlogat == null)
            {
                MessageBox.Show("Nu există niciun utilizator logat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormMeteo op = new FormMeteo();
            Hide(); op.ShowDialog(); Show();
        }

        private void btnCulori_Click(object sender, EventArgs e)
        {
            FormSelectareCulori op = new FormSelectareCulori();
            op.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AplicaTemeCulori();
            Culori.CuloriSchimbate += Culori_CuloriSchimbate;
        }
        private void AplicaTemeCulori()
        {
            panelCentral.BackColor = Culori.Backgroundcolor;
            foreach (Control c in panelCentral.Controls)
            {
                c.ForeColor = Culori.TextColor;
            }
        }
        private void Culori_CuloriSchimbate(object sender, EventArgs e)
        {
            AplicaTemeCulori();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDespre op = new FormDespre();
            op.ShowDialog();
        }

        private void btnAchievements_Click(object sender, EventArgs e)
        {
            if(Utilizatori.utilizatorlogat == null)
            {
                MessageBox.Show("Nu există niciun utilizator logat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormAchievements op = new FormAchievements();
            op.ShowDialog();
        }

        private void btnIntreabama_Click(object sender, EventArgs e)
        {
            if(Utilizatori.utilizatorlogat != null)
            {
                IncarcaFormularInPanel(new FormIntreaba_ma());
            }
        }
    }
}
