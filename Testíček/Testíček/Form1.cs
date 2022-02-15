using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testíček
{
    public partial class Form1 : Form
    {
        List<Kruhy> kruhy;
        public Form1()
        {
            InitializeComponent();
            kruhy = new List<Kruhy>();
            numSize.Maximum = 500;
            numSize.Value = 150;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Kruhy noveKruhy = new Kruhy();
            noveKruhy.Location = new Point(random.Next(0, pbox1.Width), random.Next(0, pbox1.Height));

            noveKruhy.Size = Convert.ToInt32(numSize.Value);
            noveKruhy.CircleColor1 = Aqua.BackColor;
            noveKruhy.CircleColor2 = Red.BackColor;
            noveKruhy.CircleColor3 = Green.BackColor;
            noveKruhy.CircleColor4 = Black.BackColor;
            noveKruhy.CircleColor5 = Yellow.BackColor;
            kruhy.Add(noveKruhy);
            pbox1.Refresh();
        }

        private void Aqua_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Aqua.BackColor;
            colorDialog1.ShowDialog();
            Aqua.BackColor = colorDialog1.Color;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Red.BackColor;
            colorDialog1.ShowDialog();
            Red.BackColor = colorDialog1.Color;
        }

        private void Black_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Black.BackColor;
            colorDialog1.ShowDialog();
            Black.BackColor = colorDialog1.Color;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Yellow.BackColor;
            colorDialog1.ShowDialog();
            Yellow.BackColor = colorDialog1.Color;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Green.BackColor;
            colorDialog1.ShowDialog();
            Green.BackColor = colorDialog1.Color;
        }

        private void pbox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var kruhy in kruhy)
            {
                kruhy.Draw(e.Graphics);
            }
        }
    }
}
