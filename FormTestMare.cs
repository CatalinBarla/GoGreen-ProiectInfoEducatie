using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoGreen
{
    public partial class FormTestMare : Form
    {
        public FormTestMare()
        {
            InitializeComponent();

            rbVariantaA.CheckedChanged += RadioButtons_CheckedChanged;
            rbVariantaB.CheckedChanged += RadioButtons_CheckedChanged;
            rbVariantaC.CheckedChanged += RadioButtons_CheckedChanged;
        }

        private List<Intrebari> intrebariTestMare = new List<Intrebari>();
        private string[] raspunsuriUtilizator;
        private bool[] intrebareValidata = new bool[10];
        private int indexCurent = 0;

        private void FormTeste_Load(object sender, EventArgs e)
        {
            Intrebari.Randomise_List();

            this.Size = new System.Drawing.Size(1280, 720);

            pnlAlegere.Enabled = true;
            pnlAlegere.Visible = true;
            pnlAlegere.BringToFront();
            pnlAlegere.Location = new Point(186, 152);

            pnlZonaTest.Visible = false;
            pnlZonaTest.SendToBack();

            Intrebari.LoadInto_Intrebari();
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

        private void btnPornesteTest_Click(object sender, EventArgs e)
        {
            List<Intrebari> intrebariEligibile = new List<Intrebari>();

            if (chkCap1.Checked) intrebariEligibile.AddRange(Intrebari._intrebari.Where(q => q.Capitol == "C1"));
            if (chkCap2.Checked) intrebariEligibile.AddRange(Intrebari._intrebari.Where(q => q.Capitol == "C2"));

            if (intrebariEligibile.Count < 10)
            {
                MessageBox.Show($"Nu sunt destule întrebări în capitolele selectate! (Găsite: {intrebariEligibile.Count}, Necesare: 10)");
                return;
            }

            Random rng = new Random();
            intrebariTestMare = intrebariEligibile.OrderBy(x => rng.Next()).Take(10).ToList();

            raspunsuriUtilizator = new string[10];
            intrebareValidata = new bool[10];
            for (int i = 0; i < 10; i++)
            {
                raspunsuriUtilizator[i] = "";
                intrebareValidata[i] = false;
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;
            progressBar1.Value = 0;

            pnlAlegere.Visible = false;
            pnlZonaTest.Visible = true;
            pnlZonaTest.BringToFront();

            indexCurent = 0;
            AfiseazaIntrebare();
        }

        private void AfiseazaIntrebare()
        {
            if (indexCurent >= 0 && indexCurent < intrebariTestMare.Count)
            {
                Intrebari intrebare = intrebariTestMare[indexCurent];

                rbVariantaA.CheckedChanged -= RadioButtons_CheckedChanged;
                rbVariantaB.CheckedChanged -= RadioButtons_CheckedChanged;
                rbVariantaC.CheckedChanged -= RadioButtons_CheckedChanged;

                lblEnunt.Text = $"Întrebarea {indexCurent + 1}/10: {intrebare.Enunt}";
                rbVariantaA.Text = intrebare.RaspunsA;
                rbVariantaB.Text = intrebare.RaspunsB;
                rbVariantaC.Text = intrebare.RaspunsC;

                rbVariantaA.BackColor = Color.Transparent;
                rbVariantaB.BackColor = Color.Transparent;
                rbVariantaC.BackColor = Color.Transparent;

                string raspunsAnterior = raspunsuriUtilizator[indexCurent];
                if (raspunsAnterior == "a") rbVariantaA.Checked = true;
                else if (raspunsAnterior == "b") rbVariantaB.Checked = true;
                else if (raspunsAnterior == "c") rbVariantaC.Checked = true;
                else
                {
                    rbVariantaA.Checked = false;
                    rbVariantaB.Checked = false;
                    rbVariantaC.Checked = false;
                }

                rbVariantaA.CheckedChanged += RadioButtons_CheckedChanged;
                rbVariantaB.CheckedChanged += RadioButtons_CheckedChanged;
                rbVariantaC.CheckedChanged += RadioButtons_CheckedChanged;

                if (intrebareValidata[indexCurent])
                {
                    rbVariantaA.Enabled = false;
                    rbVariantaB.Enabled = false;
                    rbVariantaC.Enabled = false;
                    btnValideaza.Enabled = false;

                    ColoreazaRaspunsuri(intrebare.RaspunsCorect.Trim().ToLower());
                }
                else
                {
                    rbVariantaA.Enabled = true;
                    rbVariantaB.Enabled = true;
                    rbVariantaC.Enabled = true;

                    btnValideaza.Enabled = (raspunsAnterior != "");
                }

                btnInapoi.Enabled = (indexCurent > 0);
                btnInainte.Enabled = true;

                if (indexCurent == intrebariTestMare.Count - 1)
                {
                    btnInainte.Text = "Finalizează testul";
                }
                else
                {
                    btnInainte.Text = "Înainte";
                }

                ActualizeazaProgres();
            }
        }

        private void ColoreazaRaspunsuri(string raspunsCorect)
        {
            Color verdePastel = Color.FromArgb(198, 239, 206);
            Color rosuPastel = Color.FromArgb(255, 199, 206);

            rbVariantaA.BackColor = (raspunsCorect == "a") ? verdePastel : (rbVariantaA.Checked ? rosuPastel : Color.Transparent);
            rbVariantaB.BackColor = (raspunsCorect == "b") ? verdePastel : (rbVariantaB.Checked ? rosuPastel : Color.Transparent);
            rbVariantaC.BackColor = (raspunsCorect == "c") ? verdePastel : (rbVariantaC.Checked ? rosuPastel : Color.Transparent);
        }

        private void SalveazaRaspunsCurent()
        {
            if (indexCurent >= 0 && indexCurent < 10)
            {
                if (rbVariantaA.Checked)
                    raspunsuriUtilizator[indexCurent] = "a";
                else if (rbVariantaB.Checked)
                    raspunsuriUtilizator[indexCurent] = "b";
                else if (rbVariantaC.Checked)
                    raspunsuriUtilizator[indexCurent] = "c";
            }
        }

        private void ActualizeazaProgres()
        {
            int intrebariRespondate = raspunsuriUtilizator.Count(r => r != "");
            progressBar1.Value = intrebariRespondate;
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                SalveazaRaspunsCurent();
                btnValideaza.Enabled = true;
                ActualizeazaProgres();
            }
        }
        private void btnValideaza_Click(object sender, EventArgs e)
        {
            if (indexCurent >= 0 && indexCurent < intrebariTestMare.Count)
            {
                SalveazaRaspunsCurent();

                if (string.IsNullOrEmpty(raspunsuriUtilizator[indexCurent]))
                {
                    MessageBox.Show("Te rog să selectezi o variantă de răspuns înainte de a valida!");
                    return;
                }

                intrebareValidata[indexCurent] = true;

                Intrebari intrebare = intrebariTestMare[indexCurent];
                string raspunsCorect = intrebare.RaspunsCorect.Trim().ToLower();

                rbVariantaA.Enabled = false;
                rbVariantaB.Enabled = false;
                rbVariantaC.Enabled = false;
                btnValideaza.Enabled = false;

                ColoreazaRaspunsuri(raspunsCorect);
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            if (indexCurent > 0)
            {
                SalveazaRaspunsCurent();
                indexCurent--;
                AfiseazaIntrebare();
            }
        }

        private void btnInainte_Click(object sender, EventArgs e)
        {
            SalveazaRaspunsCurent();

            if (indexCurent < intrebariTestMare.Count - 1)
            {
                indexCurent++;
                AfiseazaIntrebare();
            }
            else
            {
                FinalizeazaTestul();
            }
        }

        private void FinalizeazaTestul()
        {
            int scor = 0;
            for (int i = 0; i < intrebariTestMare.Count; i++)
            {
                if (raspunsuriUtilizator[i] == intrebariTestMare[i].RaspunsCorect.Trim().ToLower())
                {
                    scor++;
                }
            }

            MessageBox.Show($"Testul a fost finalizat!\nAi răspuns corect la {scor} din 10 întrebări.", "Rezultat Final", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (scor >= 5)
            {
                if (Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteLectii == 10)
                {
                    Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteLectii += 10;
                    MessageBox.Show("Ai obținut 10 puncte pentru lecții! Continuă să folosești aplicația pentru a obține mai multe!", "Felicitări!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Achievements.UpdateInBazaDeDate();
                }     
            }

            pnlZonaTest.Visible = false;
            pnlAlegere.Visible = true;
            pnlAlegere.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
