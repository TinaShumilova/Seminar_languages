/*
Почувствуй себя интерном
 0. Вывести квадрат числа
 1. По двум заданным числам проверять является ли первое квадратом второго
 2. Даны два числа. Показать большее и меньшее число
 3. По заданному номеру дня недели вывести его название
 4. Найти максимальное из трех чисел
 5. Написать программу вычисления значения функции y=f(a)
 6. Выяснить является ли число чётным
 7. Показать числа от -N до N
 8. Показать четные числа от 1 до N
 9. Показать последнюю цифру трёхзначного числа
10. Показать вторую цифру трёхзначного числа
11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
12. Удалить вторую цифру трёхзначного числа
13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
14. Найти третью цифру числа или сообщить, что её нет
*/


//0. Вывести квадрат числа
Console.WriteLine("0. Вывести квадрат числа");

int MyDouble(int n)
{
    int b = n * n;
    return b;
}

Console.WriteLine(MyDouble(5));

//1. По двум заданным числам проверять является ли первое квадратом второго

void MyScuare(int a, int b)
{
    if (a == b * b)
    {
        Console.WriteLine("первое квадрат второго");
    }
    else
    {
        Console.WriteLine("первое не является квадратом второго");
    }

}

int a1 = 25;
int b2 = 5;

Console.WriteLine($"1. По двум заданным числам проверять является ли первое ({a1}) квадратом второго ({b2})");
MyScuare(a1, b2);

//2. Даны два числа. Показать большее и меньшее число

void MaxMin(int a, int b)
{
    if (a > b)
    {
        Console.WriteLine($" max = {a}, min = {b}");
    }
    else
    {
        Console.WriteLine($" max = {b}, min = {a}");
    }
}

Console.WriteLine($"2. Даны два числа {a1} и {b2}. Показать большее и меньшее число");

MaxMin(a1, b2);

// 3. По заданному номеру дня недели вывести его название
int num = 3;
Console.WriteLine($"3. По заданному номеру дня недели ({num}) вывести его название");

string[] day = new string[7] { "Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Sunday", "Saturday" };

void NumberDay(int number, string[] arrDay)
{
    if ((number >= 1) && (number <= 7))
    {
        Console.WriteLine(arrDay[number - 1]);
    }
    else
    {
        Console.WriteLine("неверный номер");
    }
}

NumberDay(num, day);

// 3-я задача с вызовом числа из консоли
/*
string[] day = new string[7] { "Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Sunday", "Saturday" };
int d = int.Parse(Console.ReadLine());
if ((d >= 1) && (d <= 7))
{
    Console.WriteLine(day[d - 1]);
}
else
{
    Console.WriteLine("неверный номер");
}
*/

//4. Найти максимальное из трех чисел

int max3(int a, int b, int c)
{
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    return max;
}

int c3 = 9;
Console.WriteLine($"Найти максимальное из трех чисел ({a1}, {b2}, {c3})");
Console.WriteLine(max3(a1, b2, c3));

//5. Написать программу вычисления значения функции y=f(a)
// f = sin
Console.WriteLine($"5. Написать программу вычисления значения функции y=sin({a1})");
double func(double a)
{
    double res = Math.Sin(a);
    return res;
}

double y = func(a1);
Console.WriteLine(y);

// 6. Выяснить является ли число чётным
string Numb(int num)
{
    string text = "нет";
    if (num % 2 == 0)
    {
        text = "да";
    }
    return text;
}

int d4 = 8;
Console.WriteLine($"является ли число ({d4}) чётным?");
Console.WriteLine(Numb(d4));

// 7. Показать числа от -N до N
int e5 = -5;
int f6 = 5;
Console.WriteLine($"Показать числа от {e5} до {f6}");

int MyLenght(int minNum, int maxNum)
{
    int length = 0;
    if (minNum < 0 && maxNum > 0)
    {
        length = length + (maxNum - minNum + 1);
    }
    if (minNum > 0 && maxNum > 0)
    {
        length = length + maxNum;
    }
    if (minNum < 0 && maxNum < 0)
    {
        length = length - minNum;
    }
    if (minNum == 0)
    {
        length = length + (maxNum + 1);
    }
    if (maxNum == 0)
    {
        length = length - (minNum - 1);
    }
    return length;
}

int[] MyArray(int minN, int maxN)
{
    int[] array = new int[MyLenght(minN, maxN)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = minN;
        minN++;
    }
    return array;
}

void PrintMyArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] myArray = MyArray(e5, f6);

PrintMyArray(myArray);
Console.WriteLine();

//8. Показать четные числа от 1 до N

int N = 13;
Console.WriteLine($"Показать четные числа от 1 до {N}");
int[] newArray = MyArray(1, N);
PrintMyArray(newArray);
Console.WriteLine();

// 9. Показать последнюю цифру трёхзначного числа
int hundred = 867;
Console.WriteLine($"Показать последнюю цифру трёхзначного числа {hundred}");

int FindeLast(int num)
{
    int o = -1;
    if (num >= 100 && num < 1000)
    {
        o = num % 10;
    }
    if (num <= -100 && num > -1000)
    {
        o = (num % 10) * -1;
    }
    return o;
}

void PrintAnswe(int nom)
{
    int answer = FindeLast(nom);
    if (answer == -1)
    {
        Console.WriteLine("Неверно заданое число");
    }
    else
    {
        Console.WriteLine(answer);
    }
}

PrintAnswe(hundred);

//10. Показать вторую цифру трёхзначного числа
Console.WriteLine($"Показать вторую цифру трёхзначного числа {hundred}");

int FindeSecond(int num)
{
    int o = -1;
    if (num >= 100 && num < 1000)
    {
        o = (num % 100) / 10;
    }
    if (num <= -100 && num > -1000)
    {
        o = ((num % 100) / 10) * -1;
    }
    return o;
}
void PrintAnswer(int nom)
{
    int answer = FindeSecond(nom);
    if (answer == -1)
    {
        Console.WriteLine("Неверно заданое число");
    }
    else
    {
        Console.WriteLine(answer);
    }
}

PrintAnswer(hundred);

//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int min = 10;
int max = 99;
int nomb = new Random().Next(min, max + 1);
Console.WriteLine($"Дано число из отрезка [10, 99]. Показать наибольшую цифру числа {nomb}");

int FindNumber(int k)
{
    int first = k / 10;
    int second = k % 10;
    if (first > second)
    {
        return first;
    }
    else
    {
        return second;
    }
}

Console.WriteLine(FindNumber(nomb));

//12. Удалить вторую цифру трёхзначного числа

Console.WriteLine($"Удалить вторую цифру трёхзначного числа {hundred}");

int DelNum(int count)
{
    int temp = count / 100;
    int temp2 = count % 10;
    count = temp * 10 + temp2;
    return count;
}


int delSecNum = DelNum(hundred);
Console.WriteLine(delSecNum);

//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
int m = 43;
int n = 18;
Console.WriteLine($"Кратно ли число {m} заданному {n}, если нет, вывести остаток");
void Multiplicitu(int first, int second)
{
    if (first > second)
    {
        if (first % second == 0)
        {
            Console.WriteLine($"Число {first} кратное числа {second}");
        }
        else
        {
            Console.WriteLine($"Остаток = {first % second}");
        }
    }
    else
    {
        Console.WriteLine($"неверно заданы параметры чисел.");
    }
}

Multiplicitu(m, n);

//14. Найти третью цифру числа или сообщить, что её нет

int tem = -899;
int ThirdNum(int coun)
{
    int result = 0;
    if(coun >= 1000)
    {
        result = coun % 1000;
        result = result / 100;
    }
    if(coun <= -1000)
    {
        result = coun % 1000;
        result = result / 100 * -1;
    }
    if(coun >= 100 && coun < 1000)
    {
        result = coun / 100;
    }
    if(coun <= -100 && coun > -1000)
    {
        result = coun / 100 * -1;
    }
    return result;
}

void PrintResult(int cou)
{
    if(cou >= 100 || cou <= -100)
    {
        Console.WriteLine(ThirdNum(cou));
    }
    else
    {
        Console.WriteLine("В заданном числе нет третьей цифры");
    }
}

PrintResult(tem);
