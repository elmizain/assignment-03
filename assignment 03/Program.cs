using System.Text;

namespace assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Q1: String Immutability

            //// =========================
            //string title = "clean code";
            //string upperTitle = title.ToUpper();

            //Console.WriteLine("Q1:");
            //Console.WriteLine("Original: " + title);
            //Console.WriteLine("Upper: " + upperTitle);

            //// Q2: String Interning
            //// =========================
            //string str1 = "Clean Code";
            //string str2 = "Clean Code";

            //Console.WriteLine("\nQ2:");
            //Console.WriteLine(Object.ReferenceEquals(str1, str2));

            //// Q3: StringBuilder Append
            //// =========================
            //StringBuilder sb = new StringBuilder();

            //sb.Append("Book List");
            //sb.Append(" - Updated");

            //Console.WriteLine("\nQ3:");
            //Console.WriteLine(sb);

            ////======================

            //// Q4: StringBuilder Replace
            //// =========================


            //StringBuilder sb = new StringBuilder("Book List");
            //sb.Replace("Book List", "Library");

            //Console.WriteLine("\nQ4:");
            //Console.WriteLine(sb);

            //// Q5: String Concatenation (+)
            //// =========================
            //string bookTitle = "Clean Code";
            //int pages = 464;

            //string result1 = "Book: " + bookTitle + ", Pages: " + pages;

            //Console.WriteLine("\nQ5:");
            //Console.WriteLine(result1);

            //// Q6: String Interpolation
            //// =========================
            //string bookTitle = "Clean Code";
            //int pages = 464;
            //string result2 = $"Book: {bookTitle}, Pages: {pages}";

            //Console.WriteLine("\nQ6:");
            //Console.WriteLine(result2);
            //// =========================

            //// Q7: string.Format()
            //// =========================
            //string bookTitle = "Clean Code";
            //int pages = 464;
            //string result3 = string.Format("Book: {0}, Pages: {1}", bookTitle, pages);

            //Console.WriteLine("\nQ7:");
            //Console.WriteLine(result3);

            //// Q8: Null Coalescing (??)
            //// =========================
            //int? nullablePages = null;

            //Console.WriteLine("\nQ8:");
            //Console.WriteLine(nullablePages ?? 0);

            //// Q9: Null Propagation (?.)
            //// =========================
            //string? author = null;

            //Console.WriteLine("\nQ9:");
            //Console.WriteLine(author?.Length);
            //// =========================


            // Q10: Array
            // =========================
            double[] prices = { 25.5, 40.0, 33.75 };

            Console.WriteLine("\nQ10:");
            Console.WriteLine(prices[1]);
        }
    }

}
    

