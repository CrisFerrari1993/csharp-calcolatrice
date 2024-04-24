using System.Reflection.Metadata;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userChoice = "";
            
            while (userChoice != "esci")
            {
                Console.WriteLine("Scegli il tipo di operazione fra (1/Somma, 2/Differenza, 3/Moltiplicazione, 4/Valore assoluto, 5/Valore minimo, 6/Valore massimo, 7/Potenza)");
                userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        {
                            Console.WriteLine("Somma i numeri");
                            Console.WriteLine("Inserisci un numero");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Inserisci un'altro numero");
                            var n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"La somma di {n1} e {n2} è: {CalcoliHelper.Somma(n1, n2)}");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Differenza fra i numeri");
                            Console.WriteLine("Inserisci un numero");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Inserisci un'altro numero");
                            var n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"La differenza fra {n1} e {n2} è: {CalcoliHelper.Differenza(n1, n2)}");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Moltiplica i numeri");
                            Console.WriteLine("Inserisci un numero");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Inserisci un'altro numero");
                            var n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"La moltiplicazione fra {n1} e {n2} è di: {CalcoliHelper.Moltiplica(n1, n2)}");
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Valore assoluto di un numero");
                            Console.WriteLine("Inserisci un numero");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Il volre assoluto di {n1} è di: {CalcoliHelper.ValoreAssoluto(n1)}");
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Valore minimo fra due numeri");
                            Console.WriteLine("Inserisci un numero");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Inserisci un'altro numero");
                            var n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Il valore minimo dei numeri({n1}, {n2}) è: {CalcoliHelper.Minimo(n1, n2)}");
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("Valore massimo fra due numeri");
                            Console.WriteLine("Inserisci un numero");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Inserisci un'altro numero");
                            var n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Il valore massimo dei numeri({n1}, {n2}) è: {CalcoliHelper.Massimo(n1, n2)}");
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("Potenza di Un numero per esponente");
                            Console.WriteLine("Inserisci un numero per la base");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Inserisci un'altro numero per l'esponente");
                            var n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"La potenza del numero base {n1} alla {n2} è di: {CalcoliHelper.Potenza(n1, n2)}");
                            break;
                        }
                }
            }

        }
    }
}
