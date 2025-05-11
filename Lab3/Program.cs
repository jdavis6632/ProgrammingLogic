namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 5;
        int c = 15;
        Console.WriteLine(a > b);
        Console.WriteLine(a < c);
        Console.WriteLine(a > b && a > c);
        Console.WriteLine(a > b || a > c);
        // Step 2

        bool isRaining = true;
        bool haveUmbrella = false;
        
        if (isRaining == true)
            if (haveUmbrella == false)
                Console.WriteLine("Take an Umbrella");
            if (haveUmbrella == true)
                Console.WriteLine("You're good to go!");
        else
        {
            Console.WriteLine("You're good to go!");

        }

        // Step 3
        Console.WriteLine("Enter Age Here!");
        string enteredAge = Console.ReadLine();
        int ageNum = Convert.ToInt32(enteredAge);
        if (ageNum < 5)
            Console.WriteLine("Ticket is Free");
         else if (ageNum >= 5 && ageNum <= 12)
            Console.WriteLine("Child ticket: $5");
         else if (ageNum >= 13 && ageNum <= 64)
            Console.WriteLine("Standard Ticket: $10");
         else if (ageNum >= 65)
            Console.WriteLine("Senior Ticket: $6");

        



            {
                
            }
    }
}
