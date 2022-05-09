namespace oop_animals;

internal abstract class Mammal : Animal {
    internal Mammal() : base() { }

    override internal string Breathe() {
        return "lungs";
    }
    
    override internal string Delivery() {
        return "alive";
    }
}
