// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)

// 3, 5 -> 243 (3⁵)
// 0, 0 - >1
// 2, 4 -> 16

Console.WriteLine("Введите число А для возведения в натуральную степень B");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень B");
int B = int.Parse(Console.ReadLine());

void Degree()
{
    int deg = 1;
    for(int i = 0; i < B; i++)
    {
        deg = A * deg;
    }
Console.WriteLine((deg));
}

Degree();