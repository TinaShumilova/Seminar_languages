/*Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
Создать на его основе масив B, отбрасывая те, которые нарушают порядок

- возрастания
- элементы, больше 8
- знакочередования*/

Console.WriteLine();
Console.WriteLine("I. Создаём числовой массив A заполненный числами из отрезка [-10, 10].");
Console.WriteLine();
Console.Write("Массив А : ");

int length = 10;
int[] ArrayA = new int[length];
int index = 0;
while (index < length)
{
    ArrayA[index] = new Random().Next(-10,11);
    Console.Write($"{ArrayA[index]} ");
    index++;
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Создаём на его основе масив B, отбрасывая те элементы, которые");
Console.WriteLine();
Console.WriteLine("1. нарушают порядок возрастания,");
Console.WriteLine();

index = 1;
int temp = ArrayA[0];
Console.Write($"Массив В.1 : {temp} ");
while(index < length)
{
    if(ArrayA[index] > temp)
    {
        Console.Write($"{ArrayA[index]} ");
        temp = ArrayA[index];
    }
    index++;
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("2. больше 8,");
Console.WriteLine();

index = 0;
Console.Write("Массив В.2 : ");
while(index < length)
{
    if(ArrayA[index] < 8)
    {
        Console.Write($"{ArrayA[index]} ");
    }
    index++;
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("3. нарушают порядок знакочередования, ");
Console.WriteLine();

index = 1;
int count = 0;
temp = ArrayA[count];
int step = 0;
int temp2 = ArrayA[step];
Console.Write($"Массив В.3 : {temp} ");
while(index < length)
{
    if(temp > 0)
    {
        if(ArrayA[index] < 0);
        {
            Console.Write($"{ArrayA[index]} ");
        }
        temp = ArrayA[count + 2];
    }
    index = index + 2;
    if(temp2 < 0)
    {
        if(ArrayA[index] < 0);
        {
            Console.Write($"{ArrayA[index]} ");
        }
        temp2 = ArrayA[step + 2];
    }
    index = index + 2;
    
}
Console.WriteLine();


/*Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
Создать на его основе масив B, отбрасывая те элементы, которые

1. нарушают порядок возрастания
2. больше среднего арифметического элементов A
3. чётные*/
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("II. Создаём целочисленный массив A из натуральных двузначных чисел.");
Console.WriteLine();
Console.Write("Массив А : ");

length = 10;
int[] A = new int[length];
index = 0;
while (index < length)
{
    A[index] = new Random().Next(10, 100);
    Console.Write($"{A[index]} ");
    index++;
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Создаём на его основе масив B, отбрасывая те элементы, которые");
Console.WriteLine();
Console.WriteLine("1. нарушают порядок возрастания,");
Console.WriteLine();

index = 1;
temp = A[0];
Console.Write($"Массив В.1 : {temp} ");
while(index < length)
{
    if(A[index] > temp)
    {
        Console.Write($"{A[index]} ");
        temp = A[index];
    }
    index++;
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("2. больше среднего арифметического элементов A,");
Console.WriteLine();

double midA = 0;
index = 0;
while(index < length)
{
    midA = midA + A[index];
    index++;
}
midA = midA / length;
Console.WriteLine($"Среднее арифметическое элементов массива А = {midA}");
Console.WriteLine();

index = 0;
Console.Write("Массив В.2 : ");
while(index < length)
{
    if(A[index] < midA)
    {
        Console.Write($"{A[index]} ");
    }
    index++;
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("3. чётные.");
Console.WriteLine();

index = 0;
Console.Write("Массив В.3 : ");
while(index < length)
{
    if(A[index]%2 == 0)
    {
        Console.Write($"{A[index]} ");
    }
    index++;
}
Console.WriteLine();
Console.WriteLine();