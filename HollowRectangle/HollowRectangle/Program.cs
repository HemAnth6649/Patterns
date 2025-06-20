
namespace SolidRectangle
{
    public class Program
    {

        static void PrintHollowRectangle(int rows, int cols)
        {
            for (int i = 0; i < rows; i++) // loop through rows
            {
                for (int j = 0; j < cols; j++) // loop through columns
                {
                    // Print '*' at borders, else space
                    if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(); // move to next row
            }
        }

        public static void Main(string[] args)
        {
            PrintHollowRectangle(4,6);
        }


    }

}

