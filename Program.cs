// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). 

System.Console.Write("Введите число -> ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 2;

if (result == 1)
{
    System.Console.Write($"Число {number} не четное");
}

else System.Console.Write($"Число {number} четное");