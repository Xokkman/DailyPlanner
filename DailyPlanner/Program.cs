using System;
using System.Data;
using System.ComponentModel.Design;
using static System.ConsoleKey;
DateTime date = new DateTime(2022, 11, 8);
int position = 1;
Console.WriteLine(date);
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.UpArrow)
    {
        position--;
    }
    if (key.Key == ConsoleKey.DownArrow)
    {
        position++;
    }
    if (key.Key == ConsoleKey.LeftArrow)
    {
        date = date.AddDays(-1);
        Console.WriteLine(date);
    }
    if (key.Key == ConsoleKey.RightArrow)
    {
        date = date.AddDays(+1);
        Console.WriteLine(date);
    }
    if (date.Day == 11)
    {
        Console.WriteLine(date);
        Console.Clear();
        Console.WriteLine(date);
        Console.WriteLine("Дата: 8.11.2022  14:40:48");
        odinzadanie();
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("Проснуться");
            }
            else if (position == 2)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("Пойти на учебу");
            }
        }
    }
    if (date.Day == 8)
    {
        Console.WriteLine(date);
        Console.Clear();
        Console.WriteLine(date);
        Console.WriteLine("Дата: 9.11.2022  15:50:58");
        dvazadanie();
        if (key.Key == ConsoleKey.Enter)
        {
            if (position == 1)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("Придти домой");
            }
            else if (position == 2)
            {
                Console.Clear();
                Console.WriteLine(date);
                Console.WriteLine("Выполнить задание");
            }
        }
    }
    Console.SetCursorPosition(0, position);
    Console.WriteLine("->");
    key = Console.ReadKey();
}
static void odinzadanie()
{
    Console.WriteLine("Пойти купить продукты в магазине");
    Console.WriteLine("Начать готовить обед");
}
static void dvazadanie()
{
    Console.WriteLine("Придти домой");
    Console.WriteLine("Выполнить проект");
}