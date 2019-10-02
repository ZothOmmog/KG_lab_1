using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KG_lab_1
{
    class ArrayLines
    {
        private Line[] array; //массив со всеми линиями
        public int[] IndexCurrent { get; private set; } //массив индексов выделенных линий
        public int Length { get; private set; }

        public ArrayLines()
        {
            array = null;
            IndexCurrent = null;
            Length = 0;
        }
        public ArrayLines(Line l)
        {
            Length = 1;
            array = new Line[Length];
            array[0] = l;
        }

        //Индексатор
        public Line this[int index]
        {
            get
            {
                    return array[index];
            }
            set
            {
                    array[index] = value;
            }
        }

        //Добавление линии в массив
        public void AddLine(Line l)
        {
            Line[] bufArr = new Line[Length + 1];

            for (int i = 0; i < Length; i++)
            {
                bufArr[i] = array[i];
            }

            Length += 1;

            bufArr[Length - 1] = l;

            array = bufArr;
        }
        //Удаление линии из массива
        public void DeleteLine(int index)
        {
            Line[] bufArr = new Line[Length - 1];

            for (int i = 0; i < index; i++)
                bufArr[i] = array[i];
            for (int i = index; i < Length - 1; i++)
                bufArr[i] = array[i + 1];

            Length -= 1;
            array = bufArr;
        }

        //Очистка индексов текущих линий
        public void CurrentLinesClear()
        {
            IndexCurrent = null;
        }
        //Добавление текущей линии
        public void CurrentLinesAdd(int index)
        {
            if (IndexCurrent != null)
            {
                int[] bufArr = new int[IndexCurrent.Length + 1];

                for (int i = 0; i < IndexCurrent.Length; i++)
                    bufArr[i] = IndexCurrent[i];

                bufArr[bufArr.Length - 1] = index;

                IndexCurrent = bufArr;
            }
            else
            {
                IndexCurrent = new int[1];
                IndexCurrent[0] = index;
            }

        }
        //Удаление линии из массива текущих
        public void CurrentLinesRem(int index)
        {
            int[] bufArr = new int[IndexCurrent.Length - 1];

            for (int i = 0; i < IndexCurrent.Length; i++)
                if (IndexCurrent[i] != index) bufArr[i] = IndexCurrent[i];
            IndexCurrent = bufArr;
        }
        //Поиск индекса в массиве индексов
        public bool SearchIndexCurrent(int index)
        {
            if (IndexCurrent != null)
            {
                for (int i = 0; i < IndexCurrent.Length; i++)
                    if (IndexCurrent[i] == index) return true;
            }
            return false;
        }
        //Удаление выделенных линий
        public void CurrentLineDelete()
        {
            if (IndexCurrent != null)
            {
                Line[] bufArr = new Line[Length - IndexCurrent.Length];

                for (int i = 0, j = 0; j < Length; i++, j++)
                    if (!SearchIndexCurrent(j))
                        bufArr[i] = array[j];
                    else i--;

                Length -= IndexCurrent.Length;
                IndexCurrent = null;
                array = bufArr;
            }
        }
    }
}
