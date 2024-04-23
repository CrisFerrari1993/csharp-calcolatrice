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
                            Console.WriteLine(CalcoliHelper.Somma(n1, n2));
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Differenza fra i numeri");
                            Console.WriteLine("Inserisci un numero");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Inserisci un'altro numero");
                            var n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine(CalcoliHelper.Differenza(n1, n2));
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Moltiplica i numeri");
                            Console.WriteLine("Inserisci un numero");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Inserisci un'altro numero");
                            var n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine(CalcoliHelper.Moltiplicazione(n1, n2));
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Valore assoluto di un numero");
                            Console.WriteLine("Inserisci un numero");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine(CalcoliHelper.ValoreABS(n1));
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Valore minimo fra due numeri");
                            Console.WriteLine("Inserisci un numero");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Inserisci un'altro numero");
                            var n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine(CalcoliHelper.Minimo(n1, n2));
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("Valore massimo fra due numeri");
                            Console.WriteLine("Inserisci un numero");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Inserisci un'altro numero");
                            var n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine(CalcoliHelper.Massimo(n1, n2));
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("Potenza di Un numero per esponente");
                            Console.WriteLine("Inserisci un numero per la base");
                            var n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Inserisci un'altro numero per l'esponente");
                            var n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine(CalcoliHelper.Potenza(n1, n2));
                            break;
                        }
                }
            }

        }
    }
}
