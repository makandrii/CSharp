using System;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Варіант 6***");

            int nn, nk;
            double result = 0;
            bool isNnOk = false, isNkOk = false;

            do
            {
                do
                {
                    Console.Write("Введіть перший індекс. nn = ");
                    isNnOk = int.TryParse(Console.ReadLine(), out nn);
                    if (!isNnOk)
                        Console.WriteLine("Помилка введення. Спробуйте ще раз.");
                } while (!isNnOk);

                do
                {
                    Console.Write("Введіть другий індекс. nk = ");
                    isNkOk = int.TryParse(Console.ReadLine(), out nk);
                    if (!isNkOk)
                        Console.WriteLine("Помилка введення. Спробуйте ще раз.");
                } while (!isNkOk);
                if (!(0 <= nn && nn <= nk))
                    Console.WriteLine("Помилка введення. nn має бути більше нуля та менше nk.");
            } while (!(0 <= nn && nn <= nk));
            for (int k = nn; k <= nk; k++)
                result += (Math.Pow(-1, k * k + 1) * k * k - 2) / (3 * k * k - 2 * k);
            Console.WriteLine($"Сума з {nn} по {nk} елементів ряду дорівнює {result}");
            Console.ReadKey();
        }
    }
}
