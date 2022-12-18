// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 
// 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int length = Prompt("Enter a quantity of numbers ");
int count = 0;
int[] array = GenerateArray(length);

int Prompt(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int [] array)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}
 int[] GenerateArray(int len)
 {
     int[] array = new int[len];
     for (int i = 0; i < length; i++)
     {
         array[i] = Prompt("Enter a number ");
     }
     return array;
 }

for (int i = 0; i < array.Length; i++)
{
    
    if(array[i] > 0)
    {
        count++;
    }
}
PrintArray(array);
Console.Write($"Quantity of numbers = {count}");
