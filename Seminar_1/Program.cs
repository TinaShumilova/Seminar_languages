//Задача по смене мест
int a = 1;
int b = 3;
//Console.WriteLine("a = " + a + " b = " + b);
//Console.WriteLine("a = {0} b = {1}", a, b);
Console.WriteLine($"a = {a} b = {b}");
int temp = a;
a = b;
b = temp;
Console.WriteLine($"a = {a} b = {b}");