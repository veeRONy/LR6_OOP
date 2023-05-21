using lr4;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lr4.Shapes
{
    public class CTriangle : CShape
    {
        private Point[] points = new Point[3];

        public CTriangle(int x, int y,Color color)
        { 
            this.x = x;
            this.y = y;

            a=90;
            points[0].X = x - a / 2;
            points[0].Y = y + Convert.ToInt32(a * Math.Sqrt(3) / 6);

            points[1].X = x + a/2;
            points[1].Y = y + Convert.ToInt32(a * Math.Sqrt(3) / 6);

            points[2].X = x;
            points[2].Y = y - Convert.ToInt32(a * Math.Sqrt(3) / 3);

            pen = new Pen(color);

        }
        override public void Draw(frmMain form)
        {
            g = form.CreateGraphics();
            g.DrawPolygon(pen, points);
        }

        override public bool IsClicked(int x, int y)
        {
            // (x1-x0)*(y2-y1)-(x2-x1)*(y1-y0)
            int a1 = (points[0].X - x) * (points[1].Y - points[0].Y) - (points[1].X - points[0].X) * (points[0].Y - y);

            // (x2-x0)*(y3-y2)-(x3-x2)*(y2-y0)
            int a2 = (points[1].X - x) * (points[2].Y - points[1].Y) - (points[2].X - points[1].X) * (points[1].Y - y);

            // (x3-x0)*(y1-y3)-(x1-x3)*(y3-y0)
            int a3 = (points[2].X - x) * (points[0].Y - points[2].Y) - (points[0].X - points[2].X) * (points[2].Y - y);
            
            if ((a1>=0 && a2>=0 && a3>=0) || (a1<=0 && a2<=0 && a3<=0))
                return true;
            else 
                return false;
        }

        override public void MoveX(int dx, int width, int height)
        {
            if (canMoveX(dx, width, height))
            {
                points[0].X += dx;
                points[1].X += dx;
                points[2].X += dx;
                x = points[0].X + a / 2;
            }
        }
        override public void MoveY(int dy, int width, int height)
        {
            if (canMoveY(dy, width, height))
            {
                points[0].Y += dy;
                points[1].Y += dy;
                points[2].Y += dy;
                y = points[0].Y - Convert.ToInt32(a * Math.Sqrt(3) / 6);
            }
        }

        override public void ChangeSize(int da, int width, int height)
        {
            if (da > 0 && canSizeUp(da, width, height))
            {
                a += da;
                points[0].X = x - a / 2;
                points[0].Y = y + Convert.ToInt32(a * Math.Sqrt(3) / 6);

                points[1].X = x + a / 2;
                points[1].Y = y + Convert.ToInt32(a * Math.Sqrt(3) / 6);

                points[2].X = x;
                points[2].Y = y - Convert.ToInt32(a * Math.Sqrt(3) / 3);
            }
            else if (da < 0)
            {
                a += da;
                points[0].X = x - a / 2;
                points[0].Y = y + Convert.ToInt32(a * Math.Sqrt(3) / 6);

                points[1].X = x + a / 2;
                points[1].Y = y + Convert.ToInt32(a * Math.Sqrt(3) / 6);

                points[2].X = x;
                points[2].Y = y - Convert.ToInt32(a * Math.Sqrt(3) / 3);
            }
        }

        public override CShape GetOriginal()
        {
            return this;
        }
        public override void Save(string filename)
        {
            string inf = "T " + x.ToString()
                           + " " + y.ToString() + " " + a.ToString()
                           + " " + ColorCode();
            using (StreamWriter writer = new StreamWriter(filename,true))
            {
                writer.WriteLine(inf);
            }

        }
       
    }
}
