using lr4.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (shape.IsDecorated())
            {
                treeView.SelectedNode = t;
                t.Checked = true;
                if (shape is CGroup)
                {
                    SelectNodesInGroup(t);
                }
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
            else return "Группа:";
        }

    }
}
