﻿// Задача 13:
// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
string intr = "Введите натуральное число:";
Console.WriteLine(intr);
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100)
{
string intr1 = "третьей цифры нет";
Console.WriteLine($"{num} ->" , intr1); 
}
else {
    int result = (num / 10 / 10 % 10);
    Console.WriteLine($"{num} -> {result}");
    }