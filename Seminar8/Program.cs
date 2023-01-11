﻿/*
Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void Reverse2dArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0) - 1; i++)
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array [j,i];
                array[j,i] = temp;
            }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Reverse2dArray(myArray);
Show2dArray(myArray);
*/

/*
Задайте двумерный массив. Напишите программу, 
которая поменяет местами любые 2 строки массива.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void CreateNewArray(int[,] array, int numA, int numB)
{
    if(numA != numB && numA >= 0 && numB >= 0 && numA < array.GetLength(0) && numB < array.GetLength(0))
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[numA,j];
            array [numA,j] = array [numB,j];
            array[numB,j] = temp;
        }
    }
    else Console.WriteLine("Incorrect");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine("Input first row: ");
int indA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second row: ");
int indB = Convert.ToInt32(Console.ReadLine());

CreateNewArray(myArray, indA, indB);
Show2dArray(myArray);
*/

/*
Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int[] MinElement(int[,] array)
{
    int[] min = new int[2];
    int temp = array[0,0];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < temp)
            {
                temp = array[i,j];
                min[0] = i;
                min[1] = j;
            }
        }
    }
    return min;
}

int[,] CutArray(int[,] array, int minI, int minJ)
{
    int[,] cutArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    for(int i = 0, x = 0; i < array.GetLength(0); i++, x++)
    {
        if(i != minI)
        {
            for(int j = 0, y = 0; j < array.GetLength(1); j++, y++)
            {
                if(j != minJ)
                {
                    cutArray[x,y] = array[i,j];
                }
                else y--;
            }
        }
        else x--;
    }
    return cutArray;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int[] minArray = MinElement(myArray);
int[,] cutNewArray = CutArray(myArray, minArray[0], minArray[1]);
Show2dArray(cutNewArray);
*/