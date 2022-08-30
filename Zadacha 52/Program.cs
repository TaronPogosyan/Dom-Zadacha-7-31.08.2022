// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] num = new int[n, m];

void FillMatrixRndNum(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // строки - row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы- col
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}
FillMatrixRndNum(num);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(j < matrix.GetLength(1) - 1 ?
            $"{matrix[i, j],2}; " : $"{matrix[i, j],2} ");
        }
        Console.WriteLine("|");

    }
}
PrintMatrix(num);
Console.WriteLine("");


for (int j = 0; j < num.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < num.GetLength(0); i++)
    {
        average = (average + num[i, j]);
    }
    average = average / n;
    Console.Write(Math.Round(average, 2) + "; ");

}
Console.WriteLine();
