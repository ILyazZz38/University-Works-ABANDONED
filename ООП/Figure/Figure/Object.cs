using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figure
{
    public abstract class figure
    {
        protected static int x, y;
        public figure(int ax, int ay) { x = ax; y = ay; }
        public static void setxy(int ax, int ay)
        {
            x = ax;
            y = ay;
        }
        public static int getx() { return x; }
        public static int gety() { return y; }
        public abstract void Show();
        public void MoveTo(int ax, int ay)
        {
            Show();
            setxy(ax, ay);
            Show();
        }
        public abstract double Area();
    }

     public class circle : figure
    {
        protected static int r;
        public circle(int ax, int ay, int ar) : base(x , y) { circle circle = this; circle.x = ax; circle.y = ay; r = ar; }
        public static void setrad(int ar)
        {
            r = ar;
        }

        public static float getrad()
        {
            return r;
        }
        public override void Show()
        {
            using (Graphics g = Graphics.FromImage(Form1.bmp))
            {
                g.Clear(Color.White);
                g.DrawEllipse(Pens.Red, x, y, getrad(), getrad());
            }
        }

        public override double Area() { return 3.14 * r * r; }
    } 

    public class square : figure
    {
        protected static int a;
        public square(int ax, int ay, int aa) : base(x, y) { square square = this; square.x = ax; square.y = ay; a = aa; }
        public static void seta(int aa)
        {
            a = aa;
        }
        public static int geta()
        {
            return a;
        }
        public override void Show()
        {
            using (Graphics g = Graphics.FromImage(Form1.bmp))
            {
                g.Clear(Color.White);
                g.DrawRectangle(Pens.Red, x, y, geta(), geta());
            }
        }

        public override double Area() { return a * a; }
    }

    public class ellipse : circle
    {
        private static int r2;
        public ellipse(int ax, int ay, int ar, int ar2) : base(x, y, r) { ellipse ellipse = this; ellipse.x = ax; ellipse.y = ay; ellipse.r = ar; r2 = ar2; }
        public static void setrad2(int ar2)
        {
            r2 = ar2;
        }
        public static float getrad2()
        {
            return r2;
        }
        public override void Show()
        {
            using (Graphics g = Graphics.FromImage(Form1.bmp))
            {
                g.Clear(Color.White);
                g.DrawEllipse(Pens.Red, x, y, getrad(), getrad2());
            }
        }
        public void Rotate90()
        {

        }
        public override double Area() { return 3.14 * r * r2; }
    }

    public class rect : square
    {
        private static int b;
        public rect(int ax, int ay, int aA, int aB) : base(x, y, a){ rect rect = this; rect.x = ax; rect.y = ay; rect.a = aA; b = aB; }
        public static void SetB(int aB)
        {
            b = aB;
        }
        public static int GetB()
        {
            return b;
        }
        public override void Show()
        {
            using (Graphics g = Graphics.FromImage(Form1.bmp))
            {
                g.Clear(Color.White);
                g.DrawRectangle(Pens.Red, x, y, geta(), GetB());
            }
        }
        public override double Area() { return a * b; }
    }

    class Object
    {
    }
}
