using System;

/* Задание 4
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать классы Point и Figure.  
Класс Point должен содержать два целочисленных поля и одно строковое поле. 
Создать три свойства с одним методом доступа get.  
Создать  пользовательский  конструктор, в  теле  которого  проинициализируйте  поля  значениями 
аргументов.  Класс  Figure  должен  содержать  конструкторы, которые  принимают  от  3-х  до  5-ти 
аргументов типа Point. 
Создать два метода: double LengthSide(Point A, Point B),  который рассчитывает  длину 
стороны  многоугольника; void PerimeterCalculator(),  который рассчитывает  периметр 
многоугольника. 
Написать программу, которая выводит на экран название и периметр многоугольника.  */

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure1 = new Figure(new Point(1, 1, "A"), new Point(1, 4, "B"), new Point(4, 4, "C"));
            Figure figure2 = new Figure(new Point(6, 7, "A"), new Point(9, 11, "B"), new Point(13, 8, "C"), new Point(9, 4, "D"));
            Figure figure3 = new Figure(new Point(11, 2, "A"), new Point(12, 5, "B"), new Point(15, 6, "C"), new Point(17, 4, "D"), new Point(16, 2, "E"));

            figure1.PerimeterCalculator();
            figure2.PerimeterCalculator();
            figure3.PerimeterCalculator();
        }
    }
}
