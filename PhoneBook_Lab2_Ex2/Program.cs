using System;


namespace PhoneBook_Lab2_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            String category;
            String input1;
            String input2;
            int input3;

            bool exit = true;

            PhoneBook obj1 = new PhoneBook();

            while (exit)
            {

                Console.WriteLine("What would you like to do with your phone? " +"\n"+
                    "--> 1 for see all books, films or contact list " + "\n" +
                    "--> 2 for add a new book, film or contact" + "\n" +
                    "--> 3 for exit" );

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n"+"what would you like to see? ('Books','Film','People')"+"\n");
                        category = Console.ReadLine();
                        Console.WriteLine(obj1.getAllInfo(category));
                        break;
                    case 2:
                        Console.WriteLine("\n"+"what would you like to add ? ('Books', 'Film', 'People')"+"\n");
                        category = Console.ReadLine();
                        if (category.Equals("Books"))
                        {
                            Console.WriteLine("Write the name of the book :");
                            input1 = Console.ReadLine();
                            Console.WriteLine("Write the name of the author :");
                            input2 = Console.ReadLine();
                            Console.WriteLine("How much pages does this book have? :");
                            input3 = Convert.ToInt32(Console.ReadLine());
                            obj1.addItem(category, input1, input2, input3);
                            Console.WriteLine("The Book added");
                        }
                        else if (category.Equals("Film"))
                        {
                            Console.WriteLine("Write the name of the Film :");
                            input1 = Console.ReadLine();
                            Console.WriteLine("Write the name of the director :");
                            input2 = Console.ReadLine();
                            Console.WriteLine("How long is this film? :");
                            input3 = Convert.ToInt32(Console.ReadLine());
                            obj1.addItem(category, input1, input2, input3);
                            Console.WriteLine("The Film added");
                        }
                        else if (category.Equals("People"))
                        {
                            Console.WriteLine("Write the name of the Contact :");
                            input1 = Console.ReadLine();
                            Console.WriteLine("Write the surname of the Contact :");
                            input2 = Console.ReadLine();
                            Console.WriteLine("Phone number ? :");
                            input3 = Convert.ToInt32(Console.ReadLine());
                            obj1.addItem(category, input1, input2, input3);
                            Console.WriteLine("The Contact added");
                        }
                        break;
                    case 3:
                        exit = false;
                        break;
                }


            }
        }
    }
}
