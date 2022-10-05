using System.Collections.Generic;
namespace Lab_4
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("***21 варіант***");
            const int N = 10;
            int[] example = new int[N];
            Random random = new();
            for (int i = 0; i < N; i++)
                example[i] = random.Next(10);

            Console.Write("Початковий масив: ");
            Print(example);
            Console.WriteLine();

            Console.Write("1) ");
            Print(ClearSamples(example, 2, '<'));
            Console.WriteLine();

            Console.Write("2) ");
            Print(ClearSamples(example, 2, '>'));
            Console.WriteLine();

            Console.Write("3) ");
            Print(ClearSamples(example, 2, '='));
            Console.WriteLine();

            Console.Write("4) ");
            Print(ClearSamples(example, 3, '='));
            Console.WriteLine();
        }
        public static int[] ClearSamples(int[] a, int countOfSamples, char operation)
        {
            var samples = CountOfSamples(a);
            List<int> result = new(), willRemoved = new();
            foreach (var pair in samples)
            {
                if (ChooseOperation(operation)(pair.count, countOfSamples))
                {
                    willRemoved.Add(pair.value);
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (willRemoved.Contains(a[i]))
                    continue;
                result.Add(a[i]);
            }
            return result.ToArray();
        }
        public static List<(int value, int count)> CountOfSamples(int[] a)
        {
            List<(int value, int count)> result = new();
            for (int i = 0; i < a.Length; i++)
            {
                int counter = 1;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j] && i != j)
                        counter++;
                }
                result.Add((a[i], counter));
            }
            return result;
        }
        public static Action? ChooseOperation(char operation)
        {
            switch (operation)
            {
                case '=': return (int a, int b) => a == b;
                case '>': return (int a, int b) => a > b;
                case '<': return (int a, int b) => a < b;
                default: return null;
            }
        }
        public static void Print(in int[] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
                Console.Write($"{matrix[i]}\t");
        }
        public delegate bool Action(int a, int b);
    }
}