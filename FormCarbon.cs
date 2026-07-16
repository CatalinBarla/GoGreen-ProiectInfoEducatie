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
    public partial class FormCarbon : Form
    {
        private const double EmissionFactorElectricity = 0.24;
        private const double EmissionFactorGas = 0.18;
        private const double EmissionFactorCar = 0.12;

        public FormCarbon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtElectricity.Text, out double electricity) ||
                !double.TryParse(txtGas.Text, out double gas) ||
                !double.TryParse(txtCar.Text, out double carDistance))
            {
                MessageBox.Show("Vă rugăm să introduceți valori numerice valide în toate câmpurile.",
                                "Eroare de validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double annualElectricityCO2 = electricity * 12 * EmissionFactorElectricity;
            double annualGasCO2 = gas * 12 * EmissionFactorGas;
            double annualCarCO2 = carDistance * 12 * EmissionFactorCar;

            double totalCarbonFootprint = annualElectricityCO2 + annualGasCO2 + annualCarCO2;

            lblResult.Text = $"Amprenta de carbon totală: {totalCarbonFootprint:N2} kg CO2/an\n" +
                             $"({(totalCarbonFootprint / 1000):N2} tone CO2/an)";

            if (Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteCarbon < 15)
            {
                Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteCarbon += 5;
                MessageBox.Show("Felicitări! Ai câștigat 5 puncte pentru amprenta de carbon!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ai atins deja punctajul maxim pentru amprenta de carbon.", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Achievements.UpdateInBazaDeDate();
        }

        private void txtElectricity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }
            TextBox txt = sender as TextBox;
            if (e.KeyChar == ',' && txt != null && !txt.Text.Contains(","))
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }

        private void FormCarbon_Load(object sender, EventArgs e)
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
