// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine($"\n\nЗадача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");


Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);



Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

int[,] arrayWhole = new int[m, n];
arrayWhole = TransformationArrayWhole(array);

WriteArrayInt(arrayWhole);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += arrayWhole[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / m, 1);
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}

int[,] TransformationArrayWhole (double[,] array)
{
  int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayWhole;
}

void WriteArrayInt (int[,] arrayWhole){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(arrayWhole[i, j] + " ");
      }
      Console.WriteLine();
  }
}