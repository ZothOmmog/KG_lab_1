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
        ArrayLines arrayLines; //массив линий
        Bitmap map; //холст
        bool moveLine; //для определения, когда перетягиваем прямую
        int deltaX;
        int deltaY;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        //Инициализация внутренних переменных
        private void Init()
        {
            arrayLines = new ArrayLines();
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            moveLine = false;

            toolTipCreate.SetToolTip(buttonCreateLine,
                "Для создания линии можно зажать Alt и 2 раза нажать ЛКМ по рабочему полю.");
            toolTipDelete.SetToolTip(buttonDeleteLine,
                "Будут удалены все выбранные линии.");
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
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int i = 0; i < arrayLines.Length; i++)
                if (arrayLines.SearchIndexCurrent(i)) DrawingLine(arrayLines[i], Color.PaleVioletRed, Color.Red);
                else DrawingLine(arrayLines[i], Color.Black, Color.Red);
            pictureBox1.Image = map;
        }

        //Перерисовка массива текущих линий
        private void ReDrawCurrentLines()
        {
            for (int i = 0; i < arrayLines.Length; i++)
                if (arrayLines.SearchIndexCurrent(i))
                    DrawingLine(arrayLines[i], Color.PaleVioletRed, Color.Red);

            pictureBox1.Image = map;
        }

        //Отрисовка линии
        private void DrawingLine(Line l, Color penColor, Color pointColor)
        {
            Graphics g = GetGraphics();

            g.DrawLine(new Pen(penColor, 3), l.Point1, l.Point2);
            g.FillEllipse(new SolidBrush(pointColor), new Rectangle(l.Point1.X - 4, l.Point1.Y - 4, 9, 9));
            g.FillEllipse(new SolidBrush(pointColor), new Rectangle(l.Point2.X - 4, l.Point2.Y - 4, 9, 9));
        }



        //Создание и добавление линии на графический объект и добавление линии в массив линий
        private void AddLine()
        {
            Random rand = new Random();

            Point p1 = new Point(200 + rand.Next(50), 300 + rand.Next(50));
            Point p2 = new Point(350 + rand.Next(50), 250 + rand.Next(50));

            Line l = new Line(p1, p2);

            arrayLines.AddLine(l);
            //AddLineInArr(l);
            ReDwarAll();
        }

        //Создать линию
        private void CreateLine()
        {
            AddLine();
        }
        


        //Возвращает индекс линии, если она не дальше 15 пикселей от указателя мышки (если такой нет, то -1)
        private int GetNearLine(Point p)
        {
            Line upLine;
            Line downLine;

            for(int i = 0; i < arrayLines.Length; i++)
            {
                upLine = new Line(arrayLines[i].Point1.X, arrayLines[i].Point1.Y - 5, arrayLines[i].Point2.X, arrayLines[i].Point2.Y - 5);
                downLine = new Line(arrayLines[i].Point1.X, arrayLines[i].Point1.Y + 5, arrayLines[i].Point2.X, arrayLines[i].Point2.Y + 5);

                if (upLine.A * p.X + upLine.B * p.Y + upLine.C > 0 && downLine.A * p.X + downLine.B * p.Y + downLine.C < 0)
                    return i;
            }

            return -1;
        }


        //Добавление в массив текущих линий новой текущей линии
        private void AddAndDrawCurrentLine(int index)
        {
            arrayLines.CurrentLinesAdd(index);
            ReDwarAll();
        }

        //Попытка выбрать одну линию и нарисовать её
        private void TryAddOneCurrentLine(Point p)
        {
            int index = GetNearLine(p);
            
            if(index != -1)
            {
                arrayLines.CurrentLinesClear();
                AddAndDrawCurrentLine(index);
            }
            else
            {
                arrayLines.CurrentLinesClear();
                ReDwarAll();
            }
        }

        //Попытка добавить линию в текущие линии
        private void TryAddCurrentLine(Point p)
        {
            int index = GetNearLine(p);

            if (index != -1)
            {
                AddAndDrawCurrentLine(index);
            }
            else
            {
                arrayLines.CurrentLinesClear();
                ReDwarAll();
            }
        }


        //Удаление всех выбранных линий
        private void DeleteLine()
        {
            for (int i = 0; i < arrayLines.Length; i++)
                if (arrayLines.SearchIndexCurrent(i))
                    DrawingLine(arrayLines[i], Color.White, Color.White);

            arrayLines.CurrentLineDelete();
            ReDwarAll();
        }




        //Нажатие кнопки удаления линии
        private void ButtonDeleteLine_Click(object sender, EventArgs e)
        {
            DeleteLine();
        }

        //Нажатие кнопки создания линии
        private void ButtonCreateLine_Click(object sender, EventArgs e)
        {
            CreateLine();
        }

        //Выход из редактора
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Нажатие мышкой на рабочее поле(для выделения линии)
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control) TryAddCurrentLine(e.Location);
            else TryAddOneCurrentLine(e.Location);

            moveLine = true;
        }

        //Для отпусказния перетягивания линии когда она в фокусе   
        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moveLine = false;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(moveLine && arrayLines.IndexCurrent != null)
            {
                for(int i = 0; i < arrayLines.IndexCurrent.Length; i++)
                {
                    arrayLines[arrayLines.IndexCurrent[i]].Point1 = 
                        new Point(arrayLines[arrayLines.IndexCurrent[i]].Point1.X +
                        Math.Abs(arrayLines[arrayLines.IndexCurrent[i]].Point1.X - e.X),
                        arrayLines[arrayLines.IndexCurrent[i]].Point1.Y +
                        Math.Abs(arrayLines[arrayLines.IndexCurrent[i]].Point1.Y - e.Y));

                    arrayLines[arrayLines.IndexCurrent[i]].Point2 =
                        new Point(arrayLines[arrayLines.IndexCurrent[i]].Point2.X +
                        Math.Abs(arrayLines[arrayLines.IndexCurrent[i]].Point2.X - e.X),
                        arrayLines[arrayLines.IndexCurrent[i]].Point2.Y +
                        Math.Abs(arrayLines[arrayLines.IndexCurrent[i]].Point2.Y - e.Y));
                }
                ReDwarAll();
            }
        }
    }
}
