
//Почувствуй себя джуном
//15. Дано число. Проверить кратно ли оно 7 и 23
/*
string FindDel(int number)
{
    string text = $"Число {number} кратно 7 и 23";
    if(number%7 == 0 & number%23 == 0)
    {
        return text;
    }
    else
    {
        text = $"Число {number} не кратно 7 и 23";
        return text;
    }
}
Console.WriteLine(FindDel(a));
*/
//Вариант 2 ===============

bool Num(int number)
{
    return (number % 7 == 0 & number % 23 == 0);
}
int a = 161;
Console.WriteLine($"15. Дано число {a}. Кратно ли оно 7 и 23?");
Console.WriteLine(Num(a));

//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("16. Необходимо выяснить, является ли заданное число номером выходного дня недели.");
/*
string[] days = { "Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Sunday", "Saturday" };
string DayNum(string[] array, int num)
{
    string text = $"{num}-й день это выходной";
    for(int index = 0; index < (array.Length - 2); index++)
    {
        if(num == index+1)
        {
            text = $"{num}-й день это не выходной";
            return text;
        }
    }
    if(num == 6 || num ==7)
    {
        return text;
    }
    else
    {
        text = "Неверно задан номер";
        return text;
    }
}
int dayNumber = 0;
Console.WriteLine(DayNum(days, dayNumber));
*/
//Вариант 2 ===============

bool NumDay(int num)
{
    return (num == 6 | num == 7);
}

Console.Write("Введите число от 1 до 7: ");
for (int b = 1; b > 0; b++)
{
    int dayNum = int.Parse(Console.ReadLine());
    if (dayNum > 0 & dayNum < 8)
    {
        Console.WriteLine(NumDay(dayNum));
        break;
    }
    else
    {
        Console.WriteLine("Введите верное число");
    }
}


//17. По двум заданным числам проверять является ли одно квадратом другого
int c = 3;
int d = 9;
Console.WriteLine($"17. По заданным числам {c} и {d} необходимо проверить, является ли одно квадратом другого");

/*
string MyScuare(int number, int num)
{
    string text = $"Число {number} является квадратом числа {num}";
    if(number == num*num)
    {
        return text;
    }
    if(num == number*number)
    {
        text = $"Число {num} является квадратом числа {number}";
        return text;
    }
    else
    {
        text = $"Ниодно из заданных чисел не является квадратом другого числа";
        return text;
    }
}

Console.WriteLine(MyScuare(b, c));
*/
//Вариант 2 ===============

bool result(int a, int b)
{
    return (a == b * b | b == a * a);
}

Console.WriteLine(result(c, d));

//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

Console.WriteLine("Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y");

bool TrueOrFalse(bool agr1, bool agr2)
{
    bool result = false;
    if((!(agr1 || agr2)) == (!agr1 && !agr2))
    {
        result = true;
    }
    return result;
}
bool x = true; bool y = false;
//bool x = true; bool y = true;
//bool x = false; bool y = true;
//bool x = false; bool y = false;
Console.WriteLine(TrueOrFalse(x, y));

//Варианты Сергея==================
/*
// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// x  y 
// f  f
// f  t
// t  f
// t  t

// bool 
// x = false , y = false;
// Console.WriteLine(!(x || y) == (!x && !y));
// x = false; y = true;
// Console.WriteLine(!(x || y) == (!x && !y));
// x = true; y = false;
// Console.WriteLine(!(x || y) == (!x && !y));
// x = true; y = true;
// Console.WriteLine(!(x || y) == (!x && !y));

bool f(bool arg1, bool arg2)
{
    return !(arg1 || arg2) == (!arg1 && !arg2);
}

// bool 
// x = false , y = false;
// Console.WriteLine(f(x, y));
// x = false; y = true;
// Console.WriteLine(f(x, y));
// x = true; y = false;
// Console.WriteLine(f(x, y));
// x = true; y = true;
// Console.WriteLine(f(x, y));

// bool 
// x = false , y = false;
// bool res = f(x, y);

// x = false; y = true;
// res =res && f(x, y);
// x = true; y = false;
// res =res && f(x, y);
// x = true; y = true;
// res =res && f(x, y);
// System.Console.WriteLine(res);

bool ConvertIntToBool(int arg)
{
    return arg == 1;
}
// bool res = true;
// for (int i = 0; i <= 1; i++)
// {
//     for (int j = 0; j <= 1; j++)
//     {
//         res = res && f(ConvertIntToBool(i), ConvertIntToBool(j));
//     }
// }
//System.Console.WriteLine(res);

bool Table()
{
    bool res = true;
    for (int i = 0; i <= 1; i++)
    {
        for (int j = 0; j <= 1; j++)
        {
            res = res && f(Convert.ToBoolean(i), ConvertIntToBool(j));
        }
    }
    return res;
}

Console.WriteLine(Table());
*/

//19. Определить номер четверти плоскости, в которой находится точка с координатами
// Х и У, причем X ≠ 0 и Y ≠ 0
int X = 8;
int Y = -5;
Console.WriteLine("19. Определить номер четверти плоскости, в которой находится точка с "
                  + $"координатами Х = {X} и Y = {Y}");


int MyCuatro(int x, int y)
{
    int cuatro = 1;
    if (x < 0 & y > 0) return cuatro;
    if (x > 0 & y > 0) cuatro = 2;
    if (x > 0 & y < 0) cuatro = 3;
    if (x < 0 & y < 0) cuatro = 4;
    return cuatro;
}
string PrintCuatro(int X, int Y)
{
    string text = "Неверно заданы координаты";
    if(X==0 | Y == 0) return text;
    else
    {
        text = $"Номер четверти плоскости, в которой находится точка с координатами"
             + $" {X} и {Y} является: {MyCuatro(X, Y)}";
    }
    return text;
}
Console.WriteLine(PrintCuatro(X, Y));

//20. Задать номер четверти, показать диапазоны для возможных координат
int e = 3;
Console.WriteLine($"20. Задаy номер четверти - {e}, показать диапазоны для возможных координат");

string PrintMyCuatro(int a)
{
    int[] myNum = { 1, 2, 3, 4 };
    int index = 0;
    string text = $"Если номер четверти равен {myNum[index]}, то диапазоны для возможных"
                + $" координат соответствуют отрезкам от -X до 0 и от 0 до Y";
    if (a == 1) return text;
    if (a == 2)
    {
        text = $"Если номер четверти равен {myNum[index + 1]}, то диапазоны для возможных"
             + $" координат соответствуют отрезкам от 0 до Y и от 0 до X";
        return text;
    }
    if (a == 3)
    {
        text = $"Если номер четверти равен {myNum[index + 2]}, то диапазоны для возможных"
             + $" координат соответствуют отрезкам от -Y до 0 и от 0 до X";
        return text;
    }
    if (a == 4)
    {
        text = $"Если номер четверти равен {myNum[index + 3]}, то диапазоны для возможных"
             + $" координат соответствуют отрезкам от -Y до 0 и от -X до 0";
    }
    else
    {
        text = "Неверно задан номер четверти";
    }
    return text;
}
Console.WriteLine(PrintMyCuatro(e));

//21. Программа проверяет пятизначное число на палиндромом.
int palindrome = 12321;
Console.WriteLine($"21. Проверить число {palindrome} на палиндромом");

bool MyPalindrome(int num)
{
    return (num/10000 == num%10 & num/1000%10 == num%100/10);   
}

Console.WriteLine(MyPalindrome(palindrome));

//22. Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("22. Найти расстояние между точками в пространстве 2D/3D");
double SegmentSize(int[] a, int[] b)
{
    int x = (b[0] - a[0]);
    int y = (b[1] - a[1]);
    int stepen = 2;
    double answer = -1;
    if (a.Length == 2 & b.Length == 2)
    {
        answer = Math.Sqrt(Math.Pow(x, stepen) + Math.Pow(y, stepen));
    }
    if (a.Length == 3 & b.Length == 3)
    {
        int z = (b[2] - a[2]);
        answer = Math.Sqrt(Math.Pow(x, stepen) + Math.Pow(y, stepen) + Math.Pow(z, stepen));
    }
    return answer;
}
int[] A = { 1, 3, 1 };
int[] B = { 5, 2, 4 };
Console.WriteLine(SegmentSize(A, B));

