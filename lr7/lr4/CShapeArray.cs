using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using lr4.Observer;
using lr4.Shapes;
using System.Drawing;

namespace lr4
{
    public class CShapeArray
    {
        public MyStorage<CShape> shapes;
        public IObserver observer;

        public CShapeArray(MyStorage<CShape> shapes, IObserver observer)
        {
            this.shapes = shapes;
            this.observer = observer;
        }

        virtual public CShape CreateShape(string code, StreamReader reader) { return null; }
        
        public void LoadShapes(string filename)
        {
            string code;
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            int count = int.Parse(reader.ReadLine());
            for (int i = 0; i < count; i++)
            {
                code = reader.ReadLine();
                if (code[0] == 'G')
                {
                    shapes.pushBack(LoadGroup(code, reader, i));
                }
                else if (code[0] == 'A')
                {
                    CGroup group = new CGroup(observer);
                    group = LoadGroup(code, reader, i);
                    CArrow arrow = new CArrow(group.GetShape(0), group.GetShape(1), observer, Color.Red);
                    shapes.pushBack(arrow);
                }
                else
                {
                    CShape shape = CreateShape(code, reader);
                    if (shape != null)
                    {
                        shapes.pushBack(shape);
                    }
                }
            }
            reader.Close();
            stream.Close();
        }

       
        
        public CGroup LoadGroup(string code, StreamReader reader, int i)
        {
            CGroup group = new CGroup(observer);
            string[] words = code.Split(' ');
            int n = int.Parse(words[1]);
            i += n;
            for (int j = 0; j < n; j++)
            {
                string _code = reader.ReadLine();
                if (_code[0] == 'G')
                {
                    group.AddShape(LoadGroup(_code, reader, j));
                }
                else if (_code[0] == 'A')
                {
                    group = LoadGroup(code, reader, i);
                    CArrow arrow = new CArrow(group.GetShape(0), group.GetShape(1), observer, Color.Red);
                    group.AddShape(arrow);
                }
                else
                {
                    CShape _shape = CreateShape(_code, reader);
                    if (_shape != null) { group.AddShape(_shape); }
                }
            }
            return group;
        }
    }
}
