// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());

string num = Convert.ToString(a);

Console.WriteLine ("Вторая цифра трехзначного числа " + num[1]);
