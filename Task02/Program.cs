// Задача 2: Напишите программу, которая найдёт точку 
// пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
double FindDot(double b1, double k1)
{
    double x = -0.5;
    double y = k1 * x + b1;
    
    return y;
    
}
double b1 = Prompt("Enter a value of B1");
double k1 = Prompt("Enter a value of K1");
double b2 = Prompt("Enter a value of B2 ");
double k2 = Prompt("Enter a value of K2");
double y = FindDot(b1, k1);
double y1 = FindDot(b2, k2);
Console.Write($"{y} {y1}");