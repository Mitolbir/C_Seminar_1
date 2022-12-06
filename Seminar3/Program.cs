/*
Напишите программу, которая принимает на вход 
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
и выдаёт номер четверти плоскости, 
в которой находится эта точка.

int FindQuadrant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input an x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

int quadNum = FindQuadrant(x, y);

Console.WriteLine($"The point A({x}, {y}) is on the {quadNum} quadrant");

Напишите программу, которая по заданному 
номеру четверти, показывает диапазон возможных 
координат точек в этой четверти (x и y).

void Coor(int chetv)
{
if(chetv == 1)
{
    Console.WriteLine("This quadrant have coordinate x from 0 to + and y from 0 to +");
}
if(chetv == 2)
{
    Console.WriteLine("This quadrant have coordinate x from 0 to - and y from 0 to +");
}
if(chetv == 3)
{
    Console.WriteLine("This quadrant have coordinate x from 0 to - and y from 0 to -");
}
if(chetv == 4)
{
    Console.WriteLine("This quadrant have coordinate x from 0 to + and y from 0 to -");
}
}

Console.WriteLine("Input quadrant number: ");
int chetvert = Convert.ToInt32(Console.ReadLine());
Coor(chetvert);

Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние 
между ними в 2D пространстве.

double Length(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

Console.WriteLine("Input coordinates of x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates of y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates of x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinates of y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double length = Length(x1, y1, x2, y2);

Console.WriteLine($"Your distanse from two dots is: {length}");
*/

/*
Напишите программу, которая принимает на вход 
число (N) и выдаёт ряд квадратов чисел от 1 до N.

*/

