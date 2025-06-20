class pyramid
{
    static void PrintPyramid(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int space = 1; space <=n - i; space++)
            {
                Console.Write(" ");
            }
            for (int star = 1; star <= 2 * i - 1; star++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
    }
    public static void Main(string[] args)
    {
        PrintPyramid(5);
    }
}