namespace Contravariance;

public class AnimalHandler : IHandler<Animal>
{
    public void Handle(Animal animal)
    {
        Console.WriteLine($"Handling animal: {animal.Name}");
    }
}
