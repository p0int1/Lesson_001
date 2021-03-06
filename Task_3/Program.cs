using System;

/* Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать одно 
строковое поле и метод void Show().  
Реализуйте возможность добавления в книгу названия книги, имени автора и содержания. 
Выведите  на  экран  разными  цветами  при  помощи  метода  Show()  название книги, имя  автора  и 
содержание. */

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Шилдт Герберт", "Полный справочник по C#", "Книга по программированию на C#");
            Book b2 = new Book("Михаил Лабковский", "Хочу и буду", "Принять себя, полюбить жизнь и стать счастливым");
            Book b3 = new Book("Ольга Примаченко", "К себе нежно", "Книга о том, как ценить и беречь себя");

            b1.Print();
            b2.Print();
            b3.Print();

            Console.ReadKey();
        }
    }
}
