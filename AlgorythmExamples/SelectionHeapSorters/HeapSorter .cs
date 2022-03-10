using System;
using System.Diagnostics;

class HeapSorter : AbstractSwapperSorter, IIntegerSorter 
{
    public void Sort(int[] array, Stopwatch stopwatch)
    {
        stopwatch.Start();
        for (int root = array.Length / 2 - 1; root >= 0; root--)
            MoveMaxToRoot(array, root, array.Length);
        for (int i = array.Length - 1; i > 0; i--)
        {
            Swap(ref array[0], ref array[i]);
            MoveMaxToRoot(array, 0, i);
        }
        Console.WriteLine("{0} {1}", array.Length, stopwatch.ElapsedMilliseconds);
        stopwatch.Stop();

    }

    private void MoveMaxToRoot(int[] array, int root, int size)
    {
        int l = 2 * root + 1;
        int r = 2 * root + 2;
        int x = root;

        if (l < size && array[l] > array[x]) x = l;
        if (r < size && array[r] > array[x]) x = r;
        if (x == root) return;

        Swap(ref array[x], ref array[root]);
        MoveMaxToRoot(array, x, size);
    }
}

