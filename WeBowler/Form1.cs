using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeBowler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private System.Drawing.Graphics g;
        private System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);

        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 2F);
        private void button1_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.DrawEllipse(pen1, 20, 20, 40, 40);
            g.DrawEllipse(pen1, 80, 20, 40, 40);
            g.DrawEllipse(pen1, 140, 20, 40, 40);
            g.DrawEllipse(pen1, 200, 20, 40, 40);
            g.DrawEllipse(pen1, 50, 80, 40, 40);
            g.DrawEllipse(pen1, 110, 80, 40, 40);
            g.DrawEllipse(pen1, 170, 80, 40, 40);
            g.DrawEllipse(pen1, 80, 140, 40, 40);
            g.DrawEllipse(pen1, 140, 140, 40, 40);
            g.DrawEllipse(pen1, 110, 200, 40, 40);

            g.DrawLine(pen1, 0, 500, 260, 500);
            g.FillEllipse(myBrush, new Rectangle(110, 480, 40, 40));
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            pictureBox1.Refresh();
            g.DrawEllipse(pen1, 20, 20, 40, 40);
            g.DrawEllipse(pen1, 80, 20, 40, 40);
            g.DrawEllipse(pen1, 140, 20, 40, 40);
            g.DrawEllipse(pen1, 200, 20, 40, 40);
            g.DrawEllipse(pen1, 50, 80, 40, 40);
            g.DrawEllipse(pen1, 110, 80, 40, 40);
            g.DrawEllipse(pen1, 170, 80, 40, 40);
            g.DrawEllipse(pen1, 80, 140, 40, 40);
            g.DrawEllipse(pen1, 140, 140, 40, 40);
            g.DrawEllipse(pen1, 110, 200, 40, 40);

            g.DrawLine(pen1, 0, 500, 260, 500);
            g.FillEllipse(myBrush, new Rectangle(e.X, 480, 40, 40));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
