/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Здравствуйте Семён, 2 задачи последующие сам делал так как мы их проходили, эту нашел в инете и немного подредактировал.*/

int number = 0;
while (true)
{
    Console.Write("Введите пятизначное число: ");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    else
        Console.WriteLine("Неверное число.");
}
int oldValue = number;
int newValue = 0;
while (number > 0)
{
    int dig = number % 10;
    newValue = newValue * 10 + dig;
    number = number / 10;
}
if (newValue == oldValue)
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("Не палиндром");
