namespace oop_animals;

internal abstract class Animal {
    protected int legs;
    protected string foodType;
    protected double lifeSpan;
    protected string legType;

    protected abstract Animal() { }

    protected abstract void Breathe();
    protected abstract void Delivery();
    protected abstract void Eat();
    protected abstract void Move();
    protected abstract void MakeSound();
}
