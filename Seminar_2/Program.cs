double ResultD(double k, double l, double m)
{
    double result = (k * k) - (4 * l * m);
    return result;
}

double[] FillResultX(double arg1, double arg2, double arg3)
{
    double Result1 = (-arg1 + Math.Sqrt(arg2)) / (2 * arg3);
    double Result2 = (-arg1 - Math.Sqrt(arg2)) / (2 * arg3);
    double[] Result = {Result1, Result2};
    return Result;
}

void PrintResultX(double[] array)
{
    int count = array.Length;
    int possition = 0;
    while(possition < count)
    {
        if(possition == 0)
        {
            Console.WriteLine($"x1 = {array[possition]}");
        }
        else
        {
            Console.WriteLine($"x2 = {array[possition]}");
        }
        possition++;
    }

}

Console.WriteLine("Решите квадратное уравнение 2*(x*x) + bx + c = 0");
Console.WriteLine();

Console.WriteLine("Введите значение A.");
Console.Write("a = ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение B.");
Console.Write("b = ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение C.");
Console.Write("c = ");
double c = double.Parse(Console.ReadLine());

Console.WriteLine();



double D = ResultD(b, a, c);

if(D >= 0)
{
    if(D > 0)
    {
        double [] answer = FillResultX(b, D, a);
        PrintResultX (answer);
    }
    else
    {
        double Result = (-b + Math.Sqrt(D)) / (2 * a);
        Console.WriteLine($"x = {Result}");
    }
}
else
{
    Console.WriteLine("Уравнение не имеет действительных корней");
}


/*if(D >= 0)
{
    double Result1 = (-b + Math.Sqrt(D)) / (2 * a);
    double Result2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"x1 = {Result1}, x2 = {Result2}.");
}
else
{
    Console.WriteLine("Уравнение не имеет действительных корней");
}*/

