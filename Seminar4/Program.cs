/* Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе. */

int NumOfDigits(int num)
{
    int count = 0;

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

