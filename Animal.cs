namespace oop_animals;

internal abstract class Animal {
    private int legs;
    internal int Legs {
        get => legs;
    }

    private string foodType;
    internal string FoodType {
        get => foodType;
    }

    private double lifeSpan;
    internal double LifeSpan {
        get => lifeSpan;
    }

    private string legType;
    internal string LegType {
        get => legType;
    }

    Animal(int legs, string foodType, double lifeSpan, string legType) {
        this.legs = legs;
        this.foodType = foodType;
        this.lifeSpan = lifeSpan;
        this.legType = legType;
    }

    internal abstract string Breathe();
    internal abstract string Delivery();
    internal abstract string Eat();
    internal abstract string Move();
    internal abstract string MakeSound();
}
