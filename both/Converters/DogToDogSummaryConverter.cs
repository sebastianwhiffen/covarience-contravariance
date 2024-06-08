namespace Both;
public class DogToDogSummaryConverter : IConverter<Dog, DogSummary>
{
    public DogSummary Convert(Dog dog)
    {
        return new DogSummary { Summary = $"Dog: {dog.Name}", DogDetails = $"Breed: {dog.Breed}" };
    }
}
