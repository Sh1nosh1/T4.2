using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.
            //Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.

            /*Write("Введите координаты вершины A: \nx = ");    //Запрашиваем координаты вершин сторон треугольника
            double x1 = Convert.ToDouble(Console.ReadLine());
            Write("y = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Write("\nВведите координаты вершины B: \nx = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Write("y = ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Write("\nВведите координаты вершины C: \nx = ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Write("y = ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double P = 0;  //Даем значение периметру

            P += Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));  //Добавили сторону AB
            P += Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));  //Добавили сторону BC
            P += Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));  //Добавили сторону AC и нашли периметр

            WriteLine($"\nПериметр треугольника ABC = {P:f2}");

            double p = P/2;  //Нашли полупериметр

            double S = Math.Sqrt(p*
                (p - Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)))*
                (p - Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)))*
                (p - Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2))));  //Нашли площадь

            Write($"\nПлощадь треугольника ABC = {S:f2}");*/

            //Задание 2
            //Стоимость поездки на автомобиле (ввод: s – расстояние, b – расход бензина на 100 км, c - цена бензина за 1 литр).

            /*Write("Введите расстояние S = ");                 //Запрашиваем данные у пользователя
            double S = Convert.ToDouble(Console.ReadLine());
            Write("Введите расход бензина на 100 км B = ");
            double B = Convert.ToDouble(Console.ReadLine());
            Write("Введите цену бензина за 1 литр C = ");
            double C = Convert.ToDouble(Console.ReadLine());

            WriteLine($"Стоимость поездки составила {(S / 100) * B * C} руб.");*/    //Находим стоимость всей поездки

            ReadKey();
        }
    }
}
