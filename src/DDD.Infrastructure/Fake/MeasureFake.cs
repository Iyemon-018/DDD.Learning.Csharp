namespace DDD.Infrastructure.Fake
{
    using Domain.Entities;
    using Domain.Helpers;
    using Domain.Repositories;

    internal sealed class MeasureFake : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            return new MeasureEntity("guidA", "2017/01/01 13:00:00".ToDate(), 1.23456f);
        }
    }
}