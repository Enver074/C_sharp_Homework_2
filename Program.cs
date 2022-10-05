// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("------Первое задание ------");
// Console.WriteLine("Введите трехзначное число");
// int number = int.Parse(Console.ReadLine()!);
// if ((number>=100) && (number<1000)){
//     int num1 = number%100;
//     int num2 = num1/10;
//     Console.WriteLine($"Вторая цифра числа {number} - {num2}"); } 
// else 
// {
//    Console.WriteLine($"Число {number} не трехзначное"); 
//    }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000)

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("------Второе задание ------");
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
if ((number>=100) && (number<1000)){
    int num1 = number%100;
    int num2 = num1/10;
    Console.WriteLine($"Вторая цифра числа {number} - {num2}"); } 
if ((number>=1000) && (number<10000)){
    int num1 = number%1000;
    int num2 = num1/100;
    Console.WriteLine($"Вторая цифра числа {number} - {num2}"); }
if ((number>=10000) && (number<100000)){
    int num1 = number%10000;
    int num2 = num1/1000;
    Console.WriteLine($"Вторая цифра числа {number} - {num2}"); }    
if (number<100)
    {
    Console.WriteLine("Нет третьей цифры"); 
    }
else
    {
    Console.WriteLine("Число больше 100000"); 
    }