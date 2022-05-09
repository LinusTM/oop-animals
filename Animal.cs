namespace oop_animals;

internal abstract class Animal {
    protected int legs;
    protected string foodType;
    protected double lifeSpan;
    protected string legType;

    internal abstract void Breathe();
    internal abstract void Delivery();
    internal abstract void Eat();
    internal abstract void Move();
    internal abstract void MakeSound();
}
