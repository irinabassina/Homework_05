// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void CreateRandomArray(double [] randomArray)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = Convert.ToDouble(new Random().Next(100, 10001)) / 100;
    }
}

void PrintArray(double[] randomArray)
{
    Console.Write("[");
    for (int i = 0; i < randomArray.Length; i++)
        Console.Write(randomArray[i] + ", ");
}

double DiffMaxMin(double[] randomArray)
{
    double minValue = randomArray[0];
    double maxValue = randomArray[0];

    int k = 1;
    while (k < randomArray.Length)
    {
        if (maxValue < randomArray[k])
            maxValue = randomArray[k];
        if (minValue > randomArray[k])
            minValue = randomArray[k];
        k = k + 1;
    }
    Console.Write($" => {maxValue} - {minValue}");
    return (maxValue - minValue);
}

int size = new Random().Next(1, 11);
double[] firstArray = new double[size];
CreateRandomArray(firstArray);
PrintArray(firstArray);
Console.Write("\b\b]");

double diff = DiffMaxMin(firstArray);
Console.WriteLine($" = {diff:F2}");