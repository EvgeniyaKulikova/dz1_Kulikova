// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input your number");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 2 == 0)
{
    Console.Write("your number is even");
}
else
{
    Console.Write("your number is not even");
}
