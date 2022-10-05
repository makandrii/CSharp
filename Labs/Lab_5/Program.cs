namespace Lab_5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("***21 варіант***");
            const int rows = 4, cols = 10;
            int[,] matrix = new int[rows, cols];
            Random random = new();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = random.Next(10);

            Print(matrix);
            Console.WriteLine();

            int k1, k2;
            k1 = int.Parse(Console.ReadLine());
            k2 = int.Parse(Console.ReadLine());

            Swap(ref matrix, k1, k2, "row");
            Print(matrix);
            Console.WriteLine();

            Swap(ref matrix, k1, k2, "col");
            Print(matrix);
            Console.ReadKey();
        }
        public static void Swap(ref int[,] matrix, int k1, int k2, string type)
        {
            switch (type)
            {
                case "row":
                    for (int j = 0; j < matrix.Length / matrix.GetLength(k1); j++)
                        (matrix[k1, j], matrix[k2, j]) = (matrix[k2, j], matrix[k1, j]);
                    break;
                case "col":
                    for (int i = 0; i < matrix.GetLength(k1); i++)
                        (matrix[i, k1], matrix[i, k2]) = (matrix[i, k2], matrix[i, k1]);
                    break;
            }
        }
        public static void Print(in int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.Length / matrix.GetLength(0); j++)
                    Console.Write($"{matrix[i, j]}{((j + 1) % (matrix.Length / matrix.GetLength(0)) == 0 ? '\n' : '\t')}");
        }
    }
}
