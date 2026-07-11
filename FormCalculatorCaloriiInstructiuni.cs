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
    public partial class FormCalculatorCaloriiInstructiuni : Form
    {
        public FormCalculatorCaloriiInstructiuni()
        {
            InitializeComponent();
        }

        private void lblInstructiuni_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCalculatorCaloriiInstructiuni_Load(object sender, EventArgs e)
        {
            AplicaTemeCulori();
            Culori.CuloriSchimbate += Culori_CuloriSchimbate;
        }
        private void AplicaTemeCulori()
        {
            pnlText.BackColor = Culori.Backgroundcolor;
            foreach (Control c in pnlText.Controls)
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
