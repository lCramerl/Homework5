/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] getRandomArray(int lenght)
{
    int[] result = new int[lenght];
    for (var i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(-10, 10);
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

int[] MultiplicationOfPairs(int[] arrayToMultiplication)
{
    int lenght = arrayToMultiplication.Length;
    int lenghtResult = 0;
    if (lenght % 2 == 0)
    {
        lenghtResult = lenght / 2;
    }
    else
    {
        lenghtResult = lenght / 2 + 1;
    }
    int[] result = new int[lenghtResult];
    for (var i = 0; i < lenghtResult; i++)
    {
        if (lenght % 2 == 1 && i == lenghtResult / 2 + 1)
        {
            result[i] = arrayToMultiplication[i];
        }
        else
        {
            result[i] = arrayToMultiplication[i] * arrayToMultiplication[lenght - 1 - i];
        }
    }
    return result;
}



int[] randomArray = getRandomArray(5);
printArray(randomArray);
int[] array1 = MultiplicationOfPairs(randomArray);
printArray(array1);
