﻿/*
bool Tripl(int a, int b, int c)
{
    return ((a + b > c) && (a + c > b) && (c + b > a));
}
int[] array(string tx)
{
    int lenght = 0;
    tx = tx + " ";
    for (int i = 0; i < tx.Length; i++)
    {
        if (tx[i] == ' ') lenght++;
    }
    return new int[lenght];
}
int[] FillArFromTex(int[] arr, string tx)
{
    tx += " ";
    string temp = String.Empty;
    int i = 0;
    for (int j = 0; j < tx.Length; j++)
    {
        if (tx[j] != ' ')
        {
            temp = temp + tx[j];
        }
        else
        {
            arr[i] = Convert.ToInt32(temp);
            temp = String.Empty;
            i++;
        }
    }
    return arr;
}
*/
string PrintArray(int[] array)
{
    string text = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        text = text + $"{array[i]} ";
    }
    return text;
}
/*
int count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}
(double, double) FindXY(double k1, double b1, double k2, double b2)
{
    double X = (b2 - b1) / (k1 - k2);
    double Y = k2 * X + b2;
    return (X, Y);
}

int[] Fibbonachi(int a, int b, int lenght)
{
    int[] array = new int[lenght];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

*/

// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 
/*
Console.Clear();
int AB = 8;
int BC = 6;
int CA = 10;
bool answer = Tripl(AB, BC, CA);
Console.WriteLine(answer);
*/
// 42. Определить сколько чисел больше 0 введено с клавиатуры
/*
string text = Console.ReadLine();
int[] ArrayT = array(text);
FillArFromTex(ArrayT, text);
Console.WriteLine(count(ArrayT));
*/
// 43. Написать программу преобразования десятичного числа в двоичное
/*
int num = GetNumber();
string ConvToDouble(int number)
{
    string temp = String.Empty;
    while (number != 0)
    {
        if (number % 2 == 0) temp = "0" + temp;
        else temp = "1" + temp;
        number = number / 2;
    }
    return temp;
}
string number = ConvToDouble(num);
Console.WriteLine(number);
*/


// 44. Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, 
// y = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы
/*
double b1 = 0;
double k1 = 1;
double b2 = 1;
double k2 = 0;

Console.WriteLine(FindXY(k1, b1, k2, b2));
*/

// 45. Показать числа Фибоначчи
//a, b, c = a+b
/*int[] Fibo = Fibbonachi(0, 1, 10);
Console.WriteLine(PrintArray(Fibo));
*/
// 46. Написать программу масштабирования фигуры
/*
int GetNumber()
{
    return Convert.ToInt32(Console.ReadLine());
}

double Coefficient()
{
    Console.WriteLine("Введите коэффициент масштабирования. ");
    return GetNumber();
}

string ResultOfScale(string text, double number)
{
    string result = String.Empty;
    double temp = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == '(' || text[i] == ',' || text[i] == ')' || text[i] == ' ')
        {
            result = result + text[i];
        }
        else
        {
            temp = Convert.ToInt32($"{text[i]}");
            temp = temp * number;
            result = result + $"{Convert.ToString(temp)}";
            temp = 0;
        }
    }
    return result;
}
string coordinates = "(0,0) (2,0) (2,2) (0,2)";
Console.WriteLine(coordinates);
double coef = Coefficient();
string newCoordinates = ResultOfScale(coordinates, coef);
Console.WriteLine(newCoordinates);
*/
/*===============================================
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
================================================*/
// 47. Написать программу копирования массива

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] CopyArray(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i]=array[i];
    }
    return array2;
}

Console.WriteLine(PrintArray(array));
int[] array2 = CopyArray(array);
Console.WriteLine(PrintArray(array2));
