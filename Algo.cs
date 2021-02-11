using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Computer_graphics
{

    public partial class Algo : Form
    {
        public void DDA_fun(int x1, int x2, int y1, int y2, Bitmap pp)
        {

            int dx = x1 - x2;
            int dy = y1 - y2;
            float steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float inc_x = dx / steps;
            float inc_y = dy / steps;
            // Bitmap pp = new Bitmap(pictureBox1.Width , pictureBox1.Height);
            float x = x1, y = y1;

            for (int i = 0; i < steps; i++)
            {
                pp.SetPixel((int)(Math.Round(x)), (int)(Math.Round(y)), Color.DarkBlue);
                x += inc_x;
                y += inc_y;

            }
            pictureBox1.Image = pp;
        }



        public void Circle_fun(int r, int xcenter, int ycenter, Bitmap pp)
        {
            int x = 0;
            int y = r;
            int p = 1 - r;

            while (x < r)
            {
                //pp.SetPixel(x, y, Color.DarkBlue);
                x += 1;
                if (p < 0)
                    p += (2 * x + 1);

                else
                {
                    y -= 1;
                    p += (2 * (x - y) + 1);
                }

            }
            pictureBox1.Image = pp;
        }

        public void bres_fun(int x1, int x2, int y1, int y2, Bitmap pp)
        {
            int dx = Math.Abs(x1 - x2);
            int dy = Math.Abs(y1 - y2);
            int x, xend, y;

            int p = 2 * dy - dx;
            int d2 = 2 * dy, dw2 = 2 * (dy - dx);

            if (x1 > x2)
            {
                x = x2; xend = x1; y = y2;
            }

            else
            {
                x = x1; xend = x2; y = y1;
            }

            while (x < xend)
            {
                pp.SetPixel(x, y, Color.DarkBlue);
                x += 1;

                if (p < 0)
                    p += d2;

                else
                {
                    y += 1;
                    p += dw2;
                }

            }
            pictureBox1.Image = pp;
        }

        public Algo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Run_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(XAT.Text);
            int x2 = int.Parse(xbt.Text);
            int y1 = int.Parse(YAT.Text);
            int y2 = int.Parse(ybt.Text);


            Bitmap pp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            DDA_fun(x1, x2, y1, y2, pp);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mn = new MainForm();
            mn.Show();
        }
    }
}
