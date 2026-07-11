using MySqlX.XDevAPI.Common;
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
    public partial class FormAfis : Form
    {
        Image OriginalImage;
        string TipDecupaj = "None";
        int raza = 0;

        public FormAfis()
        {
            InitializeComponent();
        }

        private void FormAfis_Load(object sender, EventArgs e)
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

        private void btnIncarcaImagine_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                OriginalImage = Image.FromFile(filePath);
                pbOriginalImage.Image = OriginalImage;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipDecupaj = comboBox1.SelectedItem.ToString();
        }

        private void pbOriginalImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (pbOriginalImage.Image == null) return;

            if (TipDecupaj == "None")
            {
                MessageBox.Show("Selectați un tip de decupaj din lista derulantă.");
                return;
            }

            if(raza == 0)
            {
                MessageBox.Show("Introduceți o rază!");
                return;
            }

            // 1. Calculează raportul de scalare între imaginea reală și PictureBox
            float raportX = (float)pbOriginalImage.Image.Width / pbOriginalImage.Width;
            float raportY = (float)pbOriginalImage.Image.Height / pbOriginalImage.Height;

            // 2. Transformă coordonatele click-ului în pixeli reali ai imaginii
            int realCentruX = (int)(e.X * raportX);
            int realCentruY = (int)(e.Y * raportY);

            // 3. Scalează și raza pentru a păstra proporția dorită pe imaginea reală
            // Folosim raportX (sau o medie) pentru ca raza să se adapteze dimensiunii reale
            int razaReala = (int)(raza * raportX);
            int laturaReala = razaReala * 2;

            // 4. Definește zona de decupare pe imaginea reală
            Rectangle zonaDecupare = new Rectangle(realCentruX - razaReala, realCentruY - razaReala, laturaReala, laturaReala);

            // 5. Validare: Asigură-te că zona nu iese din marginile imaginii originale
            if (zonaDecupare.Left < 0) zonaDecupare.X = 0;
            if (zonaDecupare.Top < 0) zonaDecupare.Y = 0;
            if (zonaDecupare.Right > pbOriginalImage.Image.Width) zonaDecupare.Width = pbOriginalImage.Image.Width - zonaDecupare.X;
            if (zonaDecupare.Bottom > pbOriginalImage.Image.Height) zonaDecupare.Height = pbOriginalImage.Image.Height - zonaDecupare.Y;

            // Dacă zona validată a devenit prea mică sau invalidă, oprim execuția
            if (zonaDecupare.Width <= 0 || zonaDecupare.Height <= 0) return;

            // 6. Creează bitmap-ul final (folosim dimensiunile reale rezultate)
            Bitmap imagineDecupata = new Bitmap(zonaDecupare.Width, zonaDecupare.Height);

            using (Graphics g = Graphics.FromImage(imagineDecupata))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                if (TipDecupaj == "Cerc")
                {
                    System.Drawing.Drawing2D.GraphicsPath caleCirculara = new System.Drawing.Drawing2D.GraphicsPath();
                    caleCirculara.AddEllipse(0, 0, zonaDecupare.Width, zonaDecupare.Height);
                    g.SetClip(caleCirculara);
                }

                // Desenăm decupajul folosind coordonatele reale corectate
                g.DrawImage(pbOriginalImage.Image,
                           new Rectangle(0, 0, zonaDecupare.Width, zonaDecupare.Height),
                           zonaDecupare,
                           GraphicsUnit.Pixel);
            }

            pbPreview.Image = imagineDecupata;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (char c in tboxRaza.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Raza trebuie sa fie un numar intreg pozitiv.");
                    return;
                }
            }

            int razaa = int.Parse(tboxRaza.Text);
            if (razaa > 0 && razaa < 1000)
            {
                raza = razaa;
            }
            else
            {
                MessageBox.Show("Raza trebuie sa fie cuprinsa intre 1 si 999.");
                return;
            }
        }

        int scaleX = 0, scaleY = 0;

        private void pbAfis_MouseClick(object sender, MouseEventArgs e)
        {
            if (pbPreview.Image == null) return;

            if(scaleX == 0)
            {
                MessageBox.Show("Introduce-ti scaleul!");
                return;
            }

            Image nouaStampila = pbPreview.Image;
            int latimeNoua = (int)(nouaStampila.Width * (scaleX/100f));
            int inaltimeNoua = (int)(nouaStampila.Height * (scaleY/100f));

            Bitmap canvas = pbAfis.Image as Bitmap;
            if (canvas == null)
            {
                canvas = new Bitmap(pbAfis.Width, pbAfis.Height);
                using (Graphics gInit = Graphics.FromImage(canvas)) { gInit.Clear(Color.White); }
            }

            // 2. Calculăm poziția astfel încât click-ul să fie centrul noii imagini MICȘORATE
            int xTopLeft = e.X - (latimeNoua / 2);
            int yTopLeft = e.Y - (inaltimeNoua / 2);

            using (Graphics g = Graphics.FromImage(canvas))
            {
                // Setări pentru o redimensionare clară și fină, fără pixeli zimțați
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // 3. Desenăm imaginea specificând noua lățime și înălțime reduse
                g.DrawImage(nouaStampila, xTopLeft, yTopLeft, latimeNoua, inaltimeNoua);
            }

            pbAfis.Image = canvas;
            pbAfis.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(char c in textBox1.Text)
            {
                if(!char.IsDigit(c))
                {
                    MessageBox.Show("Procentul trebuie sa fie intre 1 si 100");
                    return;
                }
            }

     

            int scale = int.Parse(textBox1.Text);

            if(scale > 0 && scale < 101)
            {
                scaleX = scale;
                scaleY = scale;
            }
            else
            {
                MessageBox.Show("Procentul trebuie sa fie intre 1 si 100");
                return;
            }
        }

        private void btnSalveazaAfis_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            DialogResult result = sfd.ShowDialog();
            if(result == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                pbAfis.Image.Save(filePath);
            }
        }
    }
}
