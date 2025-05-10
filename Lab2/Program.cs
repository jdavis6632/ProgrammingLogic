namespace Lab2;

class Program
{
    static void Main(string[] args)
    { 
        // Step 1
        int myNumber = 10;
        double bigDecimal = 3.14159265;
        float smallDecimal = 30.7f;
        char myLetter = 'J';
        bool myFact = false;
        string myCat = "Bast";

        Console.WriteLine(myNumber);
        Console.WriteLine(bigDecimal);
        Console.WriteLine(smallDecimal);
        Console.WriteLine(myLetter);
        Console.WriteLine(myFact);
        Console.WriteLine(myCat);

        // Step 2
        double myDouble = 9.78;
        int myInt = (int) myDouble;
        Console.WriteLine(Convert.ToString(myNumber));  
        Console.WriteLine(Convert.ToString(myFact)); 
        
        // Step 3

        Console.WriteLine("Enter a Username!");
        string enteredName = Console.ReadLine();

        Console.WriteLine("How old are you?");
        string enteredAge = Console.ReadLine();
        Convert.ToInt32(enteredAge);

        Console.WriteLine("Is " + enteredAge + " correct? " + enteredName);

        // Step 4

        int myDigit1 = 72;
        int myDigit2 = 23;

        // First digit

        int sum1 = myDigit1 + 10;
        int sum2 = sum1 - 2;
        int sum3 = sum2 * 3;
        int sum4 = sum3 / 2;
        int sum5 = sum4 % 2;
        Console.WriteLine(sum5);

        // Second digit

        int sumOne = myDigit2 + 10;
        int sumTwo = sumOne - 2;
        int sumThree = sumTwo * 3;
        int sumFour = sumThree / 2;
        int sumFive = sumFour % 2;
        Console.WriteLine(sumFive);

        // Step 5

        float sameNum1 = 1.123456789f;
        double sameNum2 = 1.123456789;

        Console.WriteLine(sameNum1);
        Console.WriteLine(sameNum2);

        // Step 6

        int blankVariable = 10;
        blankVariable++;
        Console.WriteLine(blankVariable);

        blankVariable--;
        Console.WriteLine(blankVariable);






    }
}
