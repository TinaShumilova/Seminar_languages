// Почувствуй себя сеньором
int[] CreateNewArray(int a)
{
    return new int[a];
}
int[] FillNewArray(int[] array, int minA, int maxB)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minA, maxB + 1);
    }
    return array;
}
string PrintArray(int[] array)
{
    string text = String.Empty;
    for (int index = 0; index < array.Length; index++)
    {
        text = text + $"{array[index]} ";
    }
    return text;
}
(int, int) NumSum(int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPos = sumPos + array[i];
        }
        else
        {
            sumNeg = sumNeg + array[i];
        }
    }
    return (sumPos, sumNeg);
     // как вернуть оба значения?
}
int[] ChangeSimbol(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
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
int FindNumber2(int[] array, int a, int b)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= a && array[i] <= b)
        {
            count++;
        }
    }
    return count;
}
string ParesMultipl(int[] array)
{
    string answer = String.Empty;
    int multi = 1;
    int last = array.Length - 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
        multi = array[i] * array[last];
        answer = answer + $"{multi} ";
        last--;
    }
    return answer;
}
double[] FillRArray(int a)
{
    double[] array = new double[a];
    for(int i=0;i<a;i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}
string PrintRArray(double[] array)
{
    string text = String.Empty;
    for (int index = 0; index < array.Length; index++)
    {
        text = text + $"{array[index]} ";
    }
    return text;
}
double FindDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i =1; i<array.Length;i++)
    {
        if(array[i]>max) max = array[i];
    }
    for(int i =1; i<array.Length;i++)
    {
        if(array[i]<min) min = array[i];
    }
    return max-min;
}
int SumIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

// 31. Задать массив из 8 элементов и вывести их на экран 

int lenght = 8;
Console.WriteLine($"31. Задать массив из {lenght} элементов и вывести их на экран");
int[] firstArray = CreateNewArray(lenght);
FillNewArray(firstArray, -10, 10);
Console.WriteLine(PrintArray(firstArray));

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их
// на экран 
Console.WriteLine($"32. Задать массив из {lenght} элементов и вывести их на экран");
int[] secondArray = CreateNewArray(lenght);
FillNewArray(secondArray, 0, 1);
Console.WriteLine(PrintArray(secondArray));

// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
lenght = 12;
int minNum = -9;
int maxNum = 9;
Console.WriteLine($"33. Задать массив из {lenght} элементов, заполненных числами"
                 + $" из [{minNum},{maxNum}].");

int[] thirdArray = CreateNewArray(lenght);
FillNewArray(thirdArray, minNum, maxNum);
Console.WriteLine(PrintArray(thirdArray));
Console.WriteLine("Найти сумму положительных элементов массива");
(int positiv, int negative) temp = NumSum(thirdArray);
Console.WriteLine(temp.positiv);

// 34. Написать программу замену элементов массива на противоположные
Console.WriteLine($"33. Задать массив из {lenght} элементов.");
int[] fourghtArray = CreateNewArray(lenght);
FillNewArray(fourghtArray, minNum, maxNum);
Console.WriteLine(PrintArray(fourghtArray));
Console.WriteLine("Заменить элементы массива на противоположные");
ChangeSimbol(fourghtArray);
Console.WriteLine(PrintArray(fourghtArray));

// 35. Определить, присутствует ли в заданном массиве, некоторое число 
Console.WriteLine("35. Задать массив");
int[] fifthArray = CreateNewArray(lenght);
FillNewArray(fifthArray, minNum, maxNum);
Console.WriteLine(PrintArray(fifthArray));
int f = 8;
Console.WriteLine($"Определить, присутствует ли в заданном массиве, число {f}?");
Console.WriteLine(FindNumber(fifthArray, f));

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных/четных чисел
Console.WriteLine("36. Задать массив, заполнить случайными положительными трёхзначными числами.");
int[] sixthArray = CreateNewArray(lenght);
minNum = -100;
maxNum = 999;
FillNewArray(sixthArray, minNum, maxNum);
Console.WriteLine(PrintArray(sixthArray));
Console.WriteLine("Показать количество нечетных чисел");
Console.WriteLine(NumCount(sixthArray));

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
lenght = 123;
Console.WriteLine($"37. Задать массив из {lenght} чисел");
int[] seventhArray = CreateNewArray(lenght);
minNum = 0;
maxNum = 999;
FillNewArray(seventhArray, minNum, maxNum);
Console.WriteLine(PrintArray(seventhArray));
int A = 10;
int B = 99;
Console.WriteLine($"Найти количество элементов из отрезка [{A},{B}]");
Console.WriteLine(FindNumber2(seventhArray, A, B));

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
lenght = 10;
int[] eighthArray = CreateNewArray(10);
FillNewArray(eighthArray, -10, 10);
Console.WriteLine(PrintArray(eighthArray));
Console.WriteLine(SumIndex(eighthArray));

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и 
//последний элемент, второй и предпоследний и т.д.
lenght = 11;
Console.WriteLine($"39. Задать массив из {lenght} чисел");
int[] ninethArray = CreateNewArray(lenght);
FillNewArray(ninethArray, minNum, maxNum);
Console.WriteLine(PrintArray(ninethArray));
Console.WriteLine("Найти произведение пар чисел в одномерном массиве.");
Console.WriteLine(ParesMultipl(ninethArray));
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine($"40. Задать массив из {lenght} вещественныхчисел");
double[] tenthArray = FillRArray(lenght);
Console.WriteLine(PrintRArray(tenthArray));
Console.WriteLine("Найти разницу между максимальным и минимальным элементом");
Console.WriteLine(FindDiff(tenthArray));
/*
//Задача 32, если в каждом элементе массива будет ещё массив
=====================================================================================

int[][] FillArray(int a, int b)
{
    int[][] array = new int[a][];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new int[b];
        for (int j = 0; j < array[i].Length; j++)
        {
            array[i][j] = new Random().Next(0, 2);
        }
    }
    return array;
}

int[][] newArray = FillArray(8, 8);

string PrintNewArray(int[][] array)
{
    string text = String.Empty;
    for(int index = 0; index < array.Length; index++)
    {
        string number = $"{array[index]}";
        for(int i = 0; i< array[index].Length; i++)
        {
            number = number + $"{array[index][i]}";
        }
        
        text = text + $"{number} ";
    } 
    return text;
}
Console.WriteLine(PrintNewArray(newArray));
===================================================================================
*/


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