// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Numbers(string text)
{
  Console.Write(text);
  int numbers = Convert.ToInt32(Console.ReadLine());
  return numbers;
}

void printMassive(int[,] massive)
{
  for (int i = 0; i < massive.GetLength(0); i++)
  {
    for (int j = 0; j < massive.GetLength(1); j++)
    {
      Console.Write(massive[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

void genMassive(int[,] massive)
{
  for (int i = 0; i < massive.GetLength(0); i++)
  {
    for (int j = 0; j < massive.GetLength(1); j++)
    {
      massive[i, j] = new Random().Next(0,10);
    }
  }
}

void sortingMassive(int[,] massive)
{
  for (int i = 0; i < massive.GetLength(0); i++)
  {
    for (int j = 0; j < massive.GetLength(1); j++)
    {
      for (int k = 0; k < massive.GetLength(1) - 1; k++)
      {
        if (massive[i, k] < massive[i, k + 1])
        {
          int temp = massive[i, k + 1];
          massive[i, k + 1] = massive[i, k];
          massive[i, k] = temp;
        }
      }
    }
  }
}

Console.WriteLine($"Введите размер массива m(строки), n(столбцы):");
int m = Numbers("Введите m(строки): ");
int n = Numbers("Введите n(столбцы): ");
int[,] massive = new int[m, n];
genMassive(massive);
printMassive(massive);
Console.WriteLine($"Отсортированный массив: ");
sortingMassive(massive);
printMassive(massive);

