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

        public void OnSubjectChangedDecorate(TreeNode tn)
        {
            int i = tn.Index;
            if (tn.Parent == null)
                return;
            if (tn.Parent.Text=="Хранилище:")
            {
                Decorate(i);
            }
            else
            {
                while(tn.Parent.Text != "Хранилище:")
                    tn = tn.Parent;
                i=tn.Index;
                Decorate(i);
            }
        }

        public void OnSubjectChangedUndecorate(TreeNode tn)
        {
            if (tn.Parent == null)
                return;
            int i = tn.Index;
            if (tn.Parent.Text == "Хранилище:")
            {
                Undecorate(i);
            }
            else
            {
                while (tn.Parent.Text != "Хранилище:")
                    tn = tn.Parent;
                i = tn.Index;
                Undecorate(i);
            }
        }
        private void Decorate(int i)
        {
            if (shapes.getObject(i) is CGroup group)
            {
                group.Decorate(observer);

            } 
            else if (shapes.getObject(i) is CArrow arrow)
            {
                arrow.Decorate(observer);
            }
            else
            {
                CDecorator decorator = new CDecorator(shapes.getObject(i), observer);
                shapes.setObject(i, decorator);
            }
            shapes.getObject(i).NotifyEveryone();
        }
        private void Undecorate(int i)
        {
            if (shapes.getObject(i) is CGroup group)
            {
                group.Undecorate();
            }
            else if (shapes.getObject(i) is CArrow arrow)
            {
                arrow.Undecorate();
            }
            else if (shapes.getObject(i) is CDecorator decorator)
            {
                shapes.setObject(i, decorator.GetOriginal());
            }
            shapes.getObject(i).NotifyEveryone();
        }
    }
}
