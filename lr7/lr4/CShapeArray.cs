﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using lr4.Shapes;

namespace lr4
{
    public class CShapeArray
    {
        public MyStorage<CShape> shapes;

        public CShapeArray(MyStorage<CShape> shapes)
        {
            this.shapes = shapes;
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
            CGroup group = new CGroup();
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