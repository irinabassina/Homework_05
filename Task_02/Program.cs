// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int size_array)
{
    int[] randomArray = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {
        randomArray[i] = new Random().Next(-100, 101);
    }
    return randomArray;
}

void PrintArray(int[] array_to_print)
{
    Console.Write("[");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write(array_to_print[i] + ", ");
}

void SummOfOddPositionsElem(int[] countArray)
{
    int sum = 0;
    for (int z = 0; z < countArray.Length; z+=2)
    {
        sum = sum + countArray[z];
    }
    Console.WriteLine($" -> {sum}");
}

int size = new Random().Next(1, 11);
int[] firstArray = CreateRandomArray(size);
PrintArray(firstArray);
Console.Write("\b\b]");
SummOfOddPositionsElem(firstArray);
