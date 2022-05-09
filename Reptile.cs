namespace oop_animals;

internal abstract class Reptile : Animal {
    internal Reptile(int legs, string foodType, double lifeSpan, string legType) : 
        base(legs, foodType, lifeSpan, legType) { }

    override internal string Breathe() {
        return "Lungs";
    }
    
    override internal string Delivery() {
        return "Eggs";
    }
}

internal class Snake : Reptile {
    internal Snake() : base(0, "meat", 20, "no legs?") { }
    
    internal override string Move() {
        return "i slither";
    }

    internal override string Eat() {
        return $"I'm chompin on {this.foodType}";
    }

    internal override string MakeSound() {
        return "HISSS";
    }
}
