//Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.

int [] UserCreateArray (int n)
{
    Console.WriteLine("введите размер массива");
    n = int.Parse(Console.ReadLine());
    int [] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(1,99);
    }
    return arr;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Полученный массив: [{arr[i]}]");
    }
}