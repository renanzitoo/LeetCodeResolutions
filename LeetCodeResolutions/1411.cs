public class Solution1411
{
    private const int MOD = 1_000_000_007;

    public int NumOfWays(int n)
    {
        long dpA = 6; 
        long dpB = 6; 

        for (int i = 2; i <= n; i++)
        {
            long newDpA = (2 * dpA + 2 * dpB) % MOD;
            long newDpB = (2 * dpA + 3 * dpB) % MOD;

            dpA = newDpA;
            dpB = newDpB;
        }

        return (int)((dpA + dpB) % MOD);
    }
}
