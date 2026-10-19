using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_pre_trainee_book
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; private set; }
        public int PublichedYear { get; private set; }

        public Book(string title, string author, int publichedYear)
        {
            Title = title;
            Author = author;
            PublichedYear = publichedYear;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Published Year: {PublichedYear}";
        }


    }
}
