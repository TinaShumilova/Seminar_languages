int[,] CreateMultidimensionalArray(int m, int n)
{
    return new int[m, n];
}
int[,] FillMultidimensionalArray(int[,] array, int minNumber, int maxNumber)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minNumber, maxNumber + 1);
        }
    }
    return array;
}
void PrintMultidimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] CreateMultidimensionalDoubleArray(int m, int n)
{
    return new double[m, n];
}
double[,] FillMultidimensionalDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
        }
    }
    return array;
}
void PrintMultidimensionalDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ReplaceEvenNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0) array[i, j] = array[i, j] * -1;
        }
    }
    return array;
}

int[,] FillMultidimensionalArrayWithIndexSum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

int[,] ReplaceNumbersWithEvenIndexesWithItSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}

int[,] FillMultidimensionalArrayWithUserCorrections(int[,] array, int minNumber, int maxNumber)
{
    int a = new Random().Next(0, array.GetLength(0));
    int b = new Random().Next(0, array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == a && j == b)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            else array[i, j] = new Random().Next(minNumber, maxNumber + 1);
        }
    }
    return array;
}

// 48. Показать двумерный массив размером m×n заполненный целыми числами

void TestTask48()
{
    int a = 3;
    int b = 4;
    int min = 0;
    int max = 10;
    int[,] testArray = CreateMultidimensionalArray(a, b);
    FillMultidimensionalArray(testArray, min, max);
    PrintMultidimensionalArray(testArray);
}

//49. Показать двумерный массив размером m×n заполненный вещественными числами

void TestTask49()
{
    int a = 4;
    int b = 5;
    double[,] testDoubleArray = CreateMultidimensionalDoubleArray(a, b);
    FillMultidimensionalDoubleArray(testDoubleArray);
    PrintMultidimensionalDoubleArray(testDoubleArray);
}

//50. В двумерном массиве n×k заменить четные элементы на противоположные

void TestTask50()
{
    int a = 3;
    int b = 4;
    int min = 0;
    int max = 10;
    int[,] testArray = CreateMultidimensionalArray(a, b);
    FillMultidimensionalArray(testArray, min, max);
    PrintMultidimensionalArray(testArray);
    Console.WriteLine();
    ReplaceEvenNumbers(testArray);
    PrintMultidimensionalArray(testArray);
}

//51. Задать двумерный массив следующим правилом: A[m,n]=m+n

void TestTask51()
{
    int a = 3;
    int b = 4;
    int[,] testArray = CreateMultidimensionalArray(a, b);
    FillMultidimensionalArrayWithIndexSum(testArray);
    PrintMultidimensionalArray(testArray);
}

//52. В двумерном массиве заменить элементы, у которых оба индекса чётные 
//на их квадраты

void TestTask52()
{
    int a = 3;
    int b = 4;
    int min = 0;
    int max = 10;
    int[,] testArray = CreateMultidimensionalArray(a, b);
    FillMultidimensionalArray(testArray, min, max);
    PrintMultidimensionalArray(testArray);
    Console.WriteLine();
    ReplaceNumbersWithEvenIndexesWithItSquare(testArray);
    PrintMultidimensionalArray(testArray);
}

//53. В двумерном массиве показать позиции числа, заданного пользователем 
//или указать, что такого элемента нет
(int, int) FindPossition(int[] array)
{
    
    return(,);
}

void TestTask53()
{
    int a = 3;
    int b = 4;
    int min = 0;
    int max = 10;
    int[,] testArray = CreateMultidimensionalArray(a, b);
    FillMultidimensionalArrayWithUserCorrections(testArray, min, max);
    PrintMultidimensionalArray(testArray);
}

//Тест кода
//TestTask48();
//TestTask49();
//TestTask50();
//TestTask51();
//TestTask52();
TestTask53();