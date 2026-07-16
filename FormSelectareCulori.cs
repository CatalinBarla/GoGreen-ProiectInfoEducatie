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
    public partial class FormSelectareCulori : Form
    {
        public FormSelectareCulori()
        {
            InitializeComponent();
        }

        private void FormSelectareCulori_Load(object sender, EventArgs e)
        {
            pbBackground.BackColor = Culori.Backgroundcolor;
            pbText.BackColor = Culori.TextColor;
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = Culori.Backgroundcolor;

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                Culori.Backgroundcolor = colorDialog.Color;
                pbBackground.BackColor = Culori.Backgroundcolor;
                Culori.NotificaSchimbare();

                if (Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteCulori < 15)
                {
                    Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteCulori += 5;
                    MessageBox.Show("Ai câștigat 5 puncte pentru personalizarea culorilor!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Ai atins deja punctajul maxim pentru culori.", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Achievements.UpdateInBazaDeDate();
            }
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = Culori.TextColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Culori.TextColor = colorDialog.Color;
                pbText.BackColor = Culori.TextColor;
                Culori.NotificaSchimbare();
            }
        }
    }
}
