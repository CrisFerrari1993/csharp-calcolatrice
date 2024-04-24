using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    static public class CalcoliHelper
    {
        public static int Somma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static double Somma(double n1, double n2)
        {
            return n1 + n2;
        }

        public static int Differenza(int n1, int n2)
        {
            return n1 - n2;
        }

        public static double Differenza(double n1, double n2)
        {
            return n1 - n2;
        }

        public static int Moltiplica(int n1, int n2)
        {
            return n1 * n2;
        }

        public static double Moltiplica(double n1, double n2)
        {
            return n1 * n2;
        }

        public static int ValoreAssoluto(int n)
        {
            if (n < 0)
            {
                return -n;
            }
            return n;
        }

        public static double ValoreAssoluto(double n)
        {
            if (n < 0)
            {
                return -n;
            }
            return n;
        }

        public static int Minimo(int n1, int n2)
        {
            if(n1 < n2)
            {
                return n1;
            }
            return n2;
        }

        public static double Minimo(double n1, double n2)
        {
            if (n1 < n2)
            {
                return n1;
            }
            return n2;

        }

        public static int Massimo(int n1, int n2)
        {
            if(n1 > n2)
            {
                return n1;
            }
            return n2;

        }
        public static double Massimo(double n1, double n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            return n2;
        }

        // Bouns
        public static decimal Potenza(decimal numBase, int esponente)
        {
            if (numBase == 0)
            {
                return 1;
            }
            if(esponente < 0)
            {
                esponente = -esponente;
                numBase = 1 / numBase;
            }
            if(esponente == 0)
            {
                return 1;
            }
            return numBase * Potenza(numBase, esponente - 1);
        }


    }
}
