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
        Point[,] linesArr; //Массив со всеми линиями
        Point[,] currentLine; //Выбранная линия
        Bitmap map; //холст

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        //Инициализация внутренних переменных
        private void Init()
        {
            linesArr = new Point[0, 2];
            currentLine = new Point[1, 2];
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        //Добавить линию в массив линий
        private void AddLineInArr(Point p1, Point p2)
        {
            Point[,] bufArr = new Point[linesArr.GetLength(0) + 1, linesArr.GetLength(1)];

            for (int i = 0; i < linesArr.GetLength(0); i++)
            {
                for(int j = 0; j < linesArr.GetLength(1); j++)
                {
                    bufArr[i, j] = linesArr[i, j];
                }
            }

            bufArr[bufArr.GetLength(0) - 1, 0] = p1;
            bufArr[bufArr.GetLength(0) - 1, 1] = p2;

            linesArr = bufArr;
        }

        //Получение рисунка
        private Graphics GetGraphics()
        {
            if (pictureBox1.Image == null)
            {
                map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                return Graphics.FromImage(map);
            }
            else return Graphics.FromImage(map);
        }

        //Вычисление координат для точек новой линии
        private Point[] GetPointArr()
        {
            Point[] line = new Point[2];
            line[0].X = 250;
            line[0].Y = 350;
            line[1].X = 400;
            line[1].Y = 300;

            return line;
        }

        //Добавление линии на графический объект и добавление линии в массив линий
        private void AddLine()
        {
            Graphics g = GetGraphics();

            Pen blackPen = new Pen(Color.Black, 3);
            Point p1 = new Point(250, 350);
            Point p2 = new Point(400, 300);

            AddLineInArr(p1, p2);

            g.DrawLine(blackPen, p1, p2);
        }

        //Создать линию
        private void CreateLine()
        {
            AddLine();

            pictureBox1.Image = map;
        }

        private void ButtonCreateLine_Click(object sender, EventArgs e)
        {
            CreateLine();
        }
    }
}
