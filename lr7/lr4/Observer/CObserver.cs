using lr4.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace lr4.Observer
{
    public class CObserver : IObserver
    {
        TreeView treeView;
        MyStorage<CShape> shapes;

        public CObserver(TreeView treeView, MyStorage<CShape> shapes)
        {
            this.treeView = treeView;
            this.shapes = shapes;
        }
        static int k = 0;
        public void OnSubjectChanged()
        {
            // вся логика с treeview

            treeView.Nodes.Clear();
            TreeNode t = new TreeNode("Хранилище:");
            treeView.Nodes.Add(t);
            for (int i=0; i< shapes.getSize(); ++i)
            {               
                processNode(t,shapes.getObject(i));

            }
            t.ExpandAll();

        }
        private void processNode(TreeNode tn, CShape shape)
        {
            
            //Создай у узла дерева tn новый дочерний узел t;
            TreeNode t = new TreeNode(Type(shape));

            //Если объект o является группой, то:
            if (shape is CGroup group)
            { //Для всех объектов oo из группы o:
                for (int i = 0; i < group.GetCount(); ++i)
                {
                    processNode(t, group.GetShape(i));
                }
            }
            else if (shape is CArrow arrow)
            {
                processNode(t, arrow.GetShape1());

                processNode(t, arrow.GetShape2());

            }
            else if (shape.IsDecorated())
            {
                treeView.SelectedNode = t;
                t.Checked = true;
                if (shape is CGroup)
                {
                    SelectNodesInGroup(t);
                }
                if (shape is CArrow)
                {
                    t.Nodes[0].Checked = true;                   
                }
            }
            else if(shape.GetColor()==Color.Black)
            {
                t.Checked = true;
            }

            tn.Nodes.Add(t);
        }

        private void SelectNodesInGroup(TreeNode tn)
        {
            for (int i=0; i<tn.Nodes.Count; ++i)
            {
                tn.Nodes[i].Checked = true;
                SelectNodesInGroup(tn.Nodes[i]);
            }
        }

        private string Type(CShape shape)
        {
            if (shape.GetOriginal().GetType().ToString() == "lr4.CCircle")
                return "Круг";
            else if (shape.GetOriginal().GetType().ToString() == "lr4.CRectangle")
                return "Квадрат";
            else if (shape.GetOriginal().GetType().ToString() == "lr4.Shapes.CTriangle")
                return "Треугольник";
            else if (shape.GetOriginal().GetType().ToString() == "lr4.Shapes.CArrow")
                return "Стрелка";
            else return "Группа:";
        }

    }
}
