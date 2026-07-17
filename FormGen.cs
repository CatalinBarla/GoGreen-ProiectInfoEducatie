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
    public partial class FormGen : Form
    {
        public FormGen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilizatori.gen = "F";
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilizatori.gen = "M";
            Close();
        }
    }
}
