namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        // Step 1
        for (int a = 0;  a <=10;  a++)
            Console.WriteLine(a);

        // Step 2
        for (int b = 1; b <= 20; b++)
            if (b % 2 == 0)
                Console.WriteLine(b);

        //Step 3
        int c = 5;
        while (c > 0)
        {
            Console.WriteLine(c);
            c--;
        }
        // Step 4
        int overHun;
        do
            {
                Console.WriteLine("Enter a Number over 100!");
                string overHundred = Console.ReadLine();
                overHun = Convert.ToInt32(overHundred);
        
            }
        
        while (overHun <= 100);
        
        // Step 5

        int multTen = 0;
        while (multTen < 1000)
        {
            multTen = multTen + 10;
            Console.WriteLine(multTen);
        }

        //Step 6

        for (int outer = 1; outer <= 10; outer++) // Outer loop controls the rows
        {

            for (int inner = 1; inner <= outer; inner++) // Inner loop prints * i times
                {
                    Console.Write("*");
                }
            Console.WriteLine(); 
        }



    }
}
