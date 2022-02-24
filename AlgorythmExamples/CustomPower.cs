using System;

class CustomPower
{
    public static double poweredNumber = 0d;
    public static double CustomPowerFunc(double number, int power)
    {
        var result = number;

        for (int i = 0; i < power - 1; i++)
            result *= result;

        return result;
    }
}
