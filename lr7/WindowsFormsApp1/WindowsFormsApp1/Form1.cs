using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            // устанавливаем текст подсказки на объект btnClickMe
            toolTip.SetToolTip(btnClickMe, "Это кнопка...");
            pnl.Location = new Point(520, 48);
        }
        int c = 0;
        private void btnOK_Click(object sender, EventArgs e)
        {
            c++; // увеличиваем счетчтк кликов
            btnGo_Click(sender, e); // вызваем обработчик события 
            tbCount.Text = c.ToString(); // записываем в текстбокс количество кликов
            
        }

        Point point;
        private void btnOK_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);  // координаты, куда нажали мышью на кнопку
        }
        private void btnOK_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // изменяем координаты кнопки (левый верхний угол)
                btnOK.Left += e.X - point.X;  
                btnOK.Top += e.Y - point.Y;
            }
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            lbCoordX.Text = e.X.ToString(); // координата Х
            lbCoordY.Text = e.Y.ToString(); // координата Y
        }
     
        
        
        private void btnMouse_MouseEnter(object sender, EventArgs e)
        {
            tbMouse.Text = "Вы навели мышь на кнопку.";
            btnCircle.PerformClick(); // вызваем метод, который вызывает событие click
        }

        private void btnMouse_MouseLeave(object sender, EventArgs e)
        {
            tbMouse.Text = "Вы не навели мышь на кнопку.";
        }
        
        private void rbColorful_CheckedChanged(object sender, EventArgs e)
        {
            // устанавливаем цвет
            this.BackColor = Color.LightCoral;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            // устанавливаем цвет
            this.BackColor = Color.Ivory;
        }

        private void linklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // ссылка на сайт
            System.Diagnostics.Process.Start("https://github.com/veeRONy/veeRONy");
            // устанавливаем, что ссылка посещена
            linklb.LinkVisited = true;
        }


        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            // если дата = 2023.02.27
            if (dtp.Value.ToLongDateString() == new DateTime(2023,02,27).ToLongDateString())
            {
                tbSchedule.Text = "Расписание:\r\n";
                tbSchedule.Text += "1. Администрирование ИС\r\n";
                tbSchedule.Text += "2. Теория вероятностей\r\n";
                tbSchedule.Text += "3. Проектирование и конструирование ПО";
            }
            // если дата = 2023.02.28
            else if (dtp.Value.ToLongDateString() == new DateTime(2023,02,28).ToLongDateString())
            {
                tbSchedule.Text = "Расписание:\r\n";
                tbSchedule.Text += "1. Физ-ра\r\n";
                tbSchedule.Text += "2. Теория вероятностей\r\n";
                tbSchedule.Text += "3. ПиКПО\r\n";
                tbSchedule.AppendText("4. ООП\r\n");
            }
            // в других случаях
            else
            {
                tbSchedule.Text = "Расписание отсутствует!\r\n";
            }
        }

        private void nmr_ValueChanged(object sender, EventArgs e)
        {
            // при определенном значении в nmr.Value меняем ширфт у чекбокса
            if (nmr.Value == 8)
                chbReport.Font = new Font("Arial", 8); 
            if (nmr.Value == 9)
                chbReport.Font = new Font("Arial", 9);
            if (nmr.Value == 10)
                chbReport.Font = new Font("Arial", 10);
        }

        private void clndr_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dt = new DateTime(2003,08,11);
            if (e.Start==dt)
            {
                lbDay.Text = "Это мой день рождения!";
            }
            else
            {
                lbDay.Text = "Это не мой день рождения!";
            }
        }

        int i = 1; // счетчик кнопок
        private void cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cb.SelectedItem.ToString() == "Добавить кнопку")
            {
                Button btn = new Button(); // созадем кнопку
                btn.BackColor = Color.Azure; // устанавливаем цвет
                btn.Text = "Hello! №" + i.ToString(); // текст
                btn.Name = "btn" + i.ToString(); // имя
                btn.Click += btn_Click; // устанавливаем обработчик события
                flpnl.Controls.Add(btn); // добавляем на форму
                i++; // увеличиваем счетчик кнопок
            }
            if (cb.SelectedItem.ToString() == "Удалить кнопки")
            {
                flpnl.Controls.Clear(); // удаляем компоненты с панели
                i = 1;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            flpnl.Controls.Remove(sender as Button); // удаляем все компоненты
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog(); // созадаем диалоговое окно
            openFile1.DefaultExt = "*.rtf"; // задаем расширение
            openFile1.Filter = "RTF Files|*.rtf";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile1.FileName.Length > 0)
            {
                // загружаем файл в richTextBox
                rtb.LoadFile(openFile1.FileName);
            }

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == 0)
            {
                pbCats.Image = imgList.Images[0];
            }
            if (listBox.SelectedIndex == 1)
            {
                pbCats.Image = imgList.Images[1];
            }
            if (listBox.SelectedIndex == 2)
            {
                pbCats.Image = imgList.Images[2];
            }
            if (listBox.SelectedIndex == 3)
            {
                pbCats.Image = imgList.Images[3];
            }
        }

        Rectangle rect = new Rectangle(10, 10, 60, 70);
        Rectangle circle = new Rectangle(10, 20, 100, 100);

        Graphics g;
        private void pbDraw_Paint(object sender, EventArgs e)
        {
            pbDraw.Image = new Bitmap(pbDraw.Width, pbDraw.Height); //создаем битмап
            g = Graphics.FromImage(pbDraw.Image);
            
            if (sender == btnCircle)
            {
                g.DrawEllipse(Pens.Blue, circle); // рисуем круг
            }
            else
            if (sender == btnSquare)
            {
                g.DrawRectangle(Pens.Red, rect); // рисуем квадрат
            }
            else
            if (sender == btnSquare)
            {
                g.Clear(Color.White); //очищаем
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           btnClickMe.Visible=!btnClickMe.Visible; // меняем свойство visible
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true; // устанавливаем таймер
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            prBar.PerformStep(); // делаем шаг
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false; // отключаем таймер
        }

        private void chbReport_CheckedChanged(object sender, EventArgs e)
        {
            if (chbReport.Checked==true)
            {
                chbLaba.Checked = true; 
            }
            else
            {
                chbLaba.Checked = false;
            }
        }

        private void chbLaba_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLaba.Checked == false)
            {
                chbReport.Checked = false;
            }
        }

        private void trv_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Node0" && e.Node.Checked == true)
            {
                TreeNode newNode = new TreeNode("Не важно когда:"); //создаем новый узел
                trv.Nodes.Add(newNode); //добавляем
                newNode.Nodes.Add(new TreeNode("Сварить пельмешки")); //добавляем новый узел
            }
        }


        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // закрытие приложения
        }

        private void справкаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // вывод сообщения
            MessageBox.Show("Это GUI приложение для лабораторной работы по ООП.");
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            // задаем новые координаты для панели
            pnl.Left=this.Width-pnl.Width-30;
        }

        private void mtbFIO_KeyDown(object sender, KeyEventArgs e)
        {
            // выводим в текстбокс код введенного символа
            tbCode.Text = "Код = " + e.KeyValue.ToString(); 
        }

        private void tbCode_KeyUp(object sender, KeyEventArgs e)
        {
            tbCode.Text = "Не вводите сюда ничего!!!";
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            this.Width += 10; //увеличиваем ширину
            this.Height += 10; // увеличиваем высоту
        }
    }
}
