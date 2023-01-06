// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] CreateArray(int rows, int cols, int min, int max)
{
    int [,] array = new int [rows,cols];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<cols; j++)
        {
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

void ShowArray(int [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void ShowElement(int [,] array, int row, int col)
{
    if (row<=array.GetLength(0) && col<=array.GetLength(1))
    {
        Console.Write($"Значение выбранного элемента: {array[row-1,col-1]}");
    }
    else Console.Write("Такого элемента нет");
}

Console.Write("Введите количество рядов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = CreateArray(m,n,0,9);
ShowArray(array);
Console.Write("Введите ряд элемента массива: ");
int ro = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента массива: ");
int co = Convert.ToInt32(Console.ReadLine());
ShowElement(array, ro, co);
