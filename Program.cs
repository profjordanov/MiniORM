namespace MiniORMLive
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CustomORM.Core;
    using MiniORMLive.Entities;
    using MiniORM;

    class Program
    {
        static void Main()
        {
            string connectionString = new ConnectionStringBuilder("TestDatabase").ConnectionString;
            IDbContext context = new EntityManager(connectionString, true);

            #region //Task 11 Fetch Users  
            IEnumerable<User> users = context.FindAll<User>("Age >= 18 ");
            foreach (var user in users)
            {
                Console.WriteLine(user.Username);
            }
            #endregion

            #region //Task 12 Add New Entity 
            //List<Book> books = new List<Book>()
            //{
            //    new Book("Harry Potter and the Cursed Child - Parts I & II", "J.K. Rowling , Jack Thorne , John Tiffany", new DateTime(2015, 10, 2), "English", true),
            //    new Book("Merchant of Venice", "Shakespeare W.", new DateTime(2013, 11, 3), "English", false),
            //    new Book("Short Stories from the Nineteenth Century", "Davies D.S.(Ed.)", new DateTime(2011, 12, 4), "English", false),
            //    new Book("The Horror in the Museum: Collected Short Stories Vol.2", "Lovecraft H.P.", new DateTime(2004, 1, 5), "English", true),
            //    new Book("Twenty Thousand Leagues Under the Sea", "Verne J.", new DateTime(2042, 7, 6), "English", false),
            //    new Book("Mansfield Park", "Austen J.", new DateTime(2003, 6, 7), "English", true),
            //    new Book("Adventures & Memoirs of Sherlock Holmes", "Doyle A.C.", new DateTime(2023, 2, 8), "English", true),
            //    new Book("Lord Jim", "Conrad J.", new DateTime(2052, 4, 9), "English", false),
            //    new Book("Three Musketeers", "Dumas A.", new DateTime(2012, 1, 30), "English", true),
            //    new Book("Tale of Two Cities", "Dickens C.", new DateTime(2005, 5, 21), "English", false),
            //};

            //foreach (Book book in books)
            //{
            //    context.Persist(book);
            //}

            //int lenghtOfTitle = int.Parse(Console.ReadLine());
            //IEnumerable<Book> wantedBooks = context.FindAll<Book>($"LEN(Title) >= {lenghtOfTitle} AND IsHardCovered = 1");
            //
            //int numberOfBooksWithGivenLen = 0;
            //foreach (Book book in wantedBooks)
            //{
            //    book.Title = book.Title.Substring(0, lenghtOfTitle);
            //    context.Persist(book);
            //    numberOfBooksWithGivenLen++;
            //}
            //
            //Console.WriteLine($"{numberOfBooksWithGivenLen} books now have title with lenght of {lenghtOfTitle}");
            #endregion

            #region // Task 13 Update Entity
            //List<Book> books = new List<Book>()
            //{
            //    new Book("Harry Potter and the Cursed Child - Parts I & II", "J.K. Rowling , Jack Thorne , John Tiffany", new DateTime(2015, 10, 2), "English", true, 1),
            //    new Book("Merchant of Venice", "Shakespeare W.", new DateTime(2013, 11, 3), "English", false, 2.3m),
            //    new Book("Short Stories from the Nineteenth Century", "Davies D.S.(Ed.)", new DateTime(2011, 12, 4), "English", false, 4),
            //    new Book("The Horror in the Museum: Collected Short Stories Vol.2", "Lovecraft H.P.", new DateTime(2004, 1, 5), "English", true, 6.4m),
            //    new Book("Twenty Thousand Leagues Under the Sea", "Verne J.", new DateTime(2042, 7, 6), "English", false, 7),                          
            //    new Book("Mansfield Park", "Austen J.", new DateTime(2003, 6, 7), "English", true, 9.2m),
            //    new Book("Adventures & Memoirs of Sherlock Holmes", "Doyle A.C.", new DateTime(2023, 2, 8), "English", true, 10),
            //    new Book("Lord Jim", "Conrad J.", new DateTime(2052, 4, 9), "English", false, 8.2m),
            //    new Book("Three Musketeers", "Dumas A.", new DateTime(2012, 1, 30), "English", true, 5.2m),
            //    new Book("Tale of Two Cities", "Dickens C.", new DateTime(2005, 5, 21), "English", false, 2.1m),
            //};
            //
            //foreach (Book book in books)
            //{
            //    context.Persist(book);
            //}

            //IEnumerable<Book> wantedBook = context.FindAll<Book>();
            //wantedBook = wantedBook.OrderByDescending(book => book.Rating).ThenBy(book => book.Title).Take(3);
            //
            //foreach (Book book in wantedBook)
            //{
            //    Console.WriteLine($"{book.Title} ({book.Author}) - {book.Rating/10}");
            //}

            #endregion

            #region //Task 14 Update records

            //int year = int.Parse(Console.ReadLine());
            //IEnumerable<Book> books = context.FindAll<Book>($"YEAR(PublishedOn) > {year} AND IsHardCovered = 1");
            //int count = 0;
            //foreach (Book book in books)
            //{
            //    book.Title = book.Title.ToUpper();
            //    context.Persist(book);
            //    count++;
            //}
            //
            //Console.WriteLine($"Books released after {year} year: {count}");
            //foreach (Book book in books)
            //{
            //    Console.WriteLine(book.Title);
            //}


            #endregion

            #region //Task 15 Delete records    
            //IEnumerable<Book> books = context.FindAll<Book>("Rating < 2");
            //int deletedBooks = 0;
            //foreach (Book book in books)    
            //{
            //    context.Delete<Book>(book);
            //    Console.WriteLine(book.Title);
            //    deletedBooks++;
            //}
            //
            //Console.WriteLine($"{deletedBooks} books have been deleted from the database");    
            #endregion

            #region //Tasks 16 Delete inactive users

            //List<User> users = new List<User>()
            //{
            //  new User("Gosho", "asd", 12, new DateTime(1992, 3, 30, 12, 15, 19), new DateTime(2015, 3, 5, 14, 12, 12), false),
            //  new User("Pesho", "eiw", 4, new DateTime(2001, 5, 23, 1, 15, 19), new DateTime(2003, 3, 5, 14, 12, 12), false),
            //  new User("Slav", "dda", 42, new DateTime(2005, 7, 28, 2, 15, 19), new DateTime(2016, 3, 5, 14, 12, 12), true),
            //  new User("Bojo", "vcx", 32, new DateTime(2015, 9, 12, 3, 15, 19), new DateTime(2016, 3, 5, 14, 12, 12), false),
            //  new User("Joro", "rew", 22, new DateTime(2013, 2, 13, 3, 15, 19), new DateTime(2013, 3, 5, 14, 12, 12), true),
            //  new User("Katq", "qwe", 44, new DateTime(1999, 2, 15, 4, 15, 19), new DateTime(2000, 3, 5, 14, 12, 12), false),
            //  new User("Rori", "ksa", 52, new DateTime(2014, 1, 19, 5, 15, 19), new DateTime(2014, 3, 5, 14, 12, 12), true),
            //  new User("Emil", "fds", 10, new DateTime(2001, 10, 7, 6, 15, 19), new DateTime(2004, 3, 5, 14, 12, 12), true),
            //  new User("Kolio", "dsa", 36, new DateTime(1995, 7, 2, 12, 15, 19), new DateTime(1999, 3, 5, 14, 12, 12), false),
            //};

            //foreach (var user in users)
            //{
            //    context.Persist(user);
            //}

            //string username = Console.ReadLine();
            //User wantedUser = context.FindFirst<User>($"Username = '{username}'");
            //
            //var timedifference = DateTime.Now - wantedUser.LastLoginTime;
            //double seconds = timedifference.TotalSeconds;
            //
            //if (seconds < 1)
            //{
            //    Console.WriteLine("less than a second");
            //}
            //else if (ConvertSecondsToMinutes(seconds) < 1)
            //{
            //    Console.WriteLine("less than a minute");
            //}
            //else if (ConvertSecondsToHours(seconds) < 1)
            //{
            //    Console.WriteLine($"{(int)ConvertSecondsToMinutes(seconds)} minutes ago");
            //}
            //else if (ConvertSecondsToDays(seconds) < 1)
            //{
            //    Console.WriteLine($"{(int)ConvertSecondsToHours(seconds)} hours ago");
            //}
            //else if (ConvertSecondsToMonths(seconds) < 1)
            //{
            //    Console.WriteLine($"{(int)ConvertSecondsToDays(seconds)} days ago");
            //}
            //else if (ConvertSecondsToYears(seconds) < 1)
            //{
            //    Console.WriteLine($"{(int)ConvertSecondsToMonths(seconds)} moths ago");
            //}                       
            //else
            //{              
            //    Console.WriteLine("more than a year");
            //}
            //
            //if (!wantedUser.IsActive)
            //{
            //    Console.WriteLine("Would you like to delete that user? (yes/no)");
            //    string confirmation = Console.ReadLine();
            //
            //    if (confirmation.ToLower() == "yes")
            //    {
            //        context.Delete<User>(wantedUser);
            //        Console.WriteLine($"User {username} was successfully deleted from the database");
            //    }
            //    else if (confirmation.ToLower() == "no")
            //    {
            //        Console.WriteLine($"User {username} was not deleted from the database");
            //    }
            //    else
            //    {
            //        throw new ArgumentException("The given answer is not valid!");
            //    }
            //}

            #endregion
        }

        private static double ConvertSecondsToYears(double seconds)
        {
            return ConvertSecondsToMonths(seconds) / 365;
        }

        private static double ConvertSecondsToMonths(double seconds)
        {
            return ConvertSecondsToDays(seconds) / 30;
        }

        private static double ConvertSecondsToDays(double seconds)
        {
            return ConvertSecondsToHours(seconds) / 24;
        }

        private static double ConvertSecondsToHours(double seconds)
        {
            return ConvertSecondsToMinutes(seconds) / 60;
        }

        private static double ConvertSecondsToMinutes(double seconds)
        {
            return seconds / 60;
        }
    }
}
