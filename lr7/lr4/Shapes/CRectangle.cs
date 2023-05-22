using lr4;
using lr4.Observer;
using lr4.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4
{
    public class CRectangle : CShape
    {
        public CRectangle(int x, int y, Color color, IObserver observer)
        {
            a = 90;
            this.x = x;
            this.y = y;            
            pen = new Pen(color);
            AddObserver(observer);
        }
        override public void Draw(frmMain form)
        {
            g = form.CreateGraphics();
            g.DrawRectangle(pen,x-a/2,y-a/2,a,a);
        }

        public override CShape GetOriginal()
        {
            return this;
        }

        override public bool IsClicked(int X, int Y)
        {
            if ((X >= x-a/2) && (X <= x + a/2) && (Y >= y-a/2) && (Y <= y + a/2))
                return true;
            else return false;
        }
        override public void MoveX(int dx, int width, int height)
        {
            if (canMoveX(dx, width, height))
                x += dx;
        }
        override public void MoveY(int dy, int width, int height)
        {
            if (canMoveY(dy, width, height))
                y += dy;
        }
        override public void ChangeSize(int da, int width, int height)
        {
            if (da > 0 && canSizeUp(da, width, height))
                a += da;
            else if (da < 0)
                a += da;
        }
        public override void Save(string filename)
        {
            string inf = "R " + x.ToString()
                           + " " + y.ToString() + " " + a.ToString()
                           + " " + ColorCode();
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                writer.WriteLine(inf);
            }

        }
    }
}
