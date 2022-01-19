/*
 * https://github.com/nowakjulia/RownaniaKwadratoweTestyJednostkowe  <- Link do Github
 * */




using System;


namespace RownanieKwadratowe1
{
    public class RownanieKwadratowe
    {
        public
             double a, b, c, x1, x2, delta;


        public void podajWartosci()
        {
            try
            {
                Console.WriteLine("Podaj wartość a,b,c. Każdą zatwierdź Enterem");
                a = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Wartość a nie może być zerem. Kończę program");
                    Environment.Exit(0);
                }
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Nieprawidłowe dane, kończę program");
                Environment.Exit(0);
            }
        }


        

        public void liczRownanie()
        {
            delta = (b * b) - 4 * a * c;

            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1= " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("x0= " + x1);
            }
            if (delta < 0)
                Console.WriteLine("Delta ujemna. Brak miejsc zerowych");

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator funkcji kwadratowej");
            RownanieKwadratowe dzialanie = new RownanieKwadratowe();
            dzialanie.podajWartosci();
            dzialanie.liczRownanie();
            Console.Write("Naciśnij <Enter> aby wyjść... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
