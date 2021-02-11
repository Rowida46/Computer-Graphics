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
    public partial class Bresneham : Form
    {
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
            bres_pic.Image = pp;
        }





        public Bresneham()
        {
            InitializeComponent();
        }

        private void Bres_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(XATbres.Text);
            int x2 = int.Parse(xbtbres.Text);
            int y1 = int.Parse(yatbres.Text);
            int y2 = int.Parse(ybtbres.Text);

            //bres.Text = x2.ToString();

            Bitmap pp = new Bitmap(bres_pic.Width , bres_pic.Height);
            bres_fun(x1, x2, y1, y2, pp);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mn = new MainForm();
            mn.Show();
        }

        private void xbbres_Click(object sender, EventArgs e)
        {

        }

        private void xbtbres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
