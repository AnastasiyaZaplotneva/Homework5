// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[^1]}]");
}
int SummOfOddElements(int[] array)
{
    int summa = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i%2 != 0) 
        {
            summa = summa + array[i]; 
        }
    }
    return summa;
}
int[] massive = FillArray(10, -10, 10);
PrintArray(massive);
int result = SummOfOddElements(massive);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {result}");
