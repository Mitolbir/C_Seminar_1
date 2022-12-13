/* 
Задайте массив из 12 элементов, заполненный 
случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных элементов массива.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Conslole.Write(array[i] + " ");
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

int GetSumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0) 
            sum += array[i];

    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = GetSumOfNegatives(myArray);
Console.WriteLine("Sum of negatives elements is " + result);
*/
/*
Напишите программу замена элементов массива: 
положительные элементы замените на 
соответствующие отрицательные, и наоборот.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Conslole.Write(array[i] + " ");
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

int[] revers(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
} 

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

Console.WriteLine();
int[] result = revers(myArray);
ShowArray(result);
*/

/*
Задайте одномерный массив из m случайных чисел. 
Найдите количество элементов массива, значения 
которых лежат в отрезке [a,b].

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Conslole.Write(array[i] + " ");
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

int MultipliedArray(int[] array, int a, int b)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= a && array[i] <= b)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
int count = MultipliedArray(myArray, a, b);
Console.Write("Number of indexes from a to b: " + count);
*/

/*
Найдите произведение пар чисел в одномерном 
массиве. Парой считаем первый и последний 
элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Conslole.Write(array[i] + " ");
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

int[] MultPairs(int [] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 != 0)
    {
        size++;
    }
    int [] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = array[i] * array[array.Length-1-i];
    }
    return newArray;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
Console.WriteLine();
int[] result = MultPairs(myArray);
ShowArray(result);
*/