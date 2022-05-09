namespace oop_animals;

class Program {
    static void Main(string[] args) {
        // COW
        Console.WriteLine("---- Cow ----");
        
        Animal cow = new Cow();
        Console.WriteLine(cow.MakeSound());
        Console.WriteLine(cow.Breathe());
        
        // SNAKE
        Console.WriteLine("---- Snake ----");

        Animal snake = new Snake();
        Console.WriteLine(snake.MakeSound());
        Console.WriteLine(snake.Breathe());
        
        // SHARK
        Console.WriteLine("---- Shark ----");
        
        Animal shark = new Shark();
        Console.WriteLine(shark.MakeSound());
        Console.WriteLine(shark.Breathe());

        // LOBSTER
        Console.WriteLine("---- Lobster ----");

        Animal lobster = new Lobster();
        Console.WriteLine(lobster.MakeSound());
        Console.WriteLine(lobster.Breathe());
    }
}
