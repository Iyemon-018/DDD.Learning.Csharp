namespace DDD.Domain.ValueObjects
{
    using System;

    /// <summary>
    /// 計測日を表す値クラスです。
    /// </summary>
    public sealed class MeasureDate : ValueObject<MeasureDate>
    {
        public MeasureDate(DateTime value)
        {
            Value = value;
        }

        public static implicit operator MeasureDate(DateTime value)
        {
            return new MeasureDate(value);
        }

        protected override bool EqualsCore(MeasureDate other)
        {
            return Value == other.Value;
        }

        public DateTime Value { get; }

        public string DisplayValue => Value.ToString("yyyy/MM/dd HH:mm:ss");
    }
}