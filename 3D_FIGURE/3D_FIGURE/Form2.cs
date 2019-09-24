using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_FIGURE
{
    public partial class Form2 : Form
    {

        public Graphics g;
        public Pen p = new Pen(Color.Black);
        public Point beg;
        public Bitmap map;
        public int Width = 440, Heigth = 440, X, Y, Size, at = 0, bt = 0, ct = 0, Z;
        public figure square;
        bool k;
        Form1 f1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            f1.Start();
            f1.pictureBox1.Refresh();
            f1.StartSqure();
            //f1.Size = f1.trackBar1.Value;
            f1.Draw_figure();

        }
    }
}
