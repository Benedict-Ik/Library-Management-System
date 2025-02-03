namespace Library_Management_System
{
    // Classes
    public class Book
    {
        // Properties
        public int BookID { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool IsBorrowed { get; set; }

        // Constructors
        public Book(int bookId, string title, string author)
        {
            BookID = bookId;
            Title = title;
            Author = author;
            IsBorrowed = false;
        }

        //public bool HasBeenBorrowed()
        //{
        //    if (!IsBorrowed)
        //    {
        //        IsBorrowed = true;
        //        Console.WriteLine("Referenced book has been borrowed.");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Referenced book is available.");
        //        return false;
        //    }
        //}
    }

    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        // Constructor
        public User(int userID, string name)
        {
            UserID = userID;
            Name = name;
            BorrowedBooks = new List<Book>();
        }

        public bool BorrowBook(Book book)
        {
            if (book.IsBorrowed == false)
            {
                BorrowedBooks.Add(book);
                Console.WriteLine($"{Name} successfully borrowed {book.Title}.");
                book.IsBorrowed = true;
                return false;
            }
            else
            {
                Console.WriteLine($"{book.Title} has already been borrowed.");
                return true;
            }
        }

        public bool ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsBorrowed = false;
                Console.WriteLine($"{Name} has successfully returned {book.Title}.");
                return true;
            }
            else
            {
                Console.WriteLine($"{book.Title} cannot be returned as it was not borrowed by {Name}.");
                return false;
            }
        }
    }

    public class Library
    {
        // Properties
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }

        // Constructor
        public Library()
        {
            Books = new List<Book>();
            Users = new List<User>();
        }

        // Methods
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"New book titled {book.Title} by {book.Author} has been added.");
        }

        public void ViewAvailableBooks()
        {
            int counter = 1;
            Console.WriteLine("\nBelow are the available books in the library:");
            foreach (var book in Books)
            {
                if (book.IsBorrowed == false)
                {
                    Console.WriteLine($"{counter}. {book.Title} by {book.Author}");
                    counter++;
                }
            }
        }

        public void RegisterUser(User user)
        {
            Users.Add(user);
            Console.WriteLine($"New user {user.Name} has successfully been added.");
        }

        public void BorrowBook(Book book)
        {
            //if (book.IsBorrowed != false && (book.IsBorrowed != false).co)
            if (Books.Count > 0 && book.IsBorrowed != false)
            {
                Books.Remove(book);
            }
            else
            {
                Console.WriteLine("There are no books available for borrowing.");
            }
        }

        public void ReturnBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"{book.Title} has successfully been returned.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Objects/Instances
            // Populating Books
            Book book1 = new Book(1, "To Kill a Mockingbird", "Harper Lee");
            Book book2 = new Book(2, "1984", "George Orwell");
            Book book3 = new Book(3, "Pride and Prejudice", "Jane Austen");
            Book book4 = new Book(4, "The Great Gatsby", "F. Scott Fitzgerald");
            Book book5 = new Book(5, "The Catcher in the Rye", "J.D. Salinger");
            Book book6 = new Book(6, "The Lord of the Rings", "J.R.R. Tolkien");
            Book book7 = new Book(7, "The Lion, the Witch and the Wardrobe", "C.S. Lewis");
            Book book8 = new Book(8, "War and Peace", "Leo Tolstoy");
            Book book9 = new Book(9, "Humpty Dumpty", "Herman Melville");
            Book book10 = new Book(10, "Don Quixote", "Miguel de Cervantes");

            // Populating Users
            User user1 = new User(1, "Ben");
            User user2 = new User(2, "Greg");
            User user3 = new User(3, "Alice");
            User user4 = new User(4, "Bob");

            // Implementing User functionality
            user1.BorrowBook(book9);
            user2.BorrowBook(book9);
            user1.ReturnBook(book9);
            user2.BorrowBook(book9);
            user3.BorrowBook(book7);
            user4.ReturnBook(book7);
            Console.WriteLine("");

            // Populating Library
            Library library1 = new Library();
            Console.WriteLine("");

            // Implementing Library functionality
            // Adding books
            library1.AddBook(book1);
            library1.AddBook(book2);
            library1.AddBook(book3);
            library1.AddBook(book4);
            library1.AddBook(book5);
            library1.AddBook(book6);
            library1.AddBook(book7);
            library1.AddBook(book8);
            library1.AddBook(book9);
            library1.AddBook(book10);
            Console.WriteLine("");

            // View available books
            library1.ViewAvailableBooks();
            Console.WriteLine("");

            // Registering users
            library1.RegisterUser(user1);
            library1.RegisterUser(user2);
            library1.RegisterUser(user3);
            library1.RegisterUser(user4);

            // Logs
            //Console.WriteLine($"The first book in the register is: {book1.Title}");
        }
    }
}


/*NOTES*/
/*
Explaining the code:

1. The code snippet is a simple library management system that allows users to borrow and return books from a library.
2. The system consists of three main classes: Book, User, and Library.
3. The Book class represents a book with properties such as BookID, Title, Author, and IsBorrowed. The IsBorrowed property is used to track whether the book has been borrowed by a user.
4. The User class represents a library user with properties such as UserID, Name, and BorrowedBooks. The BorrowedBooks property is a list of books that the user has borrowed.
5. The Library class represents a library with properties such as Books and Users. The Books property is a list of books available in the library, and the Users property is a list of registered users.
6. The Library class has methods to add books, view available books, register users, borrow books, and return books.
7. In the Main method, the code creates instances of books and users, populates the library with books, registers users, and demonstrates the borrowing and returning of books by users.
8. The code demonstrates the functionality of the library management system by adding books to the library, viewing available books, registering users, and allowing users to borrow and return books.
9. The code is a simple example of object-oriented programming in C# and demonstrates the use of classes, properties, methods, and lists to implement a library management system.
10. The code can be further extended to include additional features such as searching for books, tracking borrowed books, and generating reports on book borrowing activities.
 */