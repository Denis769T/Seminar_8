//Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

void Massive(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
                Console.Write($"{matrix[i, j]}  ");
            else
                Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Заполняем массив 4 Х 4:");
int n = 4;
int[,] Matrix = new int[n, n];
int num = 1;
int i = 0;
int j = 0;
while (num <= Matrix.GetLength(0) * Matrix.GetLength(1))
    {
        Matrix[i, j] = num; num++;
        if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= Matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > Matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
Massive(Matrix);

