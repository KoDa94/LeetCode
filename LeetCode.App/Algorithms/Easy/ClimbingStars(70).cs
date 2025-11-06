public class Solution70Easy
{
    public int ClimbStairs(int n)
    {
        int previousClimb = 1;
        int pastClimb = 0;
        int currentClimb = 0;

        for (int i = 1; i <= n; i++)
        {
            currentClimb = previousClimb + pastClimb;
            pastClimb = previousClimb;
            previousClimb = currentClimb;
        }

        return currentClimb;
    }
}