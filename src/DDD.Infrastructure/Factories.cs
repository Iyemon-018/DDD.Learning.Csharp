namespace DDD.Infrastructure
{
    using Domain.Repositories;
    using Fake;

    /// <summary>
    /// 各種インスタンスを生成するためのファクトリ クラスです。
    /// </summary>
    public static class Factories
    {
        public static ISensorRepository CreateSensorRepository()
        {
            // 仮に ISensorRepository を継承したインスタンスを何らかの条件によって生成する場合はここで分岐を書く。
            // こうすることで、外部にインスタンスの生成条件を出さずに知識を隠蔽することができる。
            return new SensorFake();
        }
    }
}