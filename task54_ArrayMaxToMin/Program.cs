// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.WriteLine("Please insert number of rows in array");
int rows=int.Parse(Console.ReadLine());

Console.WriteLine("Please insert number of columns in array");
int columns=int.Parse(Console.ReadLine());

int[,] array=GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
ArrayMaxToMin(array);
PrintArray(array);


int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result=new int [rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i,j]=new Random().Next(minValue, maxValue+1);

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
 
void ArrayMaxToMin (int [,] inArray)
{
    int rowsinArray=inArray.GetLength(0);
    int colsinArray=inArray.GetLength(1);  
    
    int tmp=0;
    for (int i = 0; i < rowsinArray; i++)
    {
        for (int j = 0; j < colsinArray; j++)
        {
            for (int k = 0; k < colsinArray-1; k++)
            {
            if (inArray[i,colsinArray-(k+1)]>inArray[i,colsinArray-(k+1)-1])
            {
                tmp=inArray[i,colsinArray-(k+1)];
                inArray[i,colsinArray-(k+1)]=inArray[i,colsinArray-(k+1)-1];
                inArray[i,colsinArray-(k+1)-1]=tmp;
            }  
            }
        }
    }                                                                                  
}



    