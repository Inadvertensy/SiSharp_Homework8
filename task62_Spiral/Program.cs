// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] array=GetArray(4,4);

Console.WriteLine();
Spiral(array);
PrintArray(array);

int[,] GetArray(int rows, int columns)
{
    int[,] result=new int [rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i,j]=1;

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
            if (inArray[i,j]<10)
            {
                Console.Write($"0{inArray[i, j]} ");
            }
            else
            {
               Console.Write($"{inArray[i, j]} "); 
            }
            
        }
        Console.WriteLine();
    }
}


void Spiral(int [,] inArray)
{
    int rows = inArray.GetLength(0);
    int cols = inArray.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < j; k++)
             {
                if (i==0)
                {
                inArray[i,j]=inArray[i,j]+1;
                }
                if (i==1 & j==cols-1)
                {
                inArray[i,j]=inArray[i,j]+1;
                inArray[i+1,j]=inArray[i,j]+1;
                inArray[i+1+1,j]=inArray[i,j]+1+1;

                inArray[i+1+1,cols-1-1]=inArray[i,j]+1+1+1;
                inArray[i+1+1,cols-1-1-1]=inArray[i,j]+1+1+1+1;
                inArray[i+1+1,cols-1-1-1-1]=inArray[i,j]+1+1+1+1+1; 

                inArray[i+1,cols-4]=inArray[i,j]+6;
                inArray[i,cols-4]=inArray[i,j]+7;
                inArray[i,cols-3]=inArray[i,j]+8;
                }
             }
        }
            if (i==1)
             {
                inArray[i,cols-2]=inArray[i,cols-2]+13;
                inArray[i+1,cols-2]=inArray[i,cols-2]+1;
                inArray[i+1,cols-3]=inArray[i,cols-2]+2;
             }
    }
}