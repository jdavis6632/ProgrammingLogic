namespace Lab8;

// Step 1
class Animal  
{
    
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal(); 
        myAnimal.animalSound();

         Animal myCat = new Cat();  
        myCat.animalSound(); 

        Animal myDog = new Dog();  
        myDog.animalSound();  

      
// Step 2
class Cat : Animal  
{
    
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal  
{

    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}
