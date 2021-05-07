using System;

namespace Stack
{
    partial class Program
    {
        public class Book
        {
            private string _title;
            private string _description;
            private int _year;


            public Book()
            {

            }

            public Book(string description, string title, int year)
            {
                _title = title;
                _description = description;
                _year = year;
            }
        }
    }
}
