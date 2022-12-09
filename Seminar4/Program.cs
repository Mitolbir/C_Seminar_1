/* Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.

int NumOfDigits(int num)
{
    int count = 0;
    if (num == 0) count = 1;
    while(num != 0)
    {
        count++;
        num /= 10;
    }
    return count;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumOfDigits(number);

Console.WriteLine($"Number of digits in {number} is {result}");
*/
/*
Напишите программу, которая принимает на вход 
число (А) и выдаёт сумму чисел от 1 до А.

int SumOfNums(int num)
{
    int sum = 1;
    while(num > 1)
    {
        sum += num;
        num--;
    }
    return sum;
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumOfNums(number);
Console.WriteLine($"SumOfNums of numbers from 1 to N is {result}");
*/

/*
Напишите программу, которая принимает на вход 
число N и выдаёт произведение чисел от 1 до N.

int Factorial(int num)
{
    int fact = 1;
    //while(num > 1)
    //{
    //    fact *= num;
    //    num--;
    //}
    for (int i = 2; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Factorial(number);
Console.WriteLine($"Factorial of number is {result}");
*/