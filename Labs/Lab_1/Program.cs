using System;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Варіант 6***");

            int H, R;
            double V;
            bool isHOk = false, isROk = false;

            do
            {
                Console.Write("Введіть висоту циліндра. H = ");
                isHOk = int.TryParse(Console.ReadLine(), out H);
                if (!isHOk)
                    Console.WriteLine("Помилка введення. Спробуйте ще раз.");
            } while (!isHOk);

            do
            {
                Console.Write("Введіть радіус основи циліндра. R = ");
                isROk = int.TryParse(Console.ReadLine(), out R);
                if (!isROk)
                    Console.WriteLine("Помилка введення. Спробуйте ще раз.");
            } while (!isROk);
            V = Math.PI * R * R * H;
            Console.WriteLine($"Об'єм циліндра. V = {V}");
            Console.ReadKey();
        }
    }
}
