/*
Программа выводит числа от 1 до 5

void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}

ShowNums(5);
*/

/*
Программа принимает на вход некоторое число и возвращает сумму
цифр этого числа

int GetSumOfDigits(int num)
{
    if(num != 0) return GetSumOfDigits(num / 10) + num % 10;
    else return 0;
}

Console.Write(GetSumOfDigits(417));
*/

/*
Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.

void NatInMN(int numM, int numN)
{
    if(numM < numN) 
    {
        NatInMN(numM, numN - 1);
        Console.Write(numN + " ");
    }
    if(numM > numN) 
    {
        Console.Write(numM + " ");
        NatInMN(numM - 1, numN);
    }
    if(numM == numN) Console.Write(numM + " ");
}

Console.Write("Input M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int numN = Convert.ToInt32(Console.ReadLine());
NatInMN(numM, numN);
*/

/*
Напишите программу, которая на вход принимает два числа A и B,
и возводит число A в целую степень B.

double Power(int basic, int degree)
{
    if(degree > 0) return Power(basic, degree - 1) * basic;
    else if(degree < 0) return Power(basic, degree + 1) / basic;
    else return 1;
}
Console.WriteLine(Power(2,-3));
*/