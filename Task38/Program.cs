// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] FillArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble()*20;
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    int size = array.Length;
    for(int i = 0; i < size - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine($"{array[^1]}]");
}

double FindMax(double[] array)
{
    double max = array[0];
    int size = array.Length;
    for(int i = 1; i < size; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    int size = array.Length;
    for(int i = 1; i < size; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}

double DifferenceMaxMin(double[] array)
{
    PrintArray(array);
    double maximum = FindMax(array);
    double minimum = FindMin(array);
    double result = maximum - minimum;
    return result;
}
int size2 = new Random().Next(6, 15);
double[] massive = FillArray(size2);
double diff = DifferenceMaxMin(massive);
Console.WriteLine($"Разница между макисмальным и минимальным элементом массива равна {diff}");