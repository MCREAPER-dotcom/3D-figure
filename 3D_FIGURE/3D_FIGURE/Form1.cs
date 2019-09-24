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

    public partial class Form1 : Form
    {
        public Graphics g;
        public Pen p = new Pen(Color.Black);
        public SolidBrush BR;
        public Point beg;
        public Bitmap map;
        public int Width = 440, Heigth = 440, X, Y, Size, at = 0, bt = 0, ct = 0, Z;
        bool k,figT,figR;
        PointF p1 = new PointF();
        PointF p2 = new PointF();
        PointF p3 = new PointF();
        PointF p4 = new PointF();
        PointF p5 = new PointF();
        PointF p6 = new PointF();
        PointF p7 = new PointF();
        PointF p8 = new PointF();
        figure rec1;
        figure rec2;
        figure rec3;
        figure rec4;
        figure rec5;
        figure rec6;
        // Form2 f2 = new Form2();
        public Form1()
        {

            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            X = Width / 2;
            Y = Heigth / 2;
            k = true;
            figT = false;
            figR = true;
        }
        public void Start() {


        }
        public void Button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }


        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            Start();
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
            Z = X + Y;
        }

        public void StartSqure()
        {
            if (checkBox1.Checked == false) return;
            p = new Pen(Color.Black);
            g.DrawLine(p, 0, 0, 0, Heigth);
            g.DrawLine(p, 0, Heigth, Width, Heigth);
            g.DrawLine(p, Width, Heigth, Width, 0);
            g.DrawLine(p, Width, 0, 0, 0);
            g.DrawLine(p, 0, Heigth / 2, Width, Heigth / 2);
            g.DrawLine(p, Width / 2, 0, Width / 2, Heigth);
            g.DrawLine(p, 0, Heigth, Width, 0);
            for (int i = 0; i <= Width; i++)
                g.DrawLine(p, i += 10, Width / 2 - 5, i, Heigth / 2 + 5);
            for (int i = 0; i <= Heigth; i++)
                g.DrawLine(p, Width / 2 - 5, i += 10, Heigth / 2 + 5, i);
            int k = 0;
            for (k = 0; k <= Heigth; k += 10)
                g.DrawLine(p, 0 + k - 3, Heigth - k - 3, 0 + k + 3, Heigth - k + 3);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            at = Convert.ToInt32(numericUpDown1.Value) * 10;
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            bt = Convert.ToInt32(numericUpDown2.Value) * 10;
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
        }

        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            ct = Convert.ToInt32(numericUpDown3.Value) * 10;
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            Start();
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            trackBar2.Enabled = k;
            trackBar3.Enabled = k;
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
            k = !k;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
        }

        private float Start_X(float x)
        {
            return x + Width / 2;
        }

        private void TrackBar4_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            Start();
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
           // figR = !figR;
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox4.Checked = !checkBox4.Checked;
            pictureBox1.Refresh();
            StartSqure();
            Size = trackBar1.Value;
            Draw_figure();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            figT = !figT;
        }

        private float Start_Y(float y)
        {
            return ((-y + Heigth / 2));
        }
        public void Drawing(figure rec1, figure rec2, int size) {
            /////////////////////////////////////////////Квадрат  1
            p = new Pen(Color.Black);
            g.DrawLine(p,
                rec1.a.x,
                rec1.a.y,
                rec1.b.x,
                rec1.b.y - size
                );
            g.DrawLine(p,
                rec1.b.x,
                rec1.b.y - size,
                rec1.c.x - size,
                rec1.c.y - size
                );
            g.DrawLine(p,
                rec1.c.x - size,
                rec1.c.y - size,
                rec1.d.x - size,
                rec1.d.y
                );
            g.DrawLine(p,
                rec1.d.x - size,
                rec1.d.y,
                rec1.a.x,
                rec1.a.y
                );


            /////////////////////////////////////////////Квадрат  2

            g.DrawLine(p,
                rec2.a.x,
                rec2.a.y,
                rec2.b.x,
                rec2.b.y - size
                );
            g.DrawLine(p,
                rec2.b.x,
                rec2.b.y - size,
                rec2.c.x - size,
                rec2.c.y - size
                );
            g.DrawLine(p,
                rec2.c.x - size,
                rec2.c.y - size,
                rec2.d.x - size,
                rec2.d.y
                );
            g.DrawLine(p,
                rec2.d.x - size,
                rec2.d.y,
                rec2.a.x,
                rec2.a.y
                );


            /////////////////////////////////////////////Соеденение

            g.DrawLine(p,
               rec2.a.x,
                rec2.a.y,
                rec1.a.x,
                rec1.a.y
                );
            g.DrawLine(p,
                rec2.b.x,
                 rec2.b.y - size,
                rec1.b.x,
                rec1.b.y - size
                );
            g.DrawLine(p,
                 rec2.c.x - size,
                 rec2.c.y - size,
                 rec1.c.x - size,
                 rec1.c.y - size
                 );
            g.DrawLine(p,
                 rec2.d.x - size,
                 rec2.d.y,
                 rec1.d.x - size,
                 rec1.d.y
                 );
        }
        public byte Draw_figure()
        {
            //rotationX();

                rec1 = new figure(X, Y, at, bt, Size);
                rec2 = new figure(X + Size * 5 + ct, Y - Size * 5 - ct, at, bt, Size);
            

            rotation1(ref rec1, X, Y);
            rotation1(ref rec2, rec2.a.x + Size * 5, rec2.a.y + Size * 5);
            rotation2(ref rec1, X, Y);
            rotation2(ref rec2, rec2.a.x + Size * 5, rec2.a.y + Size * 5);
            if (checkBox2.Checked == true)
                FILLDRAWING(rec1, rec2);
            if (checkBox3.Checked == true)
                Drawing(rec1, rec2, 0);
            
                drawTSquare(rec1, rec2, trackBar4.Value, trackBar4.Value);
            return 0;
        }
        public void FILLFIGURE(point a, point b, point c, point d) {
            p1.X = a.x;
            p1.Y = a.y;
            p2.X = b.x;
            p2.Y = b.y;
            p3.X = c.x;
            p3.Y = c.y;
            p4.X = d.x;
            p4.Y = d.y;
        }
        public void rotation1(ref figure rec1, float XX, float YY)
        {
            double f = ((trackBar2.Value * 10) * Math.PI) / 180;
            rec1.a.copy(Convert.ToInt32((rec1.a.x - XX) * Math.Cos(f) - (rec1.a.y - YY) * Math.Sin(f) + XX), Convert.ToInt32((rec1.a.x - XX) * Math.Sin(f) + (rec1.a.y - YY) * Math.Cos(f) + YY));
            rec1.b.copy(Convert.ToInt32((rec1.b.x - XX) * Math.Cos(f) - (rec1.b.y - YY) * Math.Sin(f) + XX), Convert.ToInt32((rec1.b.x - XX) * Math.Sin(f) + (rec1.b.y - YY) * Math.Cos(f) + YY));
            rec1.c.copy(Convert.ToInt32((rec1.c.x - XX) * Math.Cos(f) - (rec1.c.y - YY) * Math.Sin(f) + XX), Convert.ToInt32((rec1.c.x - XX) * Math.Sin(f) + (rec1.c.y - YY) * Math.Cos(f) + YY));
            rec1.d.copy(Convert.ToInt32((rec1.d.x - XX) * Math.Cos(f) - (rec1.d.y - YY) * Math.Sin(f) + XX), Convert.ToInt32((rec1.d.x - XX) * Math.Sin(f) + (rec1.d.y - YY) * Math.Cos(f) + YY));
        }
        public void rotation2(ref figure rec1, float XX, float YY)
        {
            double f = ((trackBar3.Value * 10) * Math.PI) / 180;
            rec1.a.copy(Convert.ToInt32((rec1.a.x - XX) * Math.Cos(f) - (rec1.a.y - YY) * Math.Sin(f) + XX), Convert.ToInt32((rec1.a.x - XX) * Math.Sin(f) + (rec1.a.y - YY) * Math.Cos(f) + YY));
            rec1.b.copy(Convert.ToInt32((rec1.b.x - XX) * Math.Cos(f) - (rec1.b.y - YY) * Math.Sin(f) + XX), Convert.ToInt32((rec1.b.x - XX) * Math.Sin(f) + (rec1.b.y - YY) * Math.Cos(f) + YY));
            rec1.c.copy(Convert.ToInt32((rec1.c.x - XX) * Math.Cos(f) - (rec1.c.y - YY) * Math.Sin(f) + XX), Convert.ToInt32((rec1.c.x - XX) * Math.Sin(f) + (rec1.c.y - YY) * Math.Cos(f) + YY));
            rec1.d.copy(Convert.ToInt32((rec1.d.x - XX) * Math.Cos(f) - (rec1.d.y - YY) * Math.Sin(f) + XX), Convert.ToInt32((rec1.d.x - XX) * Math.Sin(f) + (rec1.d.y - YY) * Math.Cos(f) + YY));

        }
        public int drawTSquare(figure rec1, figure rec2, int iter, int xyz)
        {
            if (iter == 1)
                return 0;

            figure f1 = new figure(rec1, xyz);
            figure f2 = new figure(rec2, xyz);
            if (checkBox5.Checked == true)
                Drawing(f1, f2, iter);
            if(checkBox4.Checked==true)
            FILLDRAWING(rec1,rec2);


            drawTSquare(f1, f2, iter - 1, xyz);

            return 0;
        }
    
    public void FILLDRAWING(figure rec1,figure rec2) {


            Random rnd = new Random();
            int rr = rnd.Next(255);
            int gg = rnd.Next(255);
            int bb = rnd.Next(255);
            BR = new SolidBrush(Color.FromArgb(50, rr, gg, bb));
            rec3 = new figure(rec2.a, rec2.b, rec1.b, rec1.a);
            rec4 = new figure(rec2.d, rec1.d, rec1.a, rec2.a);
            rec5 = new figure(rec1.c, rec1.d, rec2.d, rec2.c);
            rec6 = new figure(rec1.b, rec1.c, rec2.c, rec2.b);


            /////////////////////////////////////////////Цвет

            // BR = new SolidBrush(Color.White);
            FILLFIGURE(rec2.a, rec2.b, rec2.c, rec2.d);
            PointF[] pt2 = { p1, p2, p3, p4 };
            g.FillPolygon(BR, pt2);

            // BR = new SolidBrush(Color.Blue);
            FILLFIGURE(rec3.a, rec3.b, rec3.c, rec3.d);
            PointF[] pt3 = { p1, p2, p3, p4 };
            g.FillPolygon(BR, pt3);


            // BR = new SolidBrush(Color.Blue);
            FILLFIGURE(rec4.a, rec4.b, rec4.c, rec4.d);
            PointF[] pt4 = { p1, p2, p3, p4 };
            g.FillPolygon(BR, pt4);
            // BR = new SolidBrush(Color.Green);
            FILLFIGURE(rec5.a, rec5.b, rec5.c, rec5.d);
            PointF[] pt5 = { p1, p2, p3, p4 };
            g.FillPolygon(BR, pt5);

            // BR = new SolidBrush(Color.Green);
            FILLFIGURE(rec6.a, rec6.b, rec6.c, rec6.d);
            PointF[] pt6 = { p1, p2, p3, p4 };
            g.FillPolygon(BR, pt6);





            // BR = new SolidBrush(Color.Red);
            FILLFIGURE(rec1.a, rec1.b, rec1.c, rec1.d);
            PointF[] pt1 = { p1, p2, p3, p4 };
            
                g.FillPolygon(BR, pt1);

        }
    }
}
