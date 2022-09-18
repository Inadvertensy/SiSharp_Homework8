// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.WriteLine("Please insert number of rows in array");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Please insert number of columns in array");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
RowWithMinSum(array);


int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);

        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void RowWithMinSum(int[,] inArray)
{
    int rowsinArray = inArray.GetLength(0);
    int colsinArray = inArray.GetLength(1);
    int sumRow = 0;
    int[] ArrayOfSums = new int[rowsinArray];
    int minIndex = 0;
    int minArrayOfSums=0;

    for (int i = 0; i < rowsinArray; i++)
    {
        for (int j = 0; j < colsinArray; j++)
        {
            sumRow = sumRow + inArray[i, j];
           
        }
        Console.WriteLine($"Sum of line {i}={sumRow}");
        ArrayOfSums[i] = sumRow;
        // Console.WriteLine(String.Join(",", ArrayOfSums));
        for (int k = 0; k < ArrayOfSums.Length; k++)
        {
            if (ArrayOfSums[k]<ArrayOfSums[minArrayOfSums])
            {
                minArrayOfSums=k;
            }
        }
        sumRow = 0;
    }
    Console.WriteLine($"Index min = {minArrayOfSums}");
}
