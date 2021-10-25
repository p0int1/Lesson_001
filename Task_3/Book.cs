using System;

namespace Task_3
{
    class Book
    {
        Author author_inst;
        Title title_inst;
        Content content_inst;

        public Book(string author, string title, string content)
        {
            author_inst = new Author(author);
            title_inst = new Title(title);
            content_inst = new Content(content);
        }

        public void Print()
        {
            Console.WriteLine(author_inst.Show());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title_inst.Show());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(content_inst.Show() + "\n");
            Console.ResetColor();
        }
    }
}
