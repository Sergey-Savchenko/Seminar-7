// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void Count(int [,] array)
{
    double [] countarray = new double [array.GetLength(1)+1];
    for(int j=0; j<array.GetLength(1); j++)
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            countarray[j] = countarray[j] + array[i,j];
        }
        countarray[j] = countarray[j] / (array.GetLength(0));
        Console.WriteLine($"Среднее арифметическое {j+1} столбца: {countarray[j]}");
    }
}

Console.Write("Введите количество рядов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = CreateArray(m,n,0,9);
ShowArray(array);
Count(array);