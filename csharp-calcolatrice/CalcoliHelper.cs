using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    static class CalcoliHelper
    {
        
        // i metodi ripetuti piu volte negli oggetti vengono definiti overload di metodi 🤓
        // I parametri sono stati costruiti per accettare float, double, int, decimal, long.
        public static string Somma<T>(T n1, T n2) where T : INumber<T>
        {
            return $"La somma di {n1} e {n2} è di: {n1 + n2}";
        }
        public static string Differenza<T>(T n1, T n2) where T : INumber<T>
        {
            return $"La differenza fra {n1} e {n2} è di: {n1 - n2}";
        }
        public static string Moltiplicazione<T>(T n1, T n2) where T : INumber<T>
        {
            return $"Il risultato della moltiplicazione fra {n1} e {n2} è di: {n1 * n2}";
        }
        public static string ValoreABS(int n)
        {
            return $"Il valore assoluto di {n} è di: {Math.Abs(n)}";
        }
        public static string ValoreABS(double n)
        {
            return $"Il valore assoluto di {n} è di: {Math.Abs(n)}";
        }
        public static string Minimo<T>(T n1, T n2) where T : INumber<T>
        {
            if (n1 < n2) return $"Il valore minimo fra {n1} e {n2} è: {n1}";
            else return $"Il valore minimo fra {n1} e {n2} è: {n2}";
        }
        public static string Massimo<T>(T n1, T n2) where T : INumber<T>
        {
            if (n1 > n2) return $"Il valore massimo fra {n1} e {n2} è: {n1}";
            else return $"Il valore massimo fra {n1} e {n2} è: {n2}";
        }
        // **************BONUS*****************
        public static string Potenza(int Base, int Esponente)
        {
            double res = 1;

            //Se l'esponente è positivo, moltiplica la base per se stessa esponente volte
            if(Esponente > 0)
            {
                for(int i = 0; i < Esponente; i++)
                {
                    res *= Base;
                }
            }
            // Se l'esponente è negativo, calcola l'inverso della potenza positiva
            else if (Esponente < 0)
            {
                Esponente.ToString().Remove(0, 1);
                Esponente = (int)Esponente;
                for (int i = 0; i < Esponente; i++)
                {
                    res /= Base;
                }
            } 
            // Se l'esponente è zero, il risultato è 1
            // (poiché qualsiasi numero elevato alla potenza 0 è uguale a 1)

            return $"La potenza di {Base} alla {Esponente} è di: {(int)res}";
        }
    }
}
