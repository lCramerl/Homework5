/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
int[] getRandomArray(int lenght)
{
    int[] result = new int[lenght];
    for (var i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}


void printArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write((","));
        }
    }
    Console.WriteLine("]");
}

int MaxNumberInArray(int[] arrayToCheck1)
{
    int result = arrayToCheck1[0];
    for (var i = 1; i < arrayToCheck1.Length; i++)
    {
        if (arrayToCheck1[i] > result)
        {
            result = arrayToCheck1[i];
        }
    }
    return result;
}

int MinNumberInArray(int[] arrayToCheck2)
{
    int count = arrayToCheck2[0];
    for (var i = 1; i < arrayToCheck2.Length; i++)
    {
        if (arrayToCheck2[i] < count)
        {
            count = arrayToCheck2[i];
        }
    }
    return count;
}

int[] randomArray = getRandomArray(5);
printArray(randomArray);
int maxNumber = MaxNumberInArray(randomArray);
int minNumber = MinNumberInArray(randomArray);
Console.WriteLine($"{maxNumber} - {minNumber} = {maxNumber - minNumber}");