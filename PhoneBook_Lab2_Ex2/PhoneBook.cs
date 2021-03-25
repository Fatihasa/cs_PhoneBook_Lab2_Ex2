using System;
using System.Collections.Generic;


namespace PhoneBook_Lab2_Ex2
{

    struct Books
    {

        public String bookName;
        public String author;
        public int pages;
        public Books(String bookName, String author, int pages)
        {
            this.bookName = bookName;
            this.author = author;
            this.pages = pages;
        }

        // Adjust this as required
        public override string ToString() =>
            $"bookName: {bookName}; author: {author}; pages: {pages}";

    }

    struct Film
    {
        public String filmName;
        public String director;
        public int howLong;

        public Film(String filmName, String director, int howLong)
        {
            this.filmName = filmName;
            this.director = director;
            this.howLong = howLong;
        }
        public override string ToString() =>
            $"filmName: {filmName}; director: {director}; howLong: {howLong}";
    }

    struct People
    {
        public String name;
        public String surname;
        public int phoneNumber;

        public People(String name, String surname, int phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }
        public override string ToString() =>
            $"name: {name}; surname: {surname}; phoneNumber: {phoneNumber}";
    }

    class PhoneBook
    {
        String str1;
        String str2;
        int intValue;
        String objName;

        List<Books> books = new List<Books>();
        List<Film> film = new List<Film>();
        List<People> people = new List<People>();

        public PhoneBook()
        {

            //adding some default items to our list
            books.Add(new Books("Treasure Island", "Robert Louis Stevenson", 200));
            books.Add(new Books("Oviwer Twist", "Charies Dickens", 380));
            books.Add(new Books("Animal Farm", "George Orwall", 243));
            books.Add(new Books("For Whom the Bell Tolls", "Ernest Hemingway", 171));

            film.Add(new Film("The Wizard of Oz", "Victor Fleming", 98 ));
            film.Add(new Film("Casablanca", "Michael Curtiz", 102));
            film.Add(new Film("West Side Story", "Robert Wise", 87));
            film.Add(new Film("The Godfather", "Francis Ford Coppola", 90));
            film.Add(new Film("Harry Potter and the Philosopher's Stone", "Chris Columbus",94 ));
            film.Add(new Film("Spider-Man", "Sam Raimi", 102));

            people.Add(new People("Tom", "Mathews", 2025550153));
            people.Add(new People("Eshaan", "Ryan", 2025550186));
            people.Add(new People("Saba", "Wyatt", 2025550198));
            people.Add(new People("Daisy-May", "Cantu", 2025550112));
            people.Add(new People("Umayr", "Barnett", 2025550141));
            people.Add(new People("Ishmael", "Estrada", 2025550127));
            people.Add(new People("Nancie", "Todd", 2025550165));
            people.Add(new People("Reese", "Gamble", 2025550818));

        }

        

        public String getAllInfo(String category)
        {
            String s = "";
            Person person = new Person();
            

            if (category.Equals("Books")) {
                List<Books> SortedBookList = person.SortBooks(books);
                for (int i = 0; i < SortedBookList.Count; i++)
                {
                    s += i + ". " + SortedBookList[i].ToString() + "\n";
                }
            }
            else if (category.Equals("Film"))
            {
                List<Film> SortedFilmList = person.SortFilm(film);
                for (int i = 0; i < SortedFilmList.Count; i++)
                {
                    s += i + ". " + SortedFilmList[i].ToString() + "\n";
                }
            }
            else if (category.Equals("People"))
            {
                List<People> SortedContactList = person.SortPeople(people);
                for (int i = 0; i < SortedContactList.Count; i++)
                {
                    s += i + ". " + SortedContactList[i].ToString() + "\n";
                }
            }
            return s;
        }

        public void addItem(String category,String value1, String value2, int value3)
        {
            if (category.Equals("Books"))
            {
                books.Add(new Books(value1, value2, value3));
            }
            else if (category.Equals("Film"))
            {
                film.Add(new Film(value1, value2, value3));
            }
            else if (category.Equals("People"))
            {
                people.Add(new People(value1, value2, value3));
            }
           
        }
    }
}
