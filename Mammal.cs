namespace oop_animals;

internal abstract class Mammal : Animal {
    internal Mammal() : base(legs, foodType, lifeSpan, legType) { }

    override internal string Breathe() {
        return "lungs";
    }
    
    override internal string Delivery() {
        return "alive";
    }
}

internal abstract class EvenToedUngulates : Mammal {
    internal EvenToedUngulates() : base(4, foodType, lifeSpan, "hooves") { }

    internal override string Move() {
        return "cum";
    }

}

internal class Zebra : EvenToedUngulates {
    internal Zebra() : base(legs, "grass", 3, legType) { }
    

    internal override string Eat() {
        return $"I'm chompin on {FoodType}";
    }

    internal override string MakeSound() {
        return "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
    }
}

internal class Cow : EvenToedUngulates {
    internal Cow() : base(legs, "grass", 12, legType) {}

    internal override string Eat() {
        return $"I'm chompin on {FoodType}";
    }

    internal override string MakeSound() {
        return "moo :)";
    }
}
