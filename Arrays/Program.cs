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
// 48. Показать двумерный массив размером m×n заполненный целыми числами
/*
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
*/

//Тест кода
//TestTask48();