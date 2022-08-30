// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int[,] num = new int[4, 6];

void FillMatrixRndNum(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100) / 10;
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

if (n > num.GetLength(0) || m > num.GetLength(1)) Console.WriteLine("Такого элемента в массиве нет");
else Console.WriteLine($"значение элемента равно {num[n - 1, m - 1]}");