using lr4;
using lr4.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using lr4.Observer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Security.Cryptography;

namespace lr4
{

    public partial class frmMain : Form
    {
        MyStorage<CShape> shapes;
        Color color;
        string currShape;
        string filename = "C:\\Users\\user\\Desktop\\Учеба\\с# проги\\lr7\\shapes.txt";
        CObserver observer;
        CObserverForTree observerForTree;

        public frmMain()
        {
            InitializeComponent();
            currShape = "Circle";
            color = Color.Red;
            shapes = new MyStorage<CShape>();
            observer = new CObserver(treeView, shapes);
            observerForTree = new CObserverForTree(treeView, shapes,observer);
        }


        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                chbCTRL.Checked = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnArrowIsClicked = false;
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    // если фмгура/группа выделена, то удаляем ее
                    if (shapes.getObject(i).IsDecorated())
                    {
                        shapes.erase(i);
                        
                        --i;
                    }
                    
                }
                // последнюю в списке делаем выделенной
                if (shapes.getSize() != 0)
                {
                    DecorateLastShape();
                }
                else
                {
                    treeView.Nodes.Clear();
                    TreeNode t = new TreeNode("Хринилище:");
                    treeView.Nodes.Add(t);
                }
                Refresh();
            }
            else if (e.KeyCode == Keys.Z)
            {
                btnArrowIsClicked = false;
                
                for (int i = 0; i < shapes.getSize(); ++i)
                    if (shapes.getObject(i).IsDecorated())
                    {
                        shapes.getObject(i).ChangeSize(3, this.Width, this.Height);
                    }
                
                Refresh();
            }
            else if (e.KeyCode == Keys.X)
            {
                btnArrowIsClicked = false;
                for (int i = 0; i < shapes.getSize(); ++i)
                    if (shapes.getObject(i).IsDecorated())
                    {
                        shapes.getObject(i).ChangeSize(-3, this.Width, this.Height);
                    }
                Refresh();
            }
            else if (e.KeyCode == Keys.A)
            {
                btnArrowIsClicked = false;
                for (int i = 0; i < shapes.getSize(); ++i)
                    if (shapes.getObject(i).IsDecorated())
                    {
                        if (shapes.getObject(i) is CArrow arrow)
                        {
                            if (arrow.IsDecorated())
                            {
                                shapes.getObject(i).MoveX(-5, this.Width, this.Height);
                            }
                            else
                            {
                                arrow.MoveXShape2(-5, this.Width, this.Height);
                            }
                        }
                        else
                            shapes.getObject(i).MoveX(-5, this.Width, this.Height);
                    }
                Refresh();
            }

            else if (e.KeyCode == Keys.W)
            {
                btnArrowIsClicked = false;
                for (int i = 0; i < shapes.getSize(); ++i)
                    if (shapes.getObject(i).IsDecorated())
                    {
                        if (shapes.getObject(i) is CArrow arrow)
                        {
                            if (arrow.IsDecorated())
                            {
                                shapes.getObject(i).MoveY(-5, this.Width, this.Height);
                            }
                            else
                            {
                                arrow.MoveYShape2(-5, this.Width, this.Height);
                            }
                        }
                        else
                            shapes.getObject(i).MoveY(-5, this.Width, this.Height);
                    }
                Refresh();

            }
            else if (e.KeyCode == Keys.S)
            {
                btnArrowIsClicked = false;
                for (int i = 0; i < shapes.getSize(); ++i)
                    if (shapes.getObject(i).IsDecorated())
                    {
                        if(shapes.getObject(i) is CArrow arrow)
                        {
                            if(arrow.IsDecorated())
                            {
                                shapes.getObject(i).MoveY(5, this.Width, this.Height);
                            }
                            else
                            {
                                arrow.MoveYShape2(5, this.Width, this.Height);
                            }
                        }
                        else
                            shapes.getObject(i).MoveY(5, this.Width, this.Height);
                    }
                Refresh();
            }
            else if (e.KeyCode == Keys.D)
            {
                btnArrowIsClicked = false;
                for (int i = 0; i < shapes.getSize(); ++i)
                    if (shapes.getObject(i).IsDecorated())
                    {
                        if (shapes.getObject(i) is CArrow arrow)
                        {
                            if (arrow.IsDecorated())
                            {
                                shapes.getObject(i).MoveX(5, this.Width, this.Height);
                            }
                            else
                            {
                                arrow.MoveXShape2(5, this.Width, this.Height);
                            }
                        }
                        else
                            shapes.getObject(i).MoveX(5, this.Width, this.Height);
                    }
                Refresh();
            }
        }
        
        
        
        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            // создание
            if (chbCTRL.Checked==false)
            {
                btnArrowIsClicked = false;
                // создаем новую фигуру
                CShape shape;
                switch(currShape)
                {
                    case "Circle":
                        shape = new CCircle(e.X, e.Y, color,observer);
                        break;
                    case "Triangle":
                        shape = new CTriangle(e.X, e.Y,color, observer);
                        break;
                    case "Rectangle":
                        shape = new CRectangle(e.X, e.Y, color, observer);
                        break;
                    default:
                        shape = new CCircle(e.X, e.Y, color, observer);
                        break;
                }
                // создаем для нее декоратор
                CDecorator decorator1 = new CDecorator(shape, observer);
                // добавляем в контейнер
                shapes.pushBack(decorator1);
                decorator1.NotifyEveryone();

                // все предыдщие фигуры делаем не декорированными, в том числе группы, если они декорированы
                UndecorateShapes();
            }
            else // выделение
            {
                int decoratedIndex = 0;
                // если на фигуру/группу нажали, то декорируем
                for (int i = 0; i < shapes.getSize(); i++)
                    if (shapes.getObject(i).IsClicked(e.X, e.Y))
                    {
                        if (shapes.getObject(i) is CGroup group)
                        {
                            group.Decorate(observer,this);
                            group.NotifyEveryone();
                        }
                        else if(shapes.getObject(i) is CArrow arrow)
                        {
                            if (arrow.GetShape1().IsClicked(e.X, e.Y))
                            {
                                arrow.Undecorate();
                                arrow.Decorate(observer, this);
                            }
                            else
                            {
                                arrow.Undecorate();
                                CDecorator decorator = new CDecorator(arrow.GetShape2(), observer);
                                arrow.SetShape2(decorator);

                            }
                            arrow.NotifyEveryone();
                        }
                        else
                        {
                            CDecorator decorator = new CDecorator(shapes.getObject(i), observer);
                            shapes.setObject(i, decorator);
                            shapes.getObject(i).NotifyEveryone();
                            if (checkBox2.Checked == true)
                                break;
                        }
                        decoratedIndex = i;
                    }
                if (btnArrowIsClicked == true)
                { 
                    shape2 = shapes.getObject(decoratedIndex);
                    DoArrow();
                    
                }
                btnArrowIsClicked = false;
            }
            Refresh();
        }
        
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            //русуем все фигуры из контейнера
            for (int i = 0; i < shapes.getSize(); i++)
                shapes.getObject(i).Draw(this);

        }

        public void UndecorateShapes()
        {
            for (int i = 0; i < shapes.getSize() - 1; ++i)
            {
                if (shapes.getObject(i) is CGroup group)
                {
                    group.Undecorate();
                    group.NotifyEveryone();
                }
                else if(shapes.getObject(i) is CArrow arrow)
                {

                    arrow.Undecorate();
                    arrow.NotifyEveryone();
                }
                else if (shapes.getObject(i) is CDecorator decorator)
                {
                    shapes.setObject(i, decorator.GetOriginal());
                    decorator.NotifyEveryone();
                }
            }
        }

        public void DecorateLastShape()
        {
            if (shapes.last() is CGroup group)
            {
                group.Decorate(observer,this);
            }
            else if(shapes.last() is CArrow arrow)
            {
                arrow.Decorate(observer,this);
            }
            else
            {
                CDecorator decorator = new CDecorator(shapes.last(), observer);
                shapes.popBack();
                shapes.pushBack(decorator);
            }
            shapes.last().NotifyEveryone();
        }
        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (chbCTRL.Checked == true)
                chbCTRL.Checked = false;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            btnArrowIsClicked = false;
            currShape = "Circle";
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            btnArrowIsClicked = false;
            currShape = "Rectangle";
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            btnArrowIsClicked = false;
            currShape = "Triangle";
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            btnArrowIsClicked = false;
            color = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            btnArrowIsClicked = false;
            color = Color.LimeGreen;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            btnArrowIsClicked = false;
            color =Color.Blue;
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            btnArrowIsClicked = false;
            color =Color.DeepPink;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            btnArrowIsClicked = false;
            color = Color.Yellow;
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            btnArrowIsClicked = false;
            if (shapes.getSize() != 0 && CountDecoratedShapes() > 1)
            {
                CGroup group = new CGroup(observer);
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    if (shapes.getObject(i).IsDecorated())
                    {
                        group.AddShape(shapes.getObject(i));
                        shapes.erase(i);
                        i--;
                    }
                }
                shapes.pushBack(group);
                shapes.last().NotifyEveryone();
            }
        }

        private void btnUnGroup_Click(object sender, EventArgs e)
        {
            btnArrowIsClicked = false;
            for (int i=0;i<shapes.getSize(); i++)
            {
                if (shapes.getObject(i).IsDecorated() && shapes.getObject(i) is CGroup group)
                {
                   
                    for (int j=0;j<group.GetCount();j++)
                    {
                        if (group.GetShape(j) is CDecorator)
                        {
                            shapes.pushBack(group.GetShape(j).GetOriginal());
                            group.DeleteShape(j);
                            j--;
                        }
                        else if (group.GetShape(j) is CGroup group2)
                        {
                            group2.Undecorate();
                            shapes.pushBack(group2);
                            group.DeleteShape(j);
                            j--;
                        }
                        else if(group.GetShape(j) is CArrow arrow)
                        {
                            arrow.Undecorate();
                            shapes.pushBack(arrow);
                            group.DeleteShape(j);
                            j--;
                        }
                    }
                    shapes.erase(i);
                    i--;
                    
                }
            }
            DecorateLastShape();
            Refresh();
            shapes.last().NotifyEveryone();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            btnArrowIsClicked = false;
            int count = shapes.getSize();
            if(count!=0)
            {
                File.WriteAllText(filename, count.ToString() + Environment.NewLine);
                for (int i = 0; i < count; i++)
                    shapes.getObject(i).Save(filename);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnArrowIsClicked = false;
            CMyShapeArray cMyShapeArray = new CMyShapeArray(shapes, observer);
            cMyShapeArray.LoadShapes(filename);

            // последюю делаем выделенной
            if (shapes.getSize() != 0)
            {
                if (shapes.last() is CGroup group)
                {
                    group.Decorate(observer, this);
                }
                else if(shapes.last() is CArrow arrow)
                    arrow.Decorate(observer, this);
                else
                {
                    CDecorator decorator = new CDecorator(shapes.last(), observer);
                    shapes.setObject(shapes.getSize()-1, decorator);
                }
                shapes.last().NotifyEveryone();
            }
            Refresh();
        }

        bool before = false;
        private void treeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (before == false && e.Node.Checked == true)
                observerForTree.OnSubjectChangedDecorate(e.Node,this);
            else if (before == true && e.Node.Checked == false)
                observerForTree.OnSubjectChangedUndecorate(e.Node);
                Refresh();
        }

        private void treeView_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Checked == true)
                before = true;
            else
                before = false;
        }

        bool btnArrowIsClicked = false;
        private int CountDecoratedShapes()
        {
            int count = 0;
            for (int i = 0; i < shapes.getSize(); ++i)
            {
                if (shapes.getObject(i).IsDecorated())
                    count++;
            }
            return count;
        }
        CShape shape1;
        CShape shape2;
        private void btnArrow_Click(object sender, EventArgs e)
        {
            if (CountDecoratedShapes() == 1)
            {
                btnArrowIsClicked = true;
                // получаем 1 декорированную фигуру
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    if (shapes.getObject(i).IsDecorated())
                        shape1 = shapes.getObject(i);
                }
            }
        }
        private void DoArrow()
        {
            btnArrowIsClicked = false;
            if (CountDecoratedShapes() == 2)
            {
                CShape arrow = new CArrow(shape1, shape2, observer, color);
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    if (shapes.getObject(i) == shape1 || shapes.getObject(i) == shape2)
                    {
                        shapes.erase(i);
                        i--;
                    }
                }
                CArrow arr = (CArrow)arrow;
                arr.Undecorate();
                arr.Decorate(observer, this);

                shapes.pushBack(arr);
                shapes.last().NotifyEveryone();
            }
        }
    }

}
