using System;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Варіант 4***");

            Console.Write("Введіть координати точки через пробіл: ");
            (float x, float y) point;
            string[] subStrings;
            do
            {
                subStrings = Console.ReadLine().Split(' ');
            } while (subStrings.Length <= 1);
            point.x = float.Parse(subStrings[0]);
            point.y = float.Parse(subStrings[1]);

            Console.Write("Введіть координати верхньої лівої точки прямокутника через пробіл: ");
            (float x, float y) topLeft;
            do
            {
                subStrings = Console.ReadLine().Split(' ');
            } while (subStrings.Length <= 1);
            topLeft.x = float.Parse(subStrings[0]);
            topLeft.y = float.Parse(subStrings[1]);
            
            Console.Write("Введіть координати нижньої правої точки прямокутника через пробіл: ");
            (float x, float y) botRight;
            do
            {
                subStrings = Console.ReadLine().Split(' ');
            } while (subStrings.Length <= 1);
            botRight.x = float.Parse(subStrings[0]);
            botRight.y = float.Parse(subStrings[1]);

            Console.WriteLine($"Точка належить прямокутнику: {topLeft.x < point.x && point.x < botRight.x && botRight.y < point.y && point.y < topLeft.y}");
            Console.ReadKey();
        }
    }
}
