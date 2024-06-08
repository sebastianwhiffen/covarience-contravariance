namespace Both;

public class AnimalToAnimalSummaryConverter : IConverter<Animal, AnimalSummary>
{
    public AnimalSummary Convert(Animal animal)
    {
        return new AnimalSummary { Summary = $"Animal: {animal.Name}" };
    }
}