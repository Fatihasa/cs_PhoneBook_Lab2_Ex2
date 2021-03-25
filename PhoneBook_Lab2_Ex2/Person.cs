using System;
using System.Collections.Generic;
using System.Linq;


namespace PhoneBook_Lab2_Ex2
{
    class Person
    {

        List<Books> books;
        List<Film> films;
        List<People> people;

        public Person(){}

        public List<Books> SortBooks(List<Books> books)
        {
            return this.books = books.OrderBy(o => o.bookName).ToList();
        }

        public List<Film> SortFilm(List<Film> films)
        {
            return this.films = films.OrderBy(o => o.filmName).ToList();
        }

        public List<People> SortPeople(List<People> people)
        {
            return this.people = people.OrderBy(o => o.name).ToList();
        }


    }
}
