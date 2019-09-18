using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KG_lab_1
{
    public partial class MainForm : Form
    {
        Point[,] linesArr = new Point[2, 0];

        public MainForm()
        {
            InitializeComponent();
        }

        //Добавить линию в массив линий
        private void AddLine(Point p1, Point p2)
        {
            Point[,] bufArr = new Point[linesArr.GetLength(0) + 1, linesArr.GetLength(1)];

            for (int i = 0; i < bufArr.GetLength(0); i++)
            {
                for(int j = 0; j < bufArr.GetLength(1); i++)
                {
                    bufArr[i, j] = linesArr[i, j];
                }
            }

            bufArr[bufArr.GetLength(0) - 1, 0] = p1;
            bufArr[bufArr.GetLength(0) - 1, 1] = p2;

            linesArr = bufArr;
        }

        //Получение рисунка
        private Graphics GetGraphics(ref Bitmap img)
        {
            if (pictureBox1.Image == null) return Graphics.FromImage(new Bitmap(pictureBox1.Width, pictureBox1.Height));
            else return Graphics.FromImage(pictureBox1.Image);
        }

        //Вычисление координат для точек новой линии


        //Добавление линии на графический объект
        private void AddLine(ref Graphics g)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            Point point1 = new Point(250, 350);
            Point point2 = new Point(400, 300);
            g.DrawLine(blackPen, point1, point2);
        }

        //Создать линию
        private void CreateLine()
        {
            
            Bitmap img;
            Graphics g = GetGraphics(ref img);


            //AddLine(ref g);
            Pen blackPen = new Pen(Color.Black, 3);
            Point point1 = new Point(250, 350);
            Point point2 = new Point(400, 300);
            g.DrawLine(blackPen, point1, point2);

            pictureBox1.Image = img;
        }

        private void ButtonCreateLine_Click(object sender, EventArgs e)
        {
            CreateLine();
        }
    }
}
