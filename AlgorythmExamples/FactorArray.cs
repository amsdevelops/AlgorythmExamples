using System;
class FactorArray<T> : ExtendableArray<T>
{
    private int _factor;

    public FactorArray(int factor)
    {
        _factor = factor;
    }

    protected override T[] GetExtendedArray()
    {
       return new T[_array.Length * _factor];
    }
}

