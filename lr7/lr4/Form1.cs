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

namespace lr4
{

    public partial class frmMain : Form
    {
        MyStorage<CShape> shapes;
        Color color;
        string currShape;

        public frmMain()
        {
            InitializeComponent();
            currShape = "Circle";
            color = Color.Red;
            shapes = new MyStorage<CShape>();
        }


        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                chbCTRL.Checked = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < shapes.getSize(); ++i)
                {
                    // если фмгура выделена, то удаляем ее
                    if (shapes.getObject(i) is CDecorator)
                    {
                        shapes.erase(i);
                        --i;
                    }
                }

                // последнюю в списке делаем выделенной
                if (shapes.getSize() != 0)
                {
                    CDecorator decorator = new CDecorator(shapes.last());
                    shapes.popBack();
                    shapes.pushBack(decorator);
                }
                Refresh();
            }
            else if (e.KeyCode == Keys.Z)
            {
                for (int i = 0; i < shapes.getSize(); ++i)
                    if (shapes.getObject(i) is CDecorator)
                    {
                        shapes.getObject(i).ChangeSize(3, this.Width, this.Height);
                    }
                Refresh();
            }
            else if (e.KeyCode == Keys.X)
            {
                for (int i = 0; i < shapes.getSize(); ++i)
                    if (shapes.getObject(i) is CDecorator)
                    {
                        shapes.getObject(i).ChangeSize(-3, this.Width, this.Height);
                    }
                Refresh();
            }
            else if (e.KeyCode == Keys.A)
            {
                for (int i = 0; i < shapes.getSize(); ++i)
                    if (shapes.getObject(i) is CDecorator)
                    {
                        shapes.getObject(i).MoveX(-5, this.Width, this.Height);
                    }

                Refresh();
            }

            else if (e.KeyCode == Keys.W)
            {
                for (int i = 0; i < shapes.getSize(); ++i)
                    if (shapes.getObject(i) is CDecorator)
                    {
                        shapes.getObject(i).MoveY(-5, this.Width, this.Height);
                    }

                Refresh();

            }
            else if (e.KeyCode == Keys.S)
            {
                for (int i = 0; i < shapes.getSize(); ++i)
                    if (shapes.getObject(i) is CDecorator)
                    {
                        shapes.getObject(i).MoveY(5, this.Width, this.Height);
                    }

                Refresh();
            }
            else if (e.KeyCode == Keys.D)
            {
                for (int i = 0; i < shapes.getSize(); ++i)
                    if (shapes.getObject(i) is CDecorator)
                    {
                        shapes.getObject(i).MoveX(5, this.Width, this.Height);
                    }
                Refresh();
            }
        }
        
        
        
        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (chbCTRL.Checked==false)
            {
                
                // создаем новую фигуру
                CShape shape;
                switch(currShape)
                {
                    case "Circle":
                        shape = new CCircle(e.X, e.Y, color);
                        break;
                    case "Triangle":
                        shape = new CTriangle(e.X, e.Y,color);
                        break;
                    case "Rectangle":
                        shape = new CRectangle(e.X, e.Y, color);
                        break;
                    default:
                        shape = new CCircle(e.X, e.Y, color);
                        break;
                }
                CDecorator decorator1 = new CDecorator(shape);
                // добавляем в контейнер
                shapes.pushBack(decorator1);

                for (int i = 0; i < shapes.getSize() - 1; ++i)
                {
                    if (shapes.getObject(i) is CDecorator decorator)
                    {
                        shapes.setObject(i, decorator.GetOriginal());
                    }
                }

            }
            else
            {
                for (int i = 0; i < shapes.getSize(); i++)
                    if (shapes.getObject(i).IsClicked(e.X, e.Y))
                    {
                        CDecorator decorator = new CDecorator(shapes.getObject(i));
                        shapes.setObject(i, decorator);
                        if (checkBox2.Checked == true)
                            break;
                    }

            }
            Refresh();
        }
        
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            //русуем все фигуры из контейнера
            for (int i = 0; i < shapes.getSize(); i++)
                shapes.getObject(i).Draw(this);

        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (chbCTRL.Checked == true)
                chbCTRL.Checked = false;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            currShape = "Circle";
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currShape = "Rectangle";
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            currShape = "Triangle";
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            color= Color.LimeGreen;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            color=Color.Blue;
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            color=Color.DeepPink;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
        }
    }

}
