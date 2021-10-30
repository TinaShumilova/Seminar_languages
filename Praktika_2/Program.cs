/*Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
Создать на его основе масив B, отбрасывая те, которые нарушают порядок

- возрастания
- элементы, больше 8
- знакочередования*/

int CreateArray(int[] arreyLenth, int minValue, maxValue)
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
int[] B = RemoveInt()