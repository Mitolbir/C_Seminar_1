/*
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
