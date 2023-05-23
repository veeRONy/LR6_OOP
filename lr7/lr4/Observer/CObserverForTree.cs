using lr4.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr4.Observer
{
    public class CObserverForTree
    {
        TreeView treeView;
        MyStorage<CShape> shapes;
        IObserver observer;

        public CObserverForTree(TreeView treeView, MyStorage<CShape> shapes, IObserver observer)
        {
            this.treeView = treeView;
            this.shapes = shapes;
            this.observer = observer;
        }

        public void OnSubjectChangedDecorate(TreeNode tn, frmMain form)
        {
            int i = tn.Index;
            if (tn.Parent == null)
                return;
            if (tn.Parent.Text=="Хранилище:")
            {
                Decorate(i,tn, form);
            }
            else
            {
                while(tn.Parent.Text != "Хранилище:")
                    tn = tn.Parent;
                i=tn.Index;
                Decorate(i,tn,form);
            }
        }

        public void OnSubjectChangedUndecorate(TreeNode tn)
        {
            if (tn.Parent == null)
                return;
            int i = tn.Index;
            if (tn.Parent.Text == "Хранилище:")
            {
                Undecorate(i,tn);
            }
            else
            {
                while (tn.Parent.Text != "Хранилище:")
                {
                    if (tn.Parent.Text == "Стрелка")
                        break;
                    tn = tn.Parent;
                }
                i = tn.Index;
                Undecorate(i,tn);
            }
        }
        private void Decorate(int i, TreeNode tn, frmMain form)
        {
            if (shapes.getObject(i) is CGroup group)
            {
                group.Decorate(observer, form);

            } 
            else if (shapes.getObject(i) is CArrow arrow)
            {
                if(tn.Index==0)
                    arrow.Decorate(observer, form);
                else
                {
                    CDecorator decorator = new CDecorator(shapes.getObject(i), observer);
                    shapes.setObject(i, decorator);
                }
            }
            else
            {
                CDecorator decorator = new CDecorator(shapes.getObject(i), observer);
                shapes.setObject(i, decorator);
            }
            shapes.getObject(i).NotifyEveryone();
        }
        private void Undecorate(int i, TreeNode tn)
        {
            if (shapes.getObject(i) is CGroup group)
            {
                group.Undecorate();
            }
            else if (shapes.getObject(i) is CArrow arrow)
            {
                if(tn.Index==0)
                    arrow.Undecorate();
                else
                    shapes.setObject(i, shapes.getObject(i).GetOriginal());
            }
            else if (shapes.getObject(i) is CDecorator decorator)
            {
                shapes.setObject(i, decorator.GetOriginal());
            }
            shapes.getObject(i).NotifyEveryone();
        }
    }
}
