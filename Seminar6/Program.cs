/*
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - 
на последнем и т.д.)

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

void ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/
/*
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.

bool IsTriangle(int first, int second, int third)
{
    if (first > second + third || second > first + third || third > second + first)
        return false;
    else return true;
}

Console.Write("Enter first side: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second side: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third side: ");
int third = Convert.ToInt32(Console.ReadLine());

bool result = IsTriangle(first, second, third);
string answer = result ==true? "Triangle can be": "Triangle can not be";
Console.WriteLine(answer);
*/

/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: a и b.

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Conslole.Write(array[i] + " ");
        Console.WriteLine($"array[{i}] is {array[i]}");
    }
}

int[] Fibonacci(int a, int b, int size)
{
    int[] fibArray = new int[size];
    fibArray[0] = a;
    fibArray[1] = b;
    for(int i = 2; i < size; i++)
    {
        fibArray[i] = fibArray[i-1] + fibArray[i-2];
    }
    return fibArray;
}

Console.Write("Enter size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first value: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second value: ");
int second = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fibonacci(first,second,size);
ShowArray(myArray);
*/

/*
Напишите программу, которая будет создавать копию заданного 
массива с помощью поэлементного копирования.

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

int[] CopyArray (int[] array)
{
    int[] copyArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];
    return copyArray;
}

Console.Write("Enter size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
int[] copyArray = CopyArray(myArray);

ShowArray(myArray);
ShowArray(copyArray);
*/