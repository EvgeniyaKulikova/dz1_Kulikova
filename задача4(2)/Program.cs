// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input your fist number a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your fist number b ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your fist number c ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > b & a > c)
{  
   Console.Write(max = a);
}

else if (b > a & b > c)
{
    Console.Write(max = b);
}
else
{
    Console.Write(max = c);
}