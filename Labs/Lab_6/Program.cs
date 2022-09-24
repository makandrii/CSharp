namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());
            Reverse(userInput);
            Reverse("АБВ");
            Reverse(123.456);
            Reverse("АБВ,ГДЕ");
            int[] example = { 1, 2, 3, 4, 5, 6 };
            ReverseArray(ref example, out var result);
            foreach(int number in result)
                Console.Write($"{number} ");
            Console.ReadKey();
        }
        static void Reverse(ref char[] a, int i)
        {
            if (i == a.Length / 2)
                return;
            Reverse(ref a, i + 1);
            (a[i], a[a.Length - 1 - i]) = (a[a.Length - 1 - i], a[i]);
        }
        static void Reverse(int a)
        {
            char[] aString = a.ToString().ToCharArray();
            Reverse(ref aString, 0);
            Console.WriteLine(aString);
        }
        static void Reverse(string a)
        {
            string[] parts = a.Split(',');
            char[][] partsToChar = new char[parts.Length][];
            for (int i = 0; i < parts.Length; i++)
                partsToChar[i] = parts[i].ToCharArray();

            for (int i = 0; i < partsToChar.Length; i++)
            {
                Reverse(ref partsToChar[i], 0);
                Console.Write(partsToChar[i]);
                if (i == parts.Length - 1)
                    Console.WriteLine();
                else
                    Console.Write(',');
            }
        }
        static void Reverse(double a)
        {
            string[] parts = a.ToString().Split(',');
            char[] part1 = parts[0].ToCharArray();
            char[] part2 = parts[1].ToCharArray();
            Reverse(ref part1, 0);
            Reverse(ref part2, 0);
            Console.Write(part1);
            Console.Write('.');
            Console.WriteLine(part2);
        }
        static void ReverseArray(ref int[] array, out int[] result)
        {
            result = array;
            for (int i = 0; i < result.Length / 2; i++)
                (result[i], result[result.Length - 1 - i]) = (result[result.Length - 1 - i], result[i]);
        }
    }
}