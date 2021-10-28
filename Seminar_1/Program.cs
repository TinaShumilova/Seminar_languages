//Задача по смене мест
//int a = 1;
//int b = 3;
//Console.WriteLine("a = " + a + " b = " + b);
//Console.WriteLine("a = {0} b = {1}", a, b);
//Сonsole.WriteLine($"a = {a} b = {b}");
//int temp = a;
//a = b;
//b = temp;
//Console.WriteLine($"a = {a} b = {b}");
//Console.WriteLine($"a = {a} b = {b}");
//a = a+b;
//b = a-b;
//a = a-b;
//Console.WriteLine($"a = {a} b = {b}");

//Задача на поиск максимального числа
int a = new Random().Next(1, 100);
int b = new Random().Next(1, 100);
Console.WriteLine(a);
Console.WriteLine(b);
if(a>b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
}