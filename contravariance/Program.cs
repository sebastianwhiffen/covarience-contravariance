using System;

using Contravariance;

public class Program
{
    // this seems pretty standard, but the power of this lies in the specifics of the implementation,
    // go inside the handle method and you'll see that we are able to target the specific properties of the dog object
    // if we made this generic then we would pass in an Animal object and we would not be able to access the dogs Breed property
    public static void HandleAnimals(IHandler<Dog> handler, Dog dog)
    {
        handler.Handle(dog);
    }

    public static void Main()
    {
        Dog dog = new Dog { Name = "Buddy", Breed = "Golden Retriever" };
        IHandler<Animal> animalHandler = new AnimalHandler();
        IHandler<Dog> dogHandler = new DogHandler();

        HandleAnimals(animalHandler, dog);
        HandleAnimals(dogHandler, dog);
    }
}
