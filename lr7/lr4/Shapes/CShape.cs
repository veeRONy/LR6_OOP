using lr4.Observer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        public List<IObserver> observers=new List<IObserver>();

        abstract public void Draw(frmMain form);
        abstract public bool IsClicked(int X, int Y);
        abstract public CShape GetOriginal();
        virtual public bool IsDecorated() { return false; }

        abstract public void Save(string filename);

        abstract public void MoveX(int dx, int width, int height);
        abstract public void MoveY(int dy, int width, int height);
        abstract public void ChangeSize(int da, int width, int height);
        public void SetColor(Color color)
        {
            pen.Color = color;
        }
        public Color GetColor()
        {
            return pen.Color;
        }
        public string ColorCode()
        {
            if (pen.Color == Color.Red) { return "R"; }
            else if (pen.Color == Color.DeepPink) { return "P"; }
            else if (pen.Color == Color.Blue) { return "B"; }
            else if (pen.Color == Color.Green) { return "G"; }
            else { return "Y"; }
        }
        public void SetA(int a)
        {
            this.a = a;
        }
        public bool canMoveX(int dx, int width)
        {
            return ((x + dx - 10 - a/2) > 0 && (x + dx + 225 + a/2) < width);
        }
        public bool canMoveY(int dy, int height)
        {
            return ((y + dy - 45 - a/2) > 0 && (y + dy + 50 + a/2) < height);
        }
        public bool canSizeUp(int da, int width, int height)
        {
            return (canMoveX(da, width) && canMoveY(da, height));
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void NotifyEveryone()
        {

            foreach(var observer in observers)
                observer.OnSubjectChanged();
        }

    }
}
