// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите 2 числа: ");
int a1 = int.Parse(Console.ReadLine()!);
int b1 = int.Parse(Console.ReadLine()!);
if (a1 == b1) { Console.WriteLine("Числа одинаковые!"); }
else if (a1 > b1) { Console.WriteLine("Max = " + a1 + " Min = " + b1); }
else { Console.WriteLine("Max = " + b1 + " Min = " + a1); }