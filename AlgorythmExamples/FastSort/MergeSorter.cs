using System;
using System.Diagnostics;

class MergeSorter : IIntegerSorter
{
    public void Sort(int[] array, Stopwatch stopwatch)
    {
        stopwatch.Start();
        SortInternal(array, 0, array.Length - 1);
        stopwatch.Stop();
        Console.WriteLine("{0} {1}", array.Length, stopwatch.ElapsedMilliseconds);
    }

    private void SortInternal(int[] array, int L,int R)
    {
        if (L >= R) return;
        int X = (L + R) / 2;
        SortInternal(array, L, X);
        SortInternal(array, X + 1, R);
        Merge(array, L, X, R);
    }

    private void Merge(int[] array, int L, int X, int R)
    {
        int[] M = new int[R - L + 1];
        int a = L;
        int b = X + 1;
        int m = 0;
        while (a <= X && b <= R)
            if (array[a] <= array[b])
                M[m++] = array[a++];
            else 
                M[m++] = array[b++];
        while (a <= X)
            M[m++] = array[a++];
        while (b <= R)
            M[m++] = array[b++];
        for (int i = L; i <= R; i++)
            array[i] = M[i - L];
    }
}
