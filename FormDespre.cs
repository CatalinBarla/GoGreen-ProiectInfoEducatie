using System;
using System.Drawing;
using System.Windows.Forms;

namespace GoGreen
{
    public partial class FormDespre : Form
    {
        public FormDespre()
        {
            InitializeComponent();

            this.Size = new Size(850, 550);
            this.Text = "Despre Autori - GoGreen";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = Color.LightBlue;

            ConstruiesteInterfataDespre();
        }

        private void ConstruiesteInterfataDespre()
        {
            Label lblTitlu = new Label();
            lblTitlu.Text = "Echipa din spatele proiectului GoGreen";
            lblTitlu.Font = new Font("Century Gothic", 18, FontStyle.Bold);
            lblTitlu.ForeColor = Color.DarkSlateGray;
            lblTitlu.AutoSize = true;
            lblTitlu.Location = new Point((this.ClientSize.Width - 480) / 2, 25);
            this.Controls.Add(lblTitlu);

            Panel panelMembru1 = new Panel();
            panelMembru1.Size = new Size(360, 360);
            panelMembru1.Location = new Point(40, 80);
            panelMembru1.BackColor = Color.FromArgb(240, 248, 255);
            panelMembru1.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panelMembru1);

            PictureBox pbMembru1 = new PictureBox();
            pbMembru1.Size = new Size(100, 100);
            pbMembru1.Location = new Point(130, 20);
            pbMembru1.SizeMode = PictureBoxSizeMode.Zoom;
            pbMembru1.BackColor = Color.MediumSeaGreen;
            pbMembru1.Image = Image.FromFile("res/Imagini/catalin.jpg");
            panelMembru1.Controls.Add(pbMembru1);

            Label lblNume1 = new Label();
            lblNume1.Text = "Barla Catalin-Dorin";
            lblNume1.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            lblNume1.ForeColor = Color.SaddleBrown;
            lblNume1.TextAlign = ContentAlignment.MiddleCenter;
            lblNume1.Size = new Size(340, 30);
            lblNume1.Location = new Point(10, 135);
            panelMembru1.Controls.Add(lblNume1);

            Label lblRol1 = new Label();
            lblRol1.Text = "Rol: Lead Developer / Designer Jocuri si Logica acestora";
            lblRol1.Font = new Font("Century Gothic", 10, FontStyle.Italic | FontStyle.Bold);
            lblRol1.ForeColor = Color.DarkSlateGray;
            lblRol1.TextAlign = ContentAlignment.MiddleCenter;
            lblRol1.Size = new Size(340, 20);
            lblRol1.Location = new Point(10, 165);
            panelMembru1.Controls.Add(lblRol1);

            Label lblDescriere1 = new Label();
            lblDescriere1.Text = "Ma consider un elev pasionat de tehnologie, cu o dedicare deosebită pentru dezvoltarea aplicațiilor interactive și dezvoltarea jocurilor video.";
            lblDescriere1.Font = new Font("Century Gothic", 10);
            lblDescriere1.ForeColor = Color.Black;
            lblDescriere1.TextAlign = ContentAlignment.TopCenter;
            lblDescriere1.Size = new Size(320, 140);
            lblDescriere1.Location = new Point(20, 200);
            panelMembru1.Controls.Add(lblDescriere1);

            Panel panelMembru2 = new Panel();
            panelMembru2.Size = new Size(360, 360);
            panelMembru2.Location = new Point(430, 80);
            panelMembru2.BackColor = Color.FromArgb(240, 248, 255);
            panelMembru2.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panelMembru2);

            PictureBox pbMembru2 = new PictureBox();
            pbMembru2.Size = new Size(100, 100);
            pbMembru2.Location = new Point(130, 20);
            pbMembru2.SizeMode = PictureBoxSizeMode.Zoom;
            pbMembru2.Image = Image.FromFile("res/Imagini/andrei.jpeg");
            pbMembru2.BackColor = Color.DarkCyan;
            panelMembru2.Controls.Add(pbMembru2);

            Label lblNume2 = new Label();
            lblNume2.Text = "Satmar Andrei";
            lblNume2.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            lblNume2.ForeColor = Color.SaddleBrown;
            lblNume2.TextAlign = ContentAlignment.MiddleCenter;
            lblNume2.Size = new Size(340, 30);
            lblNume2.Location = new Point(10, 135);
            panelMembru2.Controls.Add(lblNume2);

            Label lblRol2 = new Label();
            lblRol2.Text = "Rol: 2nd Leader / Designer Lectii si Teste";
            lblRol2.Font = new Font("Century Gothic", 10, FontStyle.Italic | FontStyle.Bold);
            lblRol2.ForeColor = Color.DarkSlateGray;
            lblRol2.TextAlign = ContentAlignment.MiddleCenter;
            lblRol2.Size = new Size(340, 20);
            lblRol2.Location = new Point(10, 165);
            panelMembru2.Controls.Add(lblRol2);

            Label lblDescriere2 = new Label();
            lblDescriere2.Text = "Responsabil cu structurarea materialelor educaționale pentru Săptămâna Verde. Am gestionat colectarea întrebărilor de test, redactarea informațiilor despre migrația păsărilor din fișierele text de resurse și optimizarea conținutului ecologic integrat în platformă.";
            lblDescriere2.Font = new Font("Century Gothic", 10);
            lblDescriere2.ForeColor = Color.Black;
            lblDescriere2.TextAlign = ContentAlignment.TopCenter;
            lblDescriere2.Size = new Size(320, 140);
            lblDescriere2.Location = new Point(20, 200);
            panelMembru2.Controls.Add(lblDescriere2);

            Button btnInchide = new Button();
            btnInchide.Text = "Înapoi la Meniu";
            btnInchide.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            btnInchide.Size = new Size(180, 40);
            btnInchide.Location = new Point((this.ClientSize.Width - btnInchide.Width) / 2, 465);
            btnInchide.BackColor = Color.White;
            btnInchide.Cursor = Cursors.Hand;
            btnInchide.Click += (s, e) => { this.Close(); };
            this.Controls.Add(btnInchide);
        }
    }
}