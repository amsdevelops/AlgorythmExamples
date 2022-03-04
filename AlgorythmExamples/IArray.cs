interface IArray<T>
{
    void Add(T item);

    T Get(int position);

    int Size();

    bool IsEmpty();
}
