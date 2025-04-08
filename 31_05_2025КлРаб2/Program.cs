using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_05_2025КлРаб2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Работа 1. Проект 2.";
            Console.WindowWidth = 60;
            Console.WindowHeight = 13;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(15, 6);



            Console.WriteLine("Привет , как тебя звать?"); // приветствие
            string imya = Console.ReadLine();                   // считывает вводимые данные, сохраняя их в imya
            Console.WriteLine($"А ну тебя зовут {imya}, ну сходи "); // плейсхолдер
            Console.ReadKey();
            

            
        }
    }
}
