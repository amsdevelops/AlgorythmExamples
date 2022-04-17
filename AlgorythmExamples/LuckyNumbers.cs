using System;
class LuckyNumbers
{
    static int sum = 0;

    private static void CountInCycles()
    {
        for (int a1 = 0; a1 < 10; a1++)
            for (int a2 = 0; a2 < 10; a2++)
                for (int a3 = 0; a3 < 10; a3++)
                {
                    int s123 = a1 + a2 + a3;
                    for (int b1 = 0; b1 < 10; b1++)
                        for (int b2 = 0; b2 < 10; b2++)
                        {
                            int b3 = s123 - (b1 + b2);
                            if (b3 >= 0 && b3 <= 9) ++sum;
                        }
                }
    }

    private static void CountInRecursion(int N, int sumA, int sumB)
    {
        if (N == 0)
        {
            if (sumA == sumB) ++sum;
            return;
        }

        for (int a = 0; a < 10; ++a)
            for (int b = 0; b < 10; ++b)
                CountInRecursion(N - 1, sumA + a, sumB + b);

    }
}

