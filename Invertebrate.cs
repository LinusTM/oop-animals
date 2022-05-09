namespace oop_animals;

internal abstract class Invertebrate : Animal {
    internal Invertebrate(int legs, string foodType, double lifeSpan, string legType) :
        base(legs, foodType, lifeSpan, legType) { }

    override internal string Breathe() {
        return "Gills";
    }

    override internal string Delivery() {
        return "Eggs";
    }
}

internal class Lobster : Invertebrate {
    internal Lobster() :
        base(8, "Everything", 140, "Weird ones") { }

    override internal string Eat() {
        return $"I am chomping down on {this.foodType} meow!";
    }

    override internal string MakeSound() {
        return $"Woof!";
    }

    override internal string Move() {
        return "I do be movin";
    }
}
