namespace DDD.Domain.ValueObjects
{
    using System;

    /// <summary>
    /// 計測値を表す値クラスです。
    /// 計測値に関わるドメインロジックは全てここに記述します。
    /// </summary>
    public sealed class MeasureValue : ValueObject<MeasureValue>
    {
        public static readonly string UnitName = "m/s";

        public MeasureValue(float value)
        {
            Value = value;
        }

        public float Value { get; }

        public string DisplayValue => Math.Round(Value, 2) + UnitName;
        
        protected override bool EqualsCore(MeasureValue other)
        {
            return Value == other.Value;
        }
    }
}