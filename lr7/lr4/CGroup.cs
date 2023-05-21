﻿using lr4.Shapes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4
{
    public class CGroup : CShape
    {
        List<CShape> _shapes;

        public CGroup()
        {
            _shapes = new List<CShape>();
        }
        public void AddShape(CShape shape)
        {
            _shapes.Add(shape);
        }
        public void DeleteShape(int i)
        {
            _shapes.RemoveAt(i);
        }
        public CShape GetShape(int i)
        {
            return _shapes[i];
        }
        public int GetCount()
        {
            return _shapes.Count();
        }

        public override bool IsDecorated()
        {
            return _shapes[0].IsDecorated();
        }
        public override void ChangeSize(int da, int width, int height)
        {
            if (da > 0 && canSizeUp(da, width, height))
                foreach(var shape in _shapes)
                {
                    shape.ChangeSize(da, width, height);
                }
            else if(da<0)
            {
                foreach (var shape in _shapes)
                {
                    shape.ChangeSize(da, width, height);
                }
            }
        }

        public override void Draw(frmMain form)
        {
            foreach (var shape in _shapes)
            {
                shape.Draw(form);
            }
        }
        public void Decorate()
        {
            for (int i=0; i<_shapes.Count; i++)
            {
                if (_shapes[i] is CGroup group)
                {
                    group.Decorate();
                }
                else
                {
                    CDecorator decorator = new CDecorator(_shapes[i]);
                    _shapes[i] = decorator;
                }
            }
        }
        public void Undecorate()
        {
            for (int i = 0; i < _shapes.Count; i++)
            {
                if (_shapes[i] is CGroup group)
                {
                    group.Undecorate();
                }
                else if (_shapes[i] is CDecorator decorator)
                    _shapes[i] = decorator.GetOriginal();
            }
        }

        public override CShape GetOriginal()
        {
            return null;
        }

        public override bool IsClicked(int X, int Y)
        {
            foreach (var shape in _shapes)
                if (shape.IsClicked(X, Y))
                    return true;               
            return false;
        }

        public override void MoveX(int dx, int width, int height)
        {
            if (canMoveX(dx, width, height)) 
            {   
                foreach (var shape in _shapes)
                    shape.MoveX(dx, width, height);
            }
        }

        public override void MoveY(int dy, int width, int height)
        {
            if (canMoveY(dy, width, height))
            {
                foreach (var shape in _shapes)
                   shape.MoveY(dy, width, height);               
            }
        }

        new public bool canMoveX(int dx, int width, int height)
        {
            foreach (var shape in _shapes)
            {
                if (shape is CGroup group)
                {
                    if (!group.canMoveX(dx, width, height))
                        return false;
                }
                else if (!shape.canMoveX(dx, width, height))
                    return false;
            }
            return true;
        }
        new public bool canMoveY(int dy, int width, int height)
        {
            foreach (var shape in _shapes)
            {
                if (shape is CGroup group)
                {
                    if (!group.canMoveY(dy, width, height))
                        return false;
                }
                else if (!shape.canMoveY(dy, width, height))
                    return false;
            }
            return true;
        }
        new public bool canSizeUp(int da, int width, int height)
        {
            foreach (var shape in _shapes)
            {
                if (shape is CGroup group)
                {
                    if (!group.canSizeUp(da, width, height))
                        return false;
                }
                else if (!shape.canSizeUp(da, width, height))
                    return false;
            }
            return true;
        }

        public override void Save(string filename)
        {
            string inf = "G " + _shapes.Count.ToString();
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                writer.WriteLine(inf);
            }
            foreach (CShape shape in _shapes)
            {
                shape.Save(filename);
            }
        }
    }
}
