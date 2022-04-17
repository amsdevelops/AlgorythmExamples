using System;
abstract class AbstractSwapperSorter
{
    protected void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
