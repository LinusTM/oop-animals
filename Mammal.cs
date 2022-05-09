namespace oop_animals;

internal abstract class Mammal : Animal {
    internal Mammal() : base() { }

    override string Breathe() {
        return "lungs";
    }
    
    override string delivery() {
        return "alive";
    }
}
