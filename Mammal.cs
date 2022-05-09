namespace oop_animals;

internal abstract class Mammal : Animal {
    internal Mammal(int legs, string foodType, double lifeSpan, string legType) :
        base(legs, foodType, lifeSpan, legType) { }



    override internal string Breathe() {
        return "lungs";
    }
    
    override internal string Delivery() {
        return "alive";
    }
}

internal abstract class EvenToedUngulates : Mammal {
    internal EvenToedUngulates(string foodType, double lifeSpan) :
        base(4, foodType, lifeSpan, "hooves") { }

    internal override string Move() {
        return "lorum ipsum";
    }

}

internal class Zebra : EvenToedUngulates {
    internal Zebra() : base("grass", 3) { }
    

    internal override string Eat() {
        return $"I'm chompin on {this.foodType}";
    }

    internal override string MakeSound() {
        return "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
    }
}

internal class Cow : EvenToedUngulates {
    internal Cow() : base("grass", 12) {}

    internal override string Eat() {
        return $"I'm chompin on {this.foodType}";
    }

    internal override string MakeSound() {
        return "moo :)";
    }
}
