// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    Console.WriteLine($"Таблица кубов чисел от 1 до {n}: ");
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i} ^ 3 \t {i * i * i}");
    }
}
else Console.WriteLine("Введено некорректное значение.");