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

            // Q4: StringBuilder Replace
            // =========================
      

            StringBuilder sb = new StringBuilder("Book List");
            sb.Replace("Book List", "Library");

            Console.WriteLine("\nQ4:");
            Console.WriteLine(sb);




        }
    }
}
