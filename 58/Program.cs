/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


int[,] FillArray()
{

    int[,] NullAndOne = new int[4, 4];
    for (int i = 0; i < NullAndOne.GetLength(0); i++)
    {
        for (int j = 0; j < NullAndOne.GetLength(1); j++)
        {
            NullAndOne[i, j] = new Random().Next(0, 10);
        }
    }
    return NullAndOne;
}

void PrintArray(int[,] Array)


{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int[,] productMatrix( int [,] matrix1, int[,] matrix2){
    int[,] matrix = new int [4,4];
   for (int i = 0; i < matrix1.GetLength(0); i++)
   {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix1.GetLength(0); k++)
        {
            matrix[i,j]+=matrix1[i,k]*matrix2[k,j];
        }
    }
   }
   return matrix; 
}

int[,] matrix1 = FillArray();
int[,] matrix2 = FillArray();
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine("Произведение двух матриц:");
int[,] Matrix = productMatrix(matrix1,matrix2);
PrintArray(Matrix);