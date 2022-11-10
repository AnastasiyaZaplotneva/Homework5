// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
int Counting(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) count++; 
    }
    return count;
}
while(true)
{
Console.WriteLine("Укажите размер массива - целое положительное число:");
int size2 = Convert.ToInt32(Console.ReadLine());
if(size2 > 0) 
    {
    int[] massive = FillArray(size2, 100, 999);    
    int result = Counting(massive);
    PrintArray(massive);
    Console.WriteLine($"В этом массиве {result} четных чисел");
    break;
    }
}



