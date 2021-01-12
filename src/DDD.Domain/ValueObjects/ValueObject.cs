namespace DDD.Domain.ValueObjects
{

    /// <summary>
    /// 値クラスで共通する機能を定義するクラスです。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        /// <summary>Determines whether the specified object is equal to the current object.</summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        /// <see langword="true" /> if the specified object  is equal to the current object; otherwise, <see langword="false" />.</returns>
        public override bool Equals(object? obj)
        {
            if (!(obj is T vo))
            {
                return false;
            }

            return EqualsCore(vo);
        }

        public static bool operator ==(ValueObject<T> vo1
                                     , ValueObject<T> vo2)
        {
            return Equals(vo1, vo2);
        }

        public static bool operator !=(ValueObject<T> vo1
                                     , ValueObject<T> vo2)
        {
            return !Equals(vo1, vo2);
        }

        /// <summary>Serves as the default hash function.</summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        protected abstract bool EqualsCore(T other);
    }
}