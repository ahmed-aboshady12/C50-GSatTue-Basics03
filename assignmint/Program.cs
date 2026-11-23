using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignmint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print both title and upperTitle to show that title did not change.
            //String title = "clean code";
            //String upperTitle = title.ToUpper();
            //Console.WriteLine(upperTitle);
            //Console.WriteLine(title);
            #endregion
            #region Q02
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.
            //string title_1 = "Clean Code";
            //string title_2 = "Clean Code";
            //bool isReferance= ReferenceEquals(title_1, title_2);
            //Console.WriteLine(isReferance);
            #endregion
            #region Q03
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object.Print the final result.
            //StringBuilder book = new StringBuilder();
            //book.Append("Book List");
            //book.Append(" - Updated");
            //Console.WriteLine(book);
            #endregion
            #region Q04
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.
            //StringBuilder book = new StringBuilder();
            //book.Append("Book List");
            //book.Append(" - Updated");
            //book.Replace("Book List", "Library");
            //Console.WriteLine(book);
            #endregion
            #region Q05
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator.
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine("Book: " + title + ", Pages: " + pages);
            #endregion
            #region Q06
            //Build the same sentence as above, but using string interpolation ($"...")
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine($"Book: {title}, Pages: {pages}");
            #endregion
            #region Q07
            //Build the same sentence again, but using string.Format().
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine(string.Format("Book: {0}, Pages: {1}",title,pages));
            #endregion
            #region Q08
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book"
            //int pages = 464;
            //if (pages > 300)
            //    Console.WriteLine("Long Book");
            //else
            //    Console.WriteLine("Short Book");
            #endregion
            #region Q09
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages isgreater than 300 and isAvailable is true.Use the && operator.
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //    Console.WriteLine("You can borrow this book");
            #endregion
            #region Q10
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion
            #region Q11
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel(same rule as question 8: long if pages > 300).
            //int pages = 464;
            //string sizeLabel = (pages > 300 ? "Long Book": "Short Book");
            //Console.WriteLine(sizeLabel);
            #endregion
            #region Q12
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1.Clean Code.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{1 + i}.{books[i]}");
            //}
            #endregion
            #region Q13
            //Using the same books array, use a while loop to print every book title.
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring"};
            int i = 0;
            while (i < books.Length)
            {
                Console.WriteLine($"{1 + i}.{books[i]}");
                i++;
            }
            #endregion

        }
    }
}
