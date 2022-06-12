/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] getRandomArray(int lenght)
{
    int[] result = new int[lenght];
    for (var i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(100, 1000);
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

int EvenNumbers(int[] arrayToCheck)
{
    int result = 0;
    for(var i =0; i<arrayToCheck.Length; i++)
    {
        if(arrayToCheck[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int[] randomArray = getRandomArray(12);
printArray(randomArray);
int number = EvenNumbers(randomArray);
Console.WriteLine($"Данный массив имеет {number} чётных чисел");