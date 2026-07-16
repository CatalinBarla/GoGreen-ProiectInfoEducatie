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
    public partial class FormCalculatorCalorii : Form
    {
        public FormCalculatorCalorii()
        {
            InitializeComponent();
        }

        string text = "  Rata metabolismului bazal:    ";
        private void btnCalculeazaCalorii_Click(object sender, EventArgs e)
        {
            if (txtVarsta.Text != "" && txtKg.Text != "" && txtInaltime.Text != "")
            {
                int greutate = Convert.ToInt32(txtKg.Text);
                int inaltime = Convert.ToInt32(txtInaltime.Text);
                string gen = cbGen.SelectedItem.ToString();
                int varsta = Convert.ToInt32(txtVarsta.Text);
                string nivel_a = cbActivitate.SelectedItem.ToString();
                double BMR = 0, BMRFIN = 0;


                int index = nivel_a.IndexOf(':');
                if (index != -1)
                {
                    nivel_a = nivel_a.Substring(0, index);
                }

                var coeficienti = new Dictionary<string, double>
            {
                { "Sedentar", 1.2 },
                { "Moderat", 1.55 },
                { "Activ", 1.725 },
                { "Intens", 1.9 },
                { "Foarte Activ", 2.0 }
            };


                if (gen == "Masculin")
                {
                    BMR = 10 * greutate + 6.25 * inaltime - 5 * varsta + 5;
                }

                if (gen == "Feminin")
                {
                    BMR = 10 * greutate + 6.25 * inaltime - 5 * varsta - 161;
                }

                if (coeficienti.TryGetValue(nivel_a, out double coef))
                {
                    BMRFIN = BMR * coef;
                }

                BMRFIN = (int)Math.Round(BMRFIN);
                lblRezultat.Text = text + BMRFIN.ToString();

                if (Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteKcal < 15)
                {
                    Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteKcal += 5;
                    MessageBox.Show("Felicitări! Ai câștigat 5 puncte pentru calculul caloriilor!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Ai atins deja punctajul maxim pentru calculatorul de kcal.", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Achievements.UpdateInBazaDeDate();
            }
            else
            {
                MessageBox.Show("Completați toate câmpurile disponibile!", "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReseteaza_Click(object sender, EventArgs e)
        {
            txtInaltime.Text = txtKg.Text = txtVarsta.Text = "0";
            cbActivitate.Text = cbGen.Text = "";
            lblRezultat.Text = text;
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInstructiuni_Click(object sender, EventArgs e)
        {
            FormCalculatorCaloriiInstructiuni form = new FormCalculatorCaloriiInstructiuni();
            form.ShowDialog();
        }

        private void FormCalculatorCalorii_Load(object sender, EventArgs e)
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
