namespace BaekJoon
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[,] chairNumbers = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < N; j++)
                {
                    chairNumbers[i, j] = int.Parse(row[j]);
                }
            }

            // 병합 정렬을 이용하여 특별상을 받을 수 있는 의자 찾기
            int specialChair = FindSpecialChair(chairNumbers, 0, 0, N - 1, N - 1);

            Console.WriteLine( specialChair);
        }

        static int FindSpecialChair(int[,] chairNumbers, int rowStart, int colStart, int rowEnd, int colEnd)
        {
            if (rowStart == rowEnd && colStart == colEnd)
            {
                return chairNumbers[rowStart, colStart];
            }

            int midRow = (rowStart + rowEnd) / 2;
            int midCol = (colStart + colEnd) / 2;

            int candidate1 = FindSpecialChair(chairNumbers, rowStart, colStart, midRow, midCol);
            int candidate2 = FindSpecialChair(chairNumbers, rowStart, midCol + 1, midRow, colEnd);
            int candidate3 = FindSpecialChair(chairNumbers, midRow + 1, colStart, rowEnd, midCol);
            int candidate4 = FindSpecialChair(chairNumbers, midRow + 1, midCol + 1, rowEnd, colEnd);

            int secondSmallest = FindSecondSmallest(candidate1, candidate2, candidate3, candidate4);

            return secondSmallest;
        }

        static int FindSecondSmallest(int a, int b, int c, int d)
        {
            int smallest = Math.Min(a, Math.Min(b, Math.Min(c, d)));
            int secondSmallest = int.MaxValue;

            if (a > smallest && a < secondSmallest)
                secondSmallest = a;
            if (b > smallest && b < secondSmallest)
                secondSmallest = b;
            if (c > smallest && c < secondSmallest)
                secondSmallest = c;
            if (d > smallest && d < secondSmallest)
                secondSmallest = d;

            return secondSmallest;
        }
    }
}

