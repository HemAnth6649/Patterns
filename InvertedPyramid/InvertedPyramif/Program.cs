class Program
{
    static void printInvertedPyramid(int n)
    {
       for(int i = 0; i < n; i++)
       {
            // Print leading spaces
            for (int space = 0; space < i; space++)
            {
                Console.Write(" ");
            }

            // Print stars
            int stars = 2 * (n - i) - 1;
            for (int star = 0; star < stars; star++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); // Move to next line
        }
    
    }
    static void Main(string[] args)
    {
        printInvertedPyramid(5);
    }
}