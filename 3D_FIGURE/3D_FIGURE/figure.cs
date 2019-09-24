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
    public class figure
    {
       public point a = new point();
        public point b = new point();
        public point c = new point();
        public point d = new point();
        public figure()
        {
            a.x = 0;
            a.y = 0;
            b.x = 0;
            b.y = 0;
            c.x = 0;
            c.y = 0;
            d.x = 0;
            d.y = 0;

        }
        
        public figure(float x, float y, int aa, int ba, int size)
        {
            a.x = x - size * 5;
            a.y = y - size * 5;
            b.x = a.x ;
            b.y = a.y + aa + size * 10;
            c.x = a.x + ba + size * 10;
            c.y = a.y + aa + size * 10;
            d.x = a.x +ba+ size * 10;
            d.y = a.y;

        }
        public figure(float x1,int y1,int x2,int y2,int x3,int y3,int x4,int y4)
        {
            a.x = x1;
            a.y = y1;
            b.x = x2;
            b.y = y2;
            c.x = x3;
            c.y = y3;
            d.x = x4;
            d.y = y4;

        }
        public figure(point aa,point bb,point cc,point dd)
        {
            a.x = aa.x;
            a.y = aa.y;
            b.x = bb.x;
            b.y = bb.y;
            c.x = cc.x;
            c.y = cc.y;
            d.x = dd.x;
            d.y = dd.y;

        }
        public figure(figure bb)
        {
            a = bb.a;
            b = bb.b;
            c = bb.c;
            d = bb.d;
        }
        public figure(figure bb,int aa)
        {
            a.x = bb.a.x+aa;
            a.y = bb.a.y+aa;
            b.x = bb.b.x+aa;
            b.y = bb.b.y-aa;
            c.x = bb.c.x-aa;
            c.y = bb.c.y-aa;
            d.x = bb.d.x-aa;
            d.y = bb.d.y+aa;
        }
    }


}