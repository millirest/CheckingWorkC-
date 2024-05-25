



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
 лучше обойтись исключительно массивами.
 */

System.Console.Write("Введите колличество элементов массива:");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите строки:");
string[] Array = new string [M];
for (int i = 0; i < M; i++)
{
    System.Console.Write("Строка:"+i);
    Array[i] = Console.ReadLine()+"";
}

