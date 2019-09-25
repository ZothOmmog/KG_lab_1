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
        Line[] arrLines; //Maccив линий
        Line[] currentLine; //Выбранные линии

        //Point[,] linesArr; //Массив со всеми линиями
        //Point[,] currentLine; //Выбранная линия
        Bitmap map; //холст

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        //Инициализация внутренних переменных
        private void Init()
        {
            arrLines = new Line[0];
            currentLine = new Line[0];
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        //Добавить линию в массив линий
        private void AddLineInArr(Line l)
        {
            Line[] bufArr = new Line[arrLines.Length + 1];

            for (int i = 0; i < arrLines.Length; i++)
            {
                bufArr[i] = arrLines[i];
            }

            bufArr[bufArr.Length - 1] = l;

            arrLines = bufArr;
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

        //Перерисовывает весь массив линий
        private void ReDwarAll()
        {
            for (int i = 0; i < arrLines.Length; i++)
                DrawingLine(arrLines[i], Color.Black, Color.Red);
        }

        //Отрисовка линии
        private void DrawingLine(Line l, Color penColor, Color pointColor)
        {
            Graphics g = GetGraphics();

            g.DrawLine(new Pen(penColor, 3), l.Point1, l.Point2);
            g.FillEllipse(new SolidBrush(pointColor), new Rectangle(l.Point1.X - 4, l.Point1.Y - 4, 9, 9));
            g.FillEllipse(new SolidBrush(pointColor), new Rectangle(l.Point2.X - 4, l.Point2.Y - 4, 9, 9));
        }

        //Добавление линии на графический объект и добавление линии в массив линий
        private void AddLine()
        {
            Random rand = new Random();

            Point p1 = new Point(200 + rand.Next(50), 300 + rand.Next(50));
            Point p2 = new Point(350 + rand.Next(50), 250 + rand.Next(50));

            Line l = new Line(p1, p2);
            
            AddLineInArr(l);
            ReDwarAll();
            //DrawBlackLine(l);
        }

        //Создать линию
        private void CreateLine()
        {
            AddLine();

            pictureBox1.Image = map;
        }

        //Добавление текущей линии в массив и отрисовка её фиолетовым цветом
        private void DrawCurrentLine()
        {
            Line[] bufArr = new Line[currentLine.Length + 1];
            for (int i = 0; i < currentLine.Length; i++)
                bufArr[i] = currentLine[i];


        }

        //Нажатие кнопки создания линии
        private void ButtonCreateLine_Click(object sender, EventArgs e)
        {
            CreateLine();
        }

        Point p1 = new Point(-1, -1);
        //Нажатие мышкой на рабочее поле(для выделения линии)
        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (p1.X == -1)
                p1 = e.Location;
            else
            {
                Graphics g = GetGraphics();
                DrawingLine(new Line(p1, e.Location), Color.PaleVioletRed, Color.Violet);
                pictureBox1.Image = map;
                p1.X = -1;
            }
        }

        //
        private void ButtonDeleteLine_Click(object sender, EventArgs e)
        {
        }
    }
}
