//Написать программу решения квадратных уравнений

//2x^2-5x+2=0

double ResultD(double k, double l, double m)
{
    double result = (k * k) - (4 * l * m);
    return result;
}
/*double ResultX(double arg1, double arg2, double arg3)
    {
        if(arg2 >= 0)
        {
            double Result1 = (-arg1 + Math.Sqrt(arg2)) / (2 * arg3);
            double Result2 = (-arg1 - Math.Sqrt(arg2)) / (2 * arg3);
            Console.WriteLine($"x1 = {Result1}, x2 = {Result2}.");
        }
        else
        {
            Console.WriteLine("Уравнение не имеет действительных корней");
        }
    }*/

double a = 2;
double b = -5;
double c = 2;

double D = ResultD(b, a, c);

if(D >= 0)
{
    double Result1 = (-b + Math.Sqrt(D)) / (2 * a);
    double Result2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"x1 = {Result1}, x2 = {Result2}.");
}
else
{
    Console.WriteLine("Уравнение не имеет действительных корней");
}

/*double x = ResultX(b, D, a);

Console.WriteLine(x);*/