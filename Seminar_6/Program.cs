// Почувствуй себя сеньором
int[] CreateNewArray(int a)
{
    return new int[a];
}
int[] FillNewArray(int[] array, int minA, int maxB)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minA, maxB +1);
    }
    return array;
} 
string PrintArray(int[] array)
{
    string text = String.Empty;
    for(int index = 0; index < array.Length; index++)
    {
        text = text + $"{array[index]} ";
    } 
    return text;
}
int NumSum(int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sumPos = sumPos + array[i];
        }
        else
        {
            sumNeg = sumNeg + array[i];
        }
    }
    return sumPos;
    return sumNeg;
}
/*
string PrintNumSum(int[] array)
{
    string answer = $"{NumSum(array)}";
    if(NumSum(array) > 0)
    {

    }
}
*/
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
int size = 12;
int minNum = -9;
int maxNum = 9;
Console.WriteLine($"33. Задать массив из {size} элементов, заполненных числами"
                 + $" из [{minNum},{maxNum}].");

int[] thirdArray = CreateNewArray(size);
FillNewArray(thirdArray, minNum, maxNum);
Console.WriteLine(PrintArray(thirdArray));
Console.WriteLine("Найти сумму положительных элементов массива");
Console.WriteLine(NumSum(thirdArray));



/*





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
*/
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


/*
//Задача 3, если в каждом элементе массива будет ещё массив
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