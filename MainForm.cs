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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
           // System.Stop();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DDA dda_alg = new DDA();

            this.Hide();
            dda_alg.Show();

        }

        private void bresham_Click(object sender, EventArgs e)
        {
            Bresneham bres = new Bresneham();
            this.Hide();
             bres.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Circle circ = new Circle();
            this.Hide();
            circ.Show();
        }
    }
}
