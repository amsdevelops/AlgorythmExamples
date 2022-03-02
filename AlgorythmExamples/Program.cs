using System;

class Program
{
    static void Main(string[] args)
    {
        ulong mask = Chess.GetKingMoves(40);
        int cnt = Chess.popcnt(mask);
        Console.WriteLine(mask);
        Console.WriteLine(cnt);
        Console.ReadKey();
    }
}
