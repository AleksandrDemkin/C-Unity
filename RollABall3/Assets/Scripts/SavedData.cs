using System;

namespace RollABall
{
    /// <summary>
    /// Аргумент типа, предоставляемый в качестве T, должен совпадать с
    /// аргументом, предоставляемым в качестве U, или быть производным от него.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="R"></typeparam>
    /// <typeparam name="U"></typeparam>
    public sealed class SavedData<T, R, U> : BaseExample<R>
        where T : U
    {
        public T Position;

        public SavedData(R id) : base(id)
        {
            IdPlayer = id;
        }
    }

    public class BaseExample<T>
    {
        public T IdPlayer = default;

        public BaseExample(T id)
        {
            IdPlayer = id;
        }
    }
}