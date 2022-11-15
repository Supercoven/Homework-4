// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummOfNumbers(int num)
{   int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num = num/10;
    
    }
    return res;
}

Console.WriteLine("Введите целое число");
int number =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма числ в числе {SummOfNumbers(number)}");