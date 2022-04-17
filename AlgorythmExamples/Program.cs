using System;

class Program
{
    static void Main(string[] args)
    {
        ulong mask = Chess.GetHorseMoves(39);
        int cnt = Chess.popcnt(mask);
        Console.WriteLine(mask);
        Console.WriteLine(cnt);
        Console.ReadKey();
    }
}
