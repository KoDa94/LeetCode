public class Solution69Easy
{
    public int MySqrt(int x)
    {
        if (x == 0)
        {
            return 0;
        }

        int lowAprox = 1;
        int highAprox = x;

        while (lowAprox <= highAprox)
        {
            long mid = lowAprox + (highAprox - lowAprox) / 2;

            if (mid * mid == x)
            {
                return (int)mid;
            }

            if (mid * mid > x)
            {
                highAprox = (int)mid - 1;
            }

            else
            {
                lowAprox = (int)mid + 1;
            }
        }

        return lowAprox - 1;
    }
}