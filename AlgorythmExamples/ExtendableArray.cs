using System;
abstract class ExtendableArray<T> : IArray<T>
{
    protected T[] _array;
    private int size = 0;

    public ExtendableArray()
    {
        _array = new T[1];
    }

    protected abstract T[] GetExtendedArray();

    void IArray<T>.Add(T item)
    {
        CheckAndExtendArrayCapacity();
        _array[size + 1] = item;
        size++;
    }

    T IArray<T>.Get(int position)
    {
        return _array[position];
    }

    bool IArray<T>.IsEmpty()
    {
        return size == 0;
    }

    int IArray<T>.Size()
    {
        return size;
    }

    private void CheckAndExtendArrayCapacity()
    {
        if (_array.Length == size + 1)
        {
            T[] newArrray = GetExtendedArray();
            _array.CopyTo(newArrray, 0);
            _array = newArrray;
        }
    }
}

