using System;

/* Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется: Создать класс с именем Rectangle.  
В теле класса создать два поля, описывающие длины сторон double side1, side2.
Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого 
поля side1 и side2 инициализируются значениями аргументов.  
Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр 
прямоугольника - double PerimeterCalculator().  
Создать два свойства double Area и double Perimeter с одним методом доступа get. 
Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит 
на экран периметр и площадь. */

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Ведите длину первой стороны прямоугольника: ");
            bool result1 = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Ведите длину второй стороны прямоугольника: ");
            bool result2 = double.TryParse(Console.ReadLine(), out b);
            if(!result1 || !result2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Не удалось преобразовать одно или оба значения!");
            }
            else
            {
                Rectangle instance = new Rectangle(a, b);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Прощадь : " + instance.Area);
                Console.WriteLine("Периметр: " + instance.Perimeter);
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
