﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input your number N = ");
int num = Convert.ToInt32(Console.ReadLine());

int current_num = 1;

while (current_num <= num)
{
    if (current_num % 2 == 0)
    {
        Console.Write(current_num + " ");
        current_num++;
    }
    else
    {
        current_num++;
    }
}
