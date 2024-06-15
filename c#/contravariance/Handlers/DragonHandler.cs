public class DragonHandler : IHandler<Dragon>
{
    public void Handle(Dragon dragon)
    {
        Console.WriteLine($"Handling dragon: {dragon.size}, Breed: {dragon.Name}");
    }
}