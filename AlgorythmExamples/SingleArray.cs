using System;
class SingleArray<T> : ExtendableArray<T>
{
    protected override T[] GetExtendedArray()
    {
        return new T[_array.Length + 1];
    }
}

