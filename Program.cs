/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
 лучше обойтись исключительно массивами.
 */

using System.Linq.Expressions;

System.Console.Write("Введите колличество элементов массива:");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите строки:");
string[] Array = new string [M];
for (int i = 0; i < M; i++)
{
    System.Console.WriteLine($"Строка {i+1}:");
    Array[i] = Console.ReadLine()+"";
}
PrintArray(Array);
NewArray(Array);

void NewArray (string[] Array) // Создание и вывод массива
{
    int B=0;
    for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i].Length <= 3)
            B++;
        }
    string[] NewArray = new string [B];
    B=0;
    for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i].Length <= 3)
            {
                NewArray[B++] = Array[i];
            }
        }
        PrintArray(NewArray);
}

void PrintArray(string[] Array) //Метод Вывода массива
{   
    System.Console.Write("[");
    for (int i = 0; i < Array.Length - 1; i++)
    {
        System.Console.Write($"'{Array[i]}', ");
    }
    System.Console.WriteLine($"'{Array[Array.Length - 1]}']");
}