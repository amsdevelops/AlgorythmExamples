using System;
using System.Diagnostics;

class QuickSorter : AbstractSwapperSorter, IIntegerSorter
{

    public void Sort(int[] array, Stopwatch stopwatch)
    {
        stopwatch.Start();
        SortInternal(array, 0, array.Length - 1);
        stopwatch.Stop();
        Console.WriteLine("{0} {1}", array.Length, stopwatch.ElapsedMilliseconds);
    }

    private void SortInternal(int[] arr, int L, int R)
    {
        if (L >= R) return;
        int X = Split(arr, L, R);
        SortInternal(arr, L, X - 1);
        SortInternal(arr, X + 1, R);
    }

    private int Split(int[] arr, int L, int R)
    {
        int P = arr[R];
        int a = L - 1;
        for (int i = L; i <= R; i++)
            if (arr[i] <= P)
                Swap(ref arr[++a], ref arr[i]);
        return a;
    }
}

