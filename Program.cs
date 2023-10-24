using System; // Necessary for the Console class.

class Program
{
    static void Main(string[] args)
    {
        // Display header row for the multiplication table.
        Console.WriteLine("\t1\t2\t3\t4\t5\t6\t7\t8\t9\t10\t11\t12\t13");

        // Iterate over the first 12 multiples.
        for (int i = 1; i <= 12; i++) // Adjusted to ensure it includes 12.
        {
            Console.Write($"{i}\t"); // Print the leading number for each row.

            // Compute and display the product for each entry in the current row.
            for (int j = 1; j <= 13; j++)
            {
                Console.Write($"{i * j}\t"); // Each column entry in the row.
            }

            Console.WriteLine(); // Newline for the next row of the table.
        }
    }
}