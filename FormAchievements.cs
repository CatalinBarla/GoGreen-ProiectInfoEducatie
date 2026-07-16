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
    public partial class FormAchievements : Form
    {
        public FormAchievements()
        {
            InitializeComponent();
        }

        private void FormAchievements_Load(object sender, EventArgs e)
        {
            AplicaTemeCulori();
            Culori.CuloriSchimbate += Culori_CuloriSchimbate;

            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is Panel)
                {
                    Panel pnl = (Panel)ctrl;

                    if (pnl.Name == "pnlCarbon")
                    {
                        if (Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteCarbon != 15)
                        {
                            pnl.Visible = false;
                        }
                    }

                    if (pnl.Name == "pnlCulori")
                    {
                        if (Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteCulori != 15)
                        {
                            pnl.Visible = false;
                        }
                    }

                    if (pnl.Name == "pnlKcal")
                    {
                        if (Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteKcal != 15)
                        {
                            pnl.Visible = false;
                        }
                    }

                    if (pnl.Name == "pnlMeteo")
                    {
                        if (Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteMeteo != 15)
                        {
                            pnl.Visible = false;
                        }
                    }

                    if (pnl.Name == "pnlPoster")
                    {
                        if (Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PunctePoster != 20)
                        {
                            pnl.Visible = false;
                        }
                    }

                    if (pnl.Name == "pnlLectii")
                    {
                        if (Achievements.GetAchievementsByEmail(Utilizatori.utilizatorlogat.Email).PuncteLectii != 10)
                        {
                            pnl.Visible = false;
                        }
                    }
                }
                
            }
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

        private void btnAchievements_Click(object sender, EventArgs e)
        {
            if (pnlCarbon.Visible && pnlCulori.Visible && pnlKcal.Visible && pnlLectii.Visible && pnlMeteo.Visible && pnlPoster.Visible)
            {
                FormDiploma op = new FormDiploma();
                Hide(); op.ShowDialog(); Show();

            }
            else
            {
                MessageBox.Show("Nu ai câștigat toate realizările posibile. Continuă să explorezi aplicația pentru a le obține!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
