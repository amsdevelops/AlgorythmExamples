using System;
using System.Diagnostics;

class SelectionSorter : AbstractSwapperSorter, IIntegerSorter 
{
    public void Sort(int[] array, Stopwatch stopwatch)
    {
        stopwatch.Start();
        MoveMaxToRoot(array, 0, array.Length);
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
        for (int i = root + 1; i < size; i++)
            if (array[root] < array[i]) 
                Swap(ref array[root], ref array[i]);
    }
}

