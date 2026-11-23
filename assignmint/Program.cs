using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;

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
            StringBuilder book = new StringBuilder();
            book.Append("Book List");
            book.Append(" - Updated");
            book.Replace("Book List", "Library");
            Console.WriteLine(book);
            #endregion
        }
    }
}
