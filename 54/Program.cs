/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


int[,] FillArray()
{

    int[,] NullAndOne = new int[3, 4];
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
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortRow (int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int n = 0; n < Array.GetLength(1) - 1; n++)
            {
                if (Array[i, n] < Array[i, n + 1])
                {
                    int nam = Array[i, n + 1];
                    Array[i, n + 1] = Array[i, n];
                    Array[i, n] = nam;
                }
            }
        }
    }
}

int[,] Arr = FillArray();
PrintArray(Arr);
Console.WriteLine();
SortRow(Arr);
PrintArray(Arr);