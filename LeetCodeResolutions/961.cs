public class Solution961 {
    public int RepeatedNTimes(int[] nums) {
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in nums){
            if(!seen.Add(num)) {
                return num;
            }
        }
        return 0;
    }
}