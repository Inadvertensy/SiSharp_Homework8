// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] Array1=new int[,]
{
    {2,4},
    {3,2},
};
int [,] Array2=new int[,]
{
    {3,4},
    {3,3},
};
int [,] Array3=new int [,]
{
    {0,0},
    {0,0},
};

void MatrixPow(int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = i; j < inArray.GetLength(1)-1; j++)
        {
            inArray[i,j]=Array1[i,j]*Array2[i,j]+Array1[i,j+1]*Array2[i+1,j];
            
            inArray[i,j+1]=Array1[i,j]*Array2[i,j+1]+Array1[i,j+1]*Array2[i+1,j+1];
            
            inArray[i+1,j]=Array1[i+1,j]*Array2[i+1,j+1]+Array1[i+1,j+1]*Array2[i+1,j];

            inArray[i+1,j+1]=Array1[i+1,j]*Array2[i,j+1]+Array1[i+1,j+1]*Array2[i+1,j+1];
           
        }
    }
}
PrintArray(Array1);
PrintArray(Array2);

MatrixPow(Array3);
PrintArray(Array3);


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