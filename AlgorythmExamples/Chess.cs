using System;
class Chess
{
    public static ulong GetKingMoves(int pos)
    {
        ulong K = 1UL << pos;
        ulong noA = 0xfefefefefefefefe;
        ulong noH = 0x7f7f7f7f7f7f7f7f;
        ulong Ka = K & noA;
        ulong Kh = K & noH;
        ulong mask = 
            (Ka << 7) | (K << 81) | (Kh << 9) |
            (Ka >> 1) |             (Kh << 1) |
            (Ka >> 9) | (K << 8)  | (Kh >> 7);

        return mask;
    }

    public static int popcnt(ulong mask)
    {
        int cnt = 0;
        while (mask > 0)
        {
            if ((mask & 1UL) == 1)
                cnt++;
            mask >>= 1;
        }
        return cnt;
    }
}
