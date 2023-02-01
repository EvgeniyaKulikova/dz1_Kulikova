//Задача 2(1). 
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Write("Input your fist number a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your fist number b ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max = a, min = b");
}
else
{
    Console.WriteLine("max = b, min = a");
}
