/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] getRandomArray(int lenght)
{
    int[] result = new int[lenght];
    for (var i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(-100, 100);
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

int SumOddPosition(int[] arrayToCheck)
{
    int result = 0;
    for(var i = 1; i < arrayToCheck.Length; i += 2)
    {
        result += arrayToCheck[i];
    }
    return result;
}

int[] randomArray = getRandomArray(5);
printArray(randomArray);
int number = SumOddPosition(randomArray);
Console.WriteLine($"Cуммf элементов, стоящих на нечётных позициях равна {number}");