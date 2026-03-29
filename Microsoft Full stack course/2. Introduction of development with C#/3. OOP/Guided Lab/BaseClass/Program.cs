
public class Animal

{
    public virtual void MakeSound()

    {
        Console.WriteLine("Some generic animal sound.");
    }
}

public class Dog : Animal

{
    public override void MakeSound()
    {
        Console.WriteLine("Bark.");
    }
}

public class Cat : Animal

{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}


public class Program

{
    public static void Main()

    {
        Dog dog = new();
        Cat cat = new();

        dog.MakeSound();
        cat.MakeSound();
    }
}
