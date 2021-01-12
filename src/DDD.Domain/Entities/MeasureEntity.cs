namespace DDD.Domain.Entities
{
    using System;

    /// <summary>
    /// 計測情報を保持する Entity クラスです。
    /// </summary>
    /// <remarks>
    /// DDD では Entity は「一意」であることが決められている。
    /// このクラスでは <see cref="MeasureEntity.Id"/> を一意な値としています。
    /// </remarks>
    public sealed class MeasureEntity
    {
        public MeasureEntity(string id
                           , DateTime date
                           , float value)
        {
            Id    = id;
            Date  = date;
            Value = value;
        }

        public string Id { get; }

        public DateTime Date { get; }

        public float Value { get; }
    }
}