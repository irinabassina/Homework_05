// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size_array)
{
    int[] randomArray = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {
        randomArray[i] = new Random().Next(100, 1000);
    }
    return randomArray;
}

void PrintArray(int[] array_to_print)
{
    Console.Write("[");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write(array_to_print[i] + ", ");
}

void CountOfEvenElem(int[] countArray)
{
    int count = 0;
    for (int z = 0; z < countArray.Length; z++)
    {
        if (countArray[z] % 2 == 0)
            count++;
    }
    Console.WriteLine($" -> {count}");
}

int size = new Random().Next(1, 11);
int[] firstArray = CreateRandomArray(size);
PrintArray(firstArray);
Console.Write("\b\b]");
CountOfEvenElem(firstArray);