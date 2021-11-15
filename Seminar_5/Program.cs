// 23. Показать таблицу квадратов чисел от 1 до N 
string PrintNumberDos(int number)
{
    string text = String.Empty;
    int result = 0;
    for(int index = 1; index <=number; index++)
    {
        result = index * index;
        text = $"{index} x {index} = {result}";
        Console.WriteLine(text);
    }
    return text;
}
int N = 10;
Console.WriteLine($"23. Показать таблицу квадратов чисел от 1 до {N}");
PrintNumberDos(N);

// 24. Найти кубы чисел от 1 до N
string PrintNumberTres(int num)
{
    string text = String.Empty;
    double result = 0;
    double step = 3;
    for(double ind = 1; ind <=num; ind++)
    {
        result = Math.Pow(ind, step);
        text = $"{ind} ^ {step} = {result}";
        Console.WriteLine(text);
    }
    return text;
}
int A = 10;
Console.WriteLine($"24. Показать таблицу кубов чисел от 1 до {A}");
PrintNumberTres(A);

// 25. Найти сумму чисел от 1 до А
int NumberSum(int numb)
{
    int summ = 0;
    for (int i = 1; i < numb + 1; i++)
    {
        summ = summ + i;
    }
    return summ;
}
int B = 10;
Console.WriteLine($"25. Найти сумму чисел от 1 до {B}");
Console.WriteLine(NumberSum(B));

// 26. Возведите число А в натуральную степень B используя цикл
int NatDegree(int a, int b)
{
    int res = a;
    for (int i = 1; i < b; i++)
    {
        res = res * a;
    }
    return res;
}
int C = 3;
int D = 5;
Console.WriteLine($"26. Возвести число {C} в натуральную степень {D}");
Console.WriteLine(NatDegree(C, D));

// 27. Определить количество цифр в числе
int NumberDigits(int numbr)
{
    int reslt = 0;
    while(numbr !=0)
    {
        int temp = numbr%10;
        reslt++;
        numbr = numbr/10;
    }
    return reslt;
}
int E = 1254858;
Console.WriteLine($"27. Определить количество цифр в числе {E}");
Console.WriteLine(NumberDigits(E));

// 28. Подсчитать сумму цифр в числе
int NumberDigitsSum(int nombr)
{
    int rslt = 0;
    while(nombr != 0)
    {
        int temporary = nombr%10;
        rslt = rslt + temporary;
        nombr = nombr/10;
    }
    return rslt;
}
int F = 125497;
Console.WriteLine($"28. Подсчитать сумму цифр в числе {F}");
Console.WriteLine(NumberDigitsSum(F));

// 29. Написать программу вычисления произведения чисел от 1 до N
int NumbersMultipl(int last_numb)
{
    int multipl = 1;
    for(int pos = 1; pos < last_numb; pos++)
    {
        multipl = multipl * (pos +1);
    }
    return multipl;
}
int G = 10;
Console.WriteLine($"29. Произведение чисел от 1 до {G}");
Console.WriteLine(NumbersMultipl(G));

// 30. Показать кубы чисел, заканчивающихся на четную цифру
double NumbersTresEven(int first, int l_num)
{
    double tres = 0;
    double degree = 3;
    while (first % 2 == 0 && first <= l_num)
    {
        for (double i = first; i <= l_num; i = i + 2)
        {
            tres = Math.Pow(first, degree);
            Console.Write($"{tres} ");
            first = first + 2;
        }
    }
    return tres;
}

int H = -2;
int I = 10;
Console.WriteLine($" 30. Кубы чисел от {H} до {I}, заканчивающихся на четную цифру");
NumbersTresEven(H, I);
Console.WriteLine();

// Почувствуй себя сеньором

// 31. Задать массив из 8 элементов и вывести их на экран 
int[] FillNewArray(int a)
{
    int[] array = new int[a];
    for (int indeks = 0; indeks < array.Length; indeks++)
    {
        array[indeks] = new Random().Next();
        Console.Write($"{array[indeks]} ");
    }
    return array;
}
int lenght = 8;
Console.WriteLine($"31. Задать массив из {lenght} элементов и вывести их на экран");
FillNewArray(lenght);
Console.WriteLine();

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их
// на экран 
/*
==============================================================================
int[][] FillNewArray(int a)
{
    int[][] array = new int[a][];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new int[8];
        for (int j = 0; j < array[i].Length; j++)
        {
            array[i][j] = new Random().Next(0, 2);
        }
        Console.Write($"{array[i]} ");
    }
    return array;
}
int lenght = 8;
Console.WriteLine($"32. Задать массив из {lenght} элементов и вывести их на экран");
FillNewArray(lenght);
Console.WriteLine();
====================================================================================
*/
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива

int[] FillArray(int b, int firstNum, int lastNum)
{
    int[] array = new int[b];
    for (int indeks = 0; indeks < array.Length; indeks++)
    {
        array[indeks] = new Random().Next(firstNum, lastNum + 1);
    }
    return array;
}
string PrintArray(int[] arr)
{
    string text = String.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        text = text + $"{arr[i]} ";
    }
    return text;
}
int NumSum(int[] massive)
{
    int sumPos = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        sumPos = sumPos + massive[i];
    }
    return sumPos;
}

int size = 12;
int minNum = 0;
int maxNum = 9;
Console.WriteLine($"33. Задать массив из {size} элементов, заполненных числами"
                 + $" из [{minNum},{maxNum}].");

int[] Arr = FillArray(size, minNum, maxNum);
Console.WriteLine(PrintArray(Arr));
Console.WriteLine("Найти сумму положительных элементов массива");
Console.WriteLine(NumSum(Arr));


// 34. Написать программу замену элементов массива на противоположные
//=============противоположные чему? положительные на отрицательные? местоположение?
// 35. Определить, присутствует ли в заданном массиве, некоторое число 

int[] FillAnotherArray(int r, int min, int max)
{
    int[] array = new int[r];
    for (int indeks = 0; indeks < array.Length; indeks++)
    {
        array[indeks] = new Random().Next(min, max + 1);

    }
    return array;
}
string PrintAnotherArray(int[] anarr)
{
    string text = String.Empty;
    for (int i = 0; i < anarr.Length; i++)
    {
        text = text + $"{anarr[i]} ";
    }
    return text;
}

string FindNumber(int[] annar, int find)
{
    string res = "Нет";
    for (int index = 0; index < annar.Length; index++)
    {
        if (annar[index] == find)
            res = "Да";
    }
    return res;
}
Console.WriteLine("35. Задать массив");
int[] anotherArray = FillAnotherArray(10, 0, 10);
Console.WriteLine(PrintAnotherArray(anotherArray));
int f = 8;
Console.WriteLine($"Определить, присутствует ли в заданном массиве, число {f}?");
Console.WriteLine(FindNumber(anotherArray, f));

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетныхчетных чисел
int[] FillNewArr(int s, int m, int mx)
{
    int[] array = new int[s];
    for (int index = 0; index < s; index++)
    {
        array[index] = new Random().Next(m, mx + 1);
    }
    return array;
}
string PrintNewArr(int[] arr)
{
    string result = $"{arr[0]} ";
    for (int index = 1; index < arr.Length; index++)
    {
        result = result + $"{arr[index]} ";
    }
    return result;
}

int NumCount(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 != 0)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.WriteLine("36. Задать массив, заполнить случайными положительными трёхзначными числами.");
int[] newArr = FillNewArr(10, 100, 999);
Console.WriteLine(PrintNewArr(newArr));
Console.WriteLine("Показать количество нечетныхчетных чисел");
Console.WriteLine(NumCount(newArr));

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива

/*
Вот задача: Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
  Юнит-тесты
  Легкость добавления других фигур
  Вычисление площади фигуры без знания типа фигуры в compile-time
  Проверку на то, является ли треугольник прямоугольным
*/