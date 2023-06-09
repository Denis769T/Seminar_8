//Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

int Numbers(string text)
{
  Console.Write(text);
  int numbers = Convert.ToInt32(Console.ReadLine());
  return numbers;
}


int SumMassive(int[,] massive, int i)
{
  int sum = massive[i,0];
  for (int j = 1; j < massive.GetLength(1); j++)
  {
    sum += massive[i,j];
  }
  return sum;
}

void GenMassive(int[,] massive)
{
  for (int i = 0; i < massive.GetLength(0); i++)
  {
    for (int j = 0; j < massive.GetLength(1); j++)
    {
      massive[i, j] = new Random().Next(0,9);
    }
  }
}

void PrintMassive (int[,] massive)
{
      for (int i = 0; i < massive.GetLength(0); i++)
  {
    int sumLine=0;
    for (int j = 0; j < massive.GetLength(1); j++)
    {
      Console.Write(massive[i,j] + "\t");
      sumLine += massive[i,j];
    }

    Console.Write($"   ({sumLine})");
    Console.WriteLine();
  }
}

Console.WriteLine($"Введите размерность массива m(строки)  n(столбцы) :");
int m = Numbers("Введите m(строки): ");
int n = Numbers("Введите n(столбцы): ");

int[,] massive = new int[m, n];
GenMassive(massive);
PrintMassive(massive);

int minSum = 0;
int sum = SumMassive(massive, 0);
for (int i = 1; i < massive.GetLength(0); i++)
{
  int tempSum = SumMassive(massive, i);
  if (sum > tempSum)
  {
    sum = tempSum;
    minSum = i;
  }
}

Console.WriteLine();
Console.WriteLine($"{minSum+1} - номер строки с наименьшей суммой.");
Console.WriteLine($"{sum} - cумма элементов этой строки.");

