namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        // Step 1

        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
 
        foreach (string season in seasons)
        {
            Console.WriteLine("Season: " + season);
        }
        
        // Step 2

        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.Write("Enter a number (1–7): ");
        string dayOW = Console.ReadLine();

        
        bool correct = int.TryParse(dayOW, out int dayNumber);

        
        if (correct && dayNumber >= 1 && dayNumber <= 7)
        {
            
            Console.WriteLine("That day is: " + days[dayNumber - 1]);
        }
        else
        {
            Console.WriteLine("Please enter a number from 1 to 7.");
        }
        // Step 3
        string[] books = { "Diary of a Wimpy Kid", "The Night Circus", "Animal Farm" };
        string[] authors = { "Jeff Kinney", "Erin Morgenstern", "George Orwell" };


        for (int a = 0; a < books.Length; a++)
        {
            Console.WriteLine("Book " + (a + 1) + ": " + books[a] + " by " + authors[a]);
        }

        // Step 4

        int[] temps = { 65, 72, 78, 70, 68 };

        
        Array.Sort(temps);

        
        Console.Write("Sorted Temperatures: ");
        foreach (int temp in temps)
        {
            Console.Write(temp + " ");
        }

        Console.WriteLine(); 

        
        int lowest = temps[0];
        int highest = temps[temps.Length - 1];

        Console.WriteLine("Highest Temperature: " + highest);
        Console.WriteLine("Lowest Temperature: " + lowest);

        // Step 5

        int[] countdown = { 5, 4, 3, 2, 1 };

        Array.Reverse(countdown);

        Console.Write("Countdown: ");
        for (int b = 0; b < countdown.Length; b++)
        {
            Console.Write(countdown[b] + " ");
        }
    }
}
