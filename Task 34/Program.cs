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
int count = 0;

    for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] % 2 == 0)
        count++;
}
    Console.WriteLine($"Четных чисел {count}");

    void FillArrayRandomNumbers(int[] numbers)
{
    
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000); 
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
