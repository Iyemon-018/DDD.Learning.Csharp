namespace DDD.Domain.Repositories
{
    using Entities;

    public interface IMeasureRepository
    {
        MeasureEntity GetLatest();
    }
}