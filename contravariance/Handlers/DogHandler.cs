namespace Contravariance;

public class DogHandler : IHandler<Dog>
{
    public void Handle(Dog dog)
    {
        Console.WriteLine($"Handling dog: {dog.Name}, Breed: {dog.Breed}");
    }
}
