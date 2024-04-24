using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    static public class Calcolatrice
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

        public static decimal Potenza(int numBase, int esponente)
        {
            decimal count = 1;
            for(int i = 0; i < esponente; i++)
            {
                count *= numBase;
            }

            if (esponente < 0)
            {
                esponente = -esponente;
                for(int i = 0; i < esponente; i++)
                {
                    count /= (numBase * esponente); 
                }
            }

            return (decimal)count;
            
        }

        public static decimal PotenzaVer2(int numBase, int esponente)
        {
            decimal count = numBase;
            decimal num = count;
            if(esponente < 0)
            {
                count = 1 / count;
                esponente = -esponente;
                num = count;

            }
            for(int i = 1; i < esponente; i++)
            {
                count *= num;
            }

            return count;
            

        }

        public static decimal PotenzaVer3(int numBase, int esponente)
        {
            decimal count = 1;
            for (int i = 0; i < ValoreAssoluto(esponente); i++)
            {
                count *= numBase;
            }
            if (esponente < 0)
            {
                count = 1 / count;
            }
            return count;
        }

        public static decimal PotenzaVer4(decimal numBase, int esponente)
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
            return numBase * PotenzaVer4(numBase, esponente - 1);
        }


    }
}
