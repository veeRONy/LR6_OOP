using lr4;
using lr4.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4
{
    public class CDecorator : CShape
    {
        private CShape shape;

        public CDecorator(CShape shape)
        {
            this.shape = shape;
            pen = new Pen(Color.Black);
            pen.DashStyle = DashStyle.Dash;
            a = shape.a;
            x = shape.x;
            y = shape.y;
        }
        public override bool IsDecorated()
        {
            return true;
        }

        override public void Draw(frmMain form)
        {
            g = form.CreateGraphics();
            a = shape.a;
            x = shape.x;
            y = shape.y;
            g.DrawRectangle(pen, x - a / 2 - 10, y - a / 2 - 10, a + 20, a + 20);
            shape.Draw(form);
        }
        override public void MoveX(int dx, int width, int height)
        {
            shape.MoveX(dx, width, height);
        }
        override public void MoveY(int dy, int width, int height)
        {
            shape.MoveY(dy, width, height);
        }
        public override void ChangeSize(int da, int width, int height)
        {
            shape.ChangeSize(da, width, height);
        }

        public override CShape GetOriginal()
        {
            return shape.GetOriginal();
        }

        public override bool IsClicked(int X, int Y)
        {
            return shape.IsClicked(X, Y);
        }

        public override void Save(string filename)
        {
            shape.Save(filename);
        }
    }
}
