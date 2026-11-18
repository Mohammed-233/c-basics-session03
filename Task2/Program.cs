using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace Task2
{
    internal class Program
    {
        #region Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty, use return to exit the method early instead of printing anything.
        public void PrintFirstBook(string[] books)
        {
            if (books == null || books.Length == 0)
            {
                return;
            }

            Console.WriteLine(books[0]);
        }
        #endregion
        static void Main(string[] args)
        {
            #region Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Printboth title and upperTitle to show that title did not change.
            //string title= "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine($"title:{title}");
            //Console.WriteLine($"upperTitle:{upperTitle}");
            #endregion
            #region Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()to check if they point to the same object in memory.
            //string str1 = "Clean Code";
            //string str2 = "clean code";
            //Console.WriteLine(ReferenceEquals(str1,str2));
            #endregion
            #region Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the sameobject.Print the final result.
            //StringBuilder sb = new StringBuilder("");
            //sb.Append("Book List");
            //sb.AppendLine(" - Updated");
            //Console.WriteLine(sb);
            #endregion
            #region Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".Print the result.
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);
            #endregion
            #region Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,Pages: 464" using the + operator.
            //string title = "Clean Code";
            //int pages = 464;
            //string str = "book: "+title+ ", pages: " + pages;
            //Console.WriteLine(str);
            #endregion
            #region Build the same sentence as above, but using string interpolation ($"...").
            //string str = $"Book :{title}, Pages:{pages}";
            //Console.WriteLine(str);
            #endregion
            #region Build the same sentence again, but using string.Format().
            //string str = string.Format("Book :{0}, pages: {1} ", title, pages);
            //Console.WriteLine(str);
            #endregion
            #region Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book".
            //int pages = 464;
            //if (pages >= 300) 
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}
            #endregion
            #region Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages isgreater than 300 and isAvailable is true.Use the && operator.
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages >= 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            //else 
            //{
            //    Console.WriteLine("No you cannot borrow this book");
            //}
            #endregion
            #region Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "clean code":
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
            #region Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into avariable sizeLabel(same rule as question 8: long if pages > 300).
            //int pages = 464;
            //string str = pages >300?"Long book":"Short book";
            //Console.WriteLine(str);
            #endregion
            #region Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loopto print each book with its position number, like 1.Clean Code.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ". " + books[i]);
            //}


            #endregion
            #region Using the same books array, use a while loop to print every book title.
            // string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;   
            // while (i<books.Length)
            // {
            //     Console.WriteLine((i + 1) + ". " + books[i]);
            //     i++;
            // }
            #endregion
            #region Write a do-while loop that prints "Checking book..." exactly 3 times.
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //} while (i < 3);
            #endregion
            #region Using the same books array, use a foreach loop to print every book title.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach(string str in books)
            //{
            //    Console.WriteLine(str);
            //}
            #endregion
            #region Using the same books array, loop through it and print each title, but stop completely (break) onceyou reach "Refactoring".
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for(int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "Refactoring")
            //    {
            //        break;
            //    }
            //    Console.WriteLine((i + 1) + ". " + books[i]);
            //}
            #endregion
            #region Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop).
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i=0; i < books.Length; i++) 
            //{
            //    if (books[i] == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }
            //    Console.WriteLine((i + 1) + ". " + books[i]);
            //}
            #endregion

        }
    }
}
