// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
string result = Convert.ToString(a);
if (result.Length >2)
{
    Console.WriteLine($"Третья цифра числа "+ result[2]);
}
else
{
    Console.WriteLine("Третьей цифры в данном числе нет");
}