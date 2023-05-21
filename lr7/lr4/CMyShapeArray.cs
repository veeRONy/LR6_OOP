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
    public class CMyShapeArray: CShapeArray
    {
        
        public CMyShapeArray(MyStorage<CShape> shapes) : base(shapes)
        {
            this.shapes = shapes;
        }

        public override CShape CreateShape(string code, StreamReader reader)
        {
            CShape shape;
            string[] words = code.Split(' ');
            char type_of_shape = char.Parse(words[0]);
            int x = int.Parse(words[1]);
            int y = int.Parse(words[2]);
            int a = int.Parse(words[3]);
            char c = char.Parse(words[4]);
            Color color;
            switch (c)
            {
                case 'P':
                    color = Color.DeepPink;
                    break;
                case 'B':
                    color = Color.Blue;
                    break;
                case 'G':
                    color = Color.LimeGreen;
                    break;
                case 'Y':
                    color = Color.Yellow;
                    break;
                case 'R':
                    color = Color.Red;
                    break;
                default:
                    color = Color.Red;
                    break;
            }
            switch (type_of_shape)
            {
                case 'C':
                    shape = new CCircle(x,y,color);
                    break;
                case 'T':
                    shape = new CTriangle(x, y, color);
                    break;
                case 'R':
                    shape = new CRectangle(x, y, color);
                    break;
                default:
                    shape = new CCircle(x, y, color);
                    break;
            }
            shape.SetA(a);
            return shape;
        }
    }
}
