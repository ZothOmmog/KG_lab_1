using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KG_lab_1
{
    class Line
    {
        private int[,] points; //Начало и конец прямой
        private int[] abc; //Коэффиценты уравнения прямой
        bool createPoint1, createPoint2; //Для проверки инициализации точек

        public Point Point1
        {
            get
            {
                return new Point(points[0,0], points[0,1]);
            }
            set
            {
                points[0, 0] = value.X;
                points[0, 1] = value.Y;
                points[0, 2] = 1;
                if (createPoint2) CalcABC();
                createPoint1 = true;
            }
        }
        public Point Point2
        {
            get
            {
                return new Point(points[1, 0], points[1, 1]);
            }
            set
            {
                points[1, 0] = value.X;
                points[1, 1] = value.Y;
                points[1, 2] = 1;
                if (createPoint1) CalcABC();
                createPoint2 = true;
            }
        }

        public int A
        {
            get
            {
                return abc[0];
            }

            set
            {
                abc[0] = value;
            }
        }
        public int B
        {
            get
            {
                return abc[1];
            }

            set
            {
                abc[1] = value;
            }
        }
        public int C
        {
            get
            {
                return abc[2];
            }

            set
            {
                abc[2] = value;
            }
        }

        public Line(Point p1, Point p2)
        {
            Init(p1, p2);
        }

        public void Init(Point p1, Point p2)
        {
            createPoint1 = false;
            createPoint2 = false;
            Point1 = p1;
            Point2 = p2;
        }

        public void CalcABC()
        {
            A = Point1.Y - Point2.Y;
            B = Point2.X - Point1.X;
            C = Point1.X * Point2.Y - Point2.X * Point1.Y;
        }

    }
}
