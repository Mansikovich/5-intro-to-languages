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
int sum = 0;

    for (int z = 1; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"Сумма нечетных индексов {sum}");

    void FillArrayRandomNumbers(int[] numbers)
{
    
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-10,10); 
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
