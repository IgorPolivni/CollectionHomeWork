using System;
using System.Collections.Generic;

namespace CollectionHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Random random = new Random();
            var list = new List<int>();
            const int sizeArray = 20;
            for (int i = 0; i < sizeArray; i++)
            {
                list.Add(random.Next(1, 10));
            }

            Console.WriteLine("Все элементы Листа: ");
            foreach (var element in list)
            {
                Console.Write($"{element} ");
            }

            int maxValue = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > maxValue)
                {
                    maxValue = list[i];
                }
            }

            int preMaxValue = list[0];
            int maxPosition = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > preMaxValue && list[i] != maxValue)
                {
                    preMaxValue = list[i];
                    maxPosition = i;
                }
            }
            Console.WriteLine($"\nВторое максимальное значение в коллекции: Позиция = {maxPosition } и значение элемента = {preMaxValue}");

            Console.ReadLine( );
            Console.Clear();
            //Задание 2
            MyList myList = new MyList();
            for (int i = 0; i < sizeArray; i++)
            {
                myList.Add(random.Next(1, 10));
            }
            Console.WriteLine("Все элементы Листа: ");
            foreach (var element in myList)
            {
                Console.Write($"{element} ");
            }
            myList.Sort();
            Console.WriteLine("\nВсе элементы Листа после сортировки: ");
            foreach (var element in myList)
            {
                Console.Write($"{element} ");
            }



        }

    }
}
