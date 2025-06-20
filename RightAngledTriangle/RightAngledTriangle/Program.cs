class program
{
    static void PrintRightAngledTriangle(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++) 
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public static void Main(string[] args)
    {
        PrintRightAngledTriangle(5);
    }
}
