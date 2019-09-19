using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KG_lab_1
{
    static class MatrOp
    {

        //Умножение матриц
        static public double[] Div13(double[] matr1, double[,] matr2)
        {
            double[] newMatr = new double[matr1.Length];

            for(int i = 0; i < matr1.Length; i++)
            {
                newMatr[i] = matr1[0] * matr2[0, i] + matr1[1] * matr2[1, i] + matr1[2] * matr2[2, i];
            }

            return newMatr;
        }

    }
}
