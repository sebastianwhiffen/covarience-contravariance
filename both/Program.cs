using System;

namespace Both;

public class Program
{
    public static void PrintSummary(IConverter<Dog, AnimalSummary> converter, Dog dog)
    {
        AnimalSummary summary = converter.Convert(dog);
        Console.WriteLine(summary.Summary);
    }

    public static void Main()
    {
        Dog dog = new Dog { Name = "Buddy", Breed = "Golden Retriever" };

        IConverter<Animal, AnimalSummary> animalConverter = new AnimalToAnimalSummaryConverter();
        IConverter<Dog, DogSummary> dogConverter = new DogToDogSummaryConverter();

        // Using both covariance and contravariance
        PrintSummary(animalConverter, dog);
        PrintSummary(dogConverter, dog);
    }
}
