//Задача 62: Заполните спирально массив 4 на 4.
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

