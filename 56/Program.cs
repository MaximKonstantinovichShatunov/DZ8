/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

PrintArray(array);
SortArray(array);
Console.WriteLine("Массив после сортировки:");
PrintArray(array);*/


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
int[,] Arr = FillArray();

int SummaLine(int[,] array, int i)
{
    int summa = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        summa += array[i, j];
    }
    return summa;
}

int GetMinLine (int[,] inArray)
{
int minLine = 1;
int summa = SummaLine(inArray, 0);
for (int i = 1; i < inArray.GetLength(0); i++)
{
    int temp = SummaLine(inArray, i);
    if (temp<summa)
    {
        summa = temp;
        minLine = i+1;
    }
}
return minLine;
}

PrintArray(Arr);
Console.WriteLine("Строка с наименьшей суммой: " + GetMinLine(Arr));