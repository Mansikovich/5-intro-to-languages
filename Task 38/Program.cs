using System;

namespace ConsoleApp
{
class Program
{
static void Main()
{
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine($"Сгенерирован массив: ");
PrintArray(numbers);
int min = numbers.Min();
int max = numbers.Max();

    Console.WriteLine($"Разница между максимальным и минимальным элементов массива {max - min}");

    void FillArrayRandomNumbers(int[] numbers)
{
    
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,100); 
    }
}
    void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i] + " ");
    }
   
}

}
}
}
