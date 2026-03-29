public class Program

{
    public static void Main()

    {
        List<Animal> animals = [];
        animals.Add(new Dog());
        animals.Add(new Cat());

        foreach (Animal animal in animals)

        {
            animal.MakeSound();
            animal.Eat();
        }
    }
}

public interface IAnimal

{
    void Eat();
}

public class Animal : IAnimal

{
    public virtual void MakeSound()

    {
        Console.WriteLine("Some generic animal sound.");
    }

    public virtual void Eat()

    {
        Console.WriteLine("Eating food");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    public override void Eat()

    {
        Console.WriteLine("Kiddle");
    }
}

public class Cat : Animal

{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public override void Eat()
    {
        Console.WriteLine("Tuna");
    }
}