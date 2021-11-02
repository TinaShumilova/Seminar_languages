/*Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
Создать на его основе масив B, отбрасывая те, которые нарушают порядок

- возрастания
- элементы, больше 8
- знакочередования*/

/*void CreateArray(int[] collection, int minValue, int maxValue)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(minValue+1, maxValue+1);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int possition = 0;
    while(possition < count)
    {
        Console.Write($"{array[possition]} ");
        possition++;
    }
    Console.WriteLine();
}
*/
/*int[] Increase(int[] col)
{
    int count = 1;
    int [] arr = new int[count];
    int i = 0;
    arr[i] = col[0];
    int length = col.Length;
    int index = 1;
    int temp = col[0];
    while(index < 10)
    {
        if(col[index] > arr[i])
        {
            temp = col[index];
            count++;
            i++;
            arr[i] = temp;
            index++;
        }
    }
    return arr;
}

void PrintArrayB(int[] B)
{
    int count = B.Length;
    int possition = 1;
    Console.Write($"{B[0]} ");
    while(possition < count)
    {
        Console.Write($"{B[possition]} ");
        possition++;
    }
    Console.WriteLine();
}
*/



/*[] ArrayA = new int[10];
CreateArray(ArrayA, 1, 100);
PrintArray(ArrayA);
int[] ArrayB = Increase(ArrayA);
PrintArray(ArrayB);*/

Console.WriteLine();
Console.WriteLine("Создаём числовой массив A заполненный числами из отрезка [-10, 10].");
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

/*int index = 1;
int currentElement = ArrayA[0];
Console.Write($"{currentElement} ");
while(index < 10)
{
    if(ArrayA[index] > currentElement)
    {
        Console.Write($"{ArrayA[index]} ");
        currentElement = ArrayA[index];
    }
    index++;
}
Console.WriteLine();



/*int CreateArray(int[] arreyLenth, int minValue, int maxValue)
{
    int numArray = new int[arreyLenth];
    int index = 0;
    while(index < arreyLenth)
    {
        numArray[index] = new Random().Next(minValue,maxValue);
        index++;
    }
    return numArray;
}

int RemoveInt(int[] A)
{
    int[] numAray = new int[];
    numAray[0]=A[0];
    int indexA = 1;
    int indexB = 1;
    while(indexA < A.Length)
    if
}


int[] A = CreateArray(5, 1, 15);
int[] B = RemoveInt()*/