// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите 3 числа: ");
int a1 = int.Parse(Console.ReadLine()!);
int b1 = int.Parse(Console.ReadLine()!);
int c1 = int.Parse(Console.ReadLine()!);
int [] obj = {a1,b1,c1};
Console.WriteLine("Max = "+ obj.Max());

// Второй вариант, без функций Max массива, будет закоменчен. 
// Console.WriteLine("Введите 3 числа: ");
// int a1 = int.Parse(Console.ReadLine()!);
// int b1 = int.Parse(Console.ReadLine()!);
// int c1 = int.Parse(Console.ReadLine()!);
// int m = a1;
// if (m > b1) { m = a1; }
// else { m = b1; }
// if (m < c1) { m = c1; }
//  Console.WriteLine("Max = " + m);
