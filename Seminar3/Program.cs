/*
Напишите программу, которая принимает на вход 
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
и выдаёт номер четверти плоскости, 
в которой находится эта точка.
*/

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