// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Задайте массив заполненный случайными положительными трёхзначными числами: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[size];

FillArrayWithRandomNumbers(numbers);
PrintArray(numbers);
int A = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        A++;
    }
}
if (A % 10 == 1)
{
    Console.WriteLine($"В массиве {A} четное число");
}
if (A % 10 == 2 || A % 10 == 3 || A % 10 == 4)
{
    Console.WriteLine($"В массиве {A} четных числа");
}
else

    Console.WriteLine($"В массиве {A} четных чисел");
    
void FillArrayWithRandomNumbers(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
