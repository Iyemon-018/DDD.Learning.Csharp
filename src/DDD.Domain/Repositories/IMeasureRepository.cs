namespace DDD.Domain.Repositories
{
    using System.Collections.Generic;
    using Entities;

    public interface IMeasureRepository
    {
        MeasureEntity GetLatest();

        IReadOnlyList<MeasureEntity> GetData();

        void Save(MeasureEntity entity);
    }
}