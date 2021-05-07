using System;

namespace Stack
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string title;
            string description;
            int year;
            title = "Snow White";
            description = "Princcess who bites an poison apple.";
            year = 1937;
            Book book = new Book(description, title, year);

           

            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(book);
           
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //stack.Clear();

        }
    }

}