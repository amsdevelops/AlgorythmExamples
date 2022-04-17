using System;
class VectorArray<T> : ExtendableArray<T>
{
    private int _extendVector;
    public VectorArray(int extendVector)
    {
        _extendVector = extendVector;
    }

    protected override T[] GetExtendedArray()
    {
        return new T[_array.Length + _extendVector];
    }
}

