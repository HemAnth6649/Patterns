using System;

 class Program
{
    static void printSolidRectangle(int row,int col)
    {
        
        for (int i = 0; i < row; i++) // Loop for rows
        {
            for (int j = 0; j < col; j++) // Loop for columns
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Move to the next line after each row
        }
    }
    static void Main()
    {
        printSolidRectangle(5,6);
    }
}
