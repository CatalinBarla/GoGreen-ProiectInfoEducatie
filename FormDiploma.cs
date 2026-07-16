using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoGreen
{
    public partial class FormDiploma : Form
    {
        public FormDiploma()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(Utilizatori.utilizatorlogat == null)
            {
                Utilizatori.utilizatorlogat = new Utilizatori("Nume", "Email", "Parola", DateTime.Today.ToString("dd/MM/yyyy"));
            }
            Graphics g = e.Graphics;
            g.DrawString(Utilizatori.utilizatorlogat.Nume, new Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new PointF(135, 172));
        }

        private void FormDiploma_Load(object sender, EventArgs e)
        {

        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Nu există nicio diplomă încărcată pentru a fi printată.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (PrintDocument pd = new PrintDocument())
            {
                pd.DefaultPageSettings.Landscape = true;

                pd.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);

                pd.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

                using (PrintDialog printDialog = new PrintDialog())
                {
                    printDialog.Document = pd;

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        pd.Print();
                    }
                }
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image img = pictureBox1.Image;

            Rectangle marginBounds = e.MarginBounds;
            float imgRatio = (float)img.Width / img.Height;
            float pageRatio = (float)marginBounds.Width / marginBounds.Height;

            int printWidth, printHeight;

            if (imgRatio > pageRatio)
            {
                printWidth = marginBounds.Width;
                printHeight = (int)(marginBounds.Width / imgRatio);
            }
            else
            {
                printHeight = marginBounds.Height;
                printWidth = (int)(marginBounds.Height * imgRatio);
            }

            int x = marginBounds.X + (marginBounds.Width - printWidth) / 2;
            int y = marginBounds.Y + (marginBounds.Height - printHeight) / 2;

            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            e.Graphics.DrawImage(img, new Rectangle(x, y, printWidth, printHeight));

            float scaleX = (float)printWidth / img.Width;
            float scaleY = (float)printHeight / img.Height;

            float textX = x + (135 * scaleX);
            float textY = y + (172 * scaleY);

            float scaledFontSize = 16 * scaleY;

            using (Font fontDiploma = new Font("Century Gothic", scaledFontSize, FontStyle.Bold))
            {
                e.Graphics.DrawString(Utilizatori.utilizatorlogat.Nume, fontDiploma, Brushes.Black, new PointF(textX, textY));
            }
        }
    }
}
