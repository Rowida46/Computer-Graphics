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
                pp.SetPixel((int)(Math.Round(x)), (int)(Math.Round(y)), Color.BlueViolet);
                x += inc_x;
                y += inc_y;

            }
            pictureBox1.Image = pp;
        }

        public void Circle_fun(int xc, int yc, int r, Bitmap pp)
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
                pp.SetPixel(xc + x, yc + y, Color.Red);
                pp.SetPixel(xc - x, yc - y, Color.Red);
                pp.SetPixel(xc + x, yc - y, Color.Red);
                pp.SetPixel(xc - x, yc + y, Color.Red);

                pp.SetPixel(xc + y, yc + x, Color.Red);
                pp.SetPixel(xc - y, yc - x, Color.Red);
                pp.SetPixel(xc + y, yc - x, Color.Red);
                pp.SetPixel(xc - y, yc + x, Color.Red);

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

        public void ellipse_fun(Bitmap bp, int xc, int yc, int rx, int ry)
        {
            // regoin 1
            double pp = (ry * ry) - (rx * rx * ry) + ((rx * rx) + 0.25);
            int p1 = (int)pp;
            int x = 0, y = ry;
            while ((2 * rx * rx * y) > (2 * ry * ry * x))
            {
                bp.SetPixel(xc + x, yc + y, Color.BlueViolet);
                bp.SetPixel(xc - x, yc - y, Color.BlueViolet);
                bp.SetPixel(xc - x, yc + y, Color.BlueViolet);
                bp.SetPixel(xc + x, yc - y, Color.BlueViolet);

                x++;

                if (p1 < 0)
                    p1 += (2 * ry * ry * x) + (ry * ry);
                else
                {
                    y--;
                    p1 += (2 * ry * ry * x) - (2 * rx * rx * y) + (ry * ry);
                }
            }

            // regoin 2
            pp = ((ry * ry) * (x + 0.5) * (x + 0.5)) + ((rx * rx) * (y - 1) * (y - 1)) - (rx * rx * ry * ry);
            int p2 = (int)pp;
            while (y >= 0)
            {
                bp.SetPixel(xc + x, yc + y, Color.Red);
                bp.SetPixel(xc - x, yc - y, Color.Red);
                bp.SetPixel(xc - x, yc + y, Color.Red);
                bp.SetPixel(xc + x, yc - y, Color.Red);

                y--;
                if (p2 > 0)
                    p2 -= (2 * rx * rx * y) + (rx * rx);
                else
                {
                    x++;
                    p2 += (2 * ry * ry * x) - (2 * rx * rx * y) + (rx * rx);
                }
            }
            pictureBox1.Image = bp;
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
            pictureBox1.Visible = true;

            Bitmap pp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            try
            {
                if (DDA.Checked)
                    DDA_fun(x1, x2, y1, y2, pp);

                if (bres.Checked)
                    bres_fun(x1, x2, y1, y2, pp);

                if (Elipse.Checked)
                    ellipse_fun(pp, x1, y1, x2, y2);

                if (circle.Checked)
                    Circle_fun(x1, y1 , x2 , pp);
            }

            catch (Exception ) { }


        }




        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            XAT.Clear();
            xbt.Clear();
            YAT.Clear();
            ybt.Clear();

            // pp.Image = New Bitmap(pp.ClientSize.Width, pp.ClientSize.Height)
            pictureBox1.Invalidate();




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

        }

        private void bres_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mn = new MainForm();
            mn.Show();
    }

        private void bunifuTileButton3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mn = new MainForm();
            mn.Show();
            
        
    }
    }
}
