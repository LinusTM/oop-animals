namespace oop_animals;

internal abstract class Fish : Animal {
    internal Fish(int legs, string foodType, double lifeSpan, string legType) : 
        base(legs, foodType, lifeSpan, legType) { }

    override internal string Breathe() {
        return "Gills";
    }
    
    override internal string Delivery() {
        return "Eggs";
    }
}

internal class Shark : Fish {
    internal Shark() : base(0, "meat", 30, "fins") { }
    
    internal override string Move() {
        return "I swim";
    }

    internal override string Eat() {
        return $"I'm chompin on {this.foodType}";
    }

    internal override string MakeSound() {
        return "bubble bubble chomp";
    }
}

internal class Ray : Fish {
    internal Ray() : base(0, "meat", 30, "fins") { }
    
    internal override string Move() {
        return "I pancake";
    }

    internal override string Eat() {
        return $"I'm chompin on {this.foodType}";
    }

    internal override string MakeSound() {
        return "WoOOoOOOoOOooO";
    }
}
