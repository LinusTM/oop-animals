namespace oop_animals;

class Rock {
    private int size;
    internal int Size {
        get => size;
        set => size = value;
    }

    private string color;
    internal string Color {
        get => color;
        set => color = value;
    }


    internal Rock(int size, string color) {
        this.size = size;
        this.color = color;
    }
}
