namespace DDD.Tests.Mock.Infrastructure
{
    using Domain.Repositories;

    internal sealed class SensorMock : ISensorRepository
    {
        public float GetData()
        {
            return 1.23456f;
        }
    }
}