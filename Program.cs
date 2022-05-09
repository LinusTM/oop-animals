namespace oop_animals;

class Program {
    static void Main(string[] args) {
        Animal cow = new Cow();

        Console.WriteLine(cow.MakeSound());
        Console.WriteLine(cow.Breathe());
    }
}
