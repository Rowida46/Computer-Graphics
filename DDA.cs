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

    public partial class DDA : Form
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



        public DDA()
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
