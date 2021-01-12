namespace DDD.Domain.Repositories
{
    using ValueObjects;

    public interface ISensorRepository
    {
        MeasureValue GetData();
    }
}