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
    public partial class Circle : Form
    {

        public void Circle_fun(int r,int xcenter , int ycenter ,  Bitmap pp )
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
            circle_pic.Image = pp;
        }


        public Circle()
        {
            InitializeComponent();
        }

        private void Circle_Load(object sender, EventArgs e)
        {

        }

        private void Start_Circle_Click(object sender, EventArgs e)
        {
            int r = int.Parse(raduis.Text);
            Bitmap pp = new Bitmap(circle_pic.Width, circle_pic.Height);


        }

        private void undo_circle_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mn = new MainForm();
            mn.Show();
      }
    }
}
