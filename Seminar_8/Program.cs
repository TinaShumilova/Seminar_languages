/*bool Tripl(int a, int b, int c)
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
string PrintArray(int[] array)
{
    string text = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        text = text + $"{array[i]} ";
    }
    return text;
}
int count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
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
int num = 44;
string ConvToDouble(int number)
{
    string temp = String.Empty;
    while(number/2 != 0)
    {
        if(number%2==0)
        {
            temp = "0" + temp;
        }
        else
        {
            temp = "1" + temp;
        }
        number = number/2;
    }
    return temp;
}
Console.WriteLine(ConvToDouble(num));
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
/*===============================================
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
================================================*/
// 47. Написать программу копирования массива
