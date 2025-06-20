class program
{
    static void printInvertedRightAngle(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public static void Main(String[] args)
    {
        printInvertedRightAngle(4);
    }
}