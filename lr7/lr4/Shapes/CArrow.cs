﻿using lr4.Observer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4.Shapes
{
    public class CArrow : CShape
    {
        CShape shape1;
        CShape shape2;
        CObserverForShape obs;

        public CArrow(CShape shape1, CShape shape2, IObserver observer)
        {
            this.shape1 = shape1;
            this.shape2 = shape2;
            obs = new CObserverForShape(shape2);
            AddObserver(observer);
        }

        public CShape GetShape1()
        {
            return shape1.GetOriginal();
        }
        public CShape GetShape2()
        {
            return shape2.GetOriginal();
        }

        public void Decorate(IObserver observer)
        {
            if(shape1 is CGroup group)
            {
                group.Decorate(observer);
            }
            else
            {
                CDecorator decorator = new CDecorator(shape1, observer);
                shape1 = decorator;
            }

            if (shape2 is CGroup group2)
            {
                group2.Decorate(observer);
            }
            else
            {
                CDecorator decorator = new CDecorator(shape2, observer);
                shape2 = decorator;
            }
        }
        public void Undecorate()
        {
            if (shape1 is CGroup group)
            {
                group.Undecorate();
            }
            else if (shape1 is CDecorator decorator)
            {
                shape1 = decorator.GetOriginal();
            }

            if (shape2 is CGroup group2)
            {
                group2.Undecorate();
            }
            else if (shape2 is CDecorator decorator)
            {
                shape2 = decorator.GetOriginal();
            }
        }
        public override void ChangeSize(int da, int width, int height)
        {
            if (da > 0 && canSizeUp(da, width, height))
            {
                shape1.ChangeSize(da, width, height);
                shape2.ChangeSize(da, width, height);
            }
            else if (da < 0)
            {
                shape1.ChangeSize(da, width, height);
                shape2.ChangeSize(da, width, height);
            }
        }

        public override void Draw(frmMain form)
        {
            shape1.Draw(form);
            shape2.Draw(form);
        }

        public override CShape GetOriginal()
        {
            return this;
        }
        public override bool IsDecorated()
        {
            return shape1.IsDecorated();
        }

        public override bool IsClicked(int X, int Y)
        {
            if (shape1.IsClicked(X, Y) || shape2.IsClicked(X, Y))
                return true;
            else return false;
        }

        public override void MoveX(int dx, int width, int height)
        {
            if (canMoveX(dx, width))
            {
                shape1.MoveX(dx, width, height);
                //obs.OnSubjectChanged(shape1);
                shape2.MoveX(dx,width, height);
            }
        }

        public override void MoveY(int dy, int width, int height)
        {
            if (canMoveY(dy, height))
            {
                shape1.MoveY(dy, width, height);
                //obs.OnSubjectChanged(shape1);
                shape2.MoveY(dy, width, height);
            }
        }

        public override void Save(string filename)
        {
            string inf = "A 2";
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                writer.WriteLine(inf);
            }           
            shape1.Save(filename);
            shape2.Save(filename);
        }

        new public bool canMoveX(int dx, int width)
        {
            List<CShape> _shapes = new List<CShape>();
            _shapes.Add(shape1);
            _shapes.Add(shape2);
            foreach (var shape in _shapes)
            {
                if (shape is CGroup group)
                {
                    if (!group.canMoveX(dx, width))
                        return false;
                }
                else if (shape is CArrow arrow)
                {
                    if (!arrow.canMoveX(dx, width))
                        return false;
                }
                else if (!shape.canMoveX(dx, width))
                    return false;
            }
            return true;
        }
        new public bool canMoveY(int dy, int height)
        {
            List<CShape> _shapes = new List<CShape>();
            _shapes.Add(shape1);
            _shapes.Add(shape2);
            foreach (var shape in _shapes)
            {
                if (shape is CGroup group)
                {
                    if (!group.canMoveY(dy, height))
                        return false;
                }
                else if (shape is CArrow arrow)
                {
                    if (!arrow.canMoveY(dy, height))
                        return false;
                }
                else if (!shape.canMoveY(dy, height))
                    return false;
            }
            return true;
        }
        new public bool canSizeUp(int da, int width, int height)
        {
            List<CShape> _shapes = new List<CShape>();
            _shapes.Add(shape1);
            _shapes.Add(shape2);
            foreach (var shape in _shapes)
            {
                if (shape is CGroup group)
                {
                    if (!group.canSizeUp(da, width, height))
                        return false;
                }
                else if (shape is CArrow arrow)
                {
                    if (!arrow.canSizeUp(da, width, height))
                        return false;
                }
                else if (!shape.canSizeUp(da, width, height))
                    return false;
            }
            return true;
        }
    }
}