using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4.Shapes
{
    abstract public class CShape
    {
        public int x, y, a;
        public Graphics g;
        public Pen pen;

        abstract public void Draw(frmMain form);
        abstract public bool IsClicked(int X, int Y);
        abstract public CShape GetOriginal();

        abstract public void MoveX(int dx, int width, int height);
        abstract public void MoveY(int dy, int width, int height);
        abstract public void ChangeSize(int da, int width, int height);
        public void SetColor(Color color)
        {
            pen.Color = color;
        }
        public bool canMoveX(int dx, int width, int height)
        {
            return ((x + dx - 20 - a/2) > 0 && (x + dx + 25 + a/2) < width);
        }
        public bool canMoveY(int dy, int width, int height)
        {
            return ((y + dy - 40 - a/2) > 0 && (y + dy + 50 + a/2) < height);
        }
        public bool canSizeUp(int da, int width, int height)
        {
            return (canMoveX(da, width, height) && canMoveY(da, width, height));
        }

    }
}
