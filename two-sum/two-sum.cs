public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> ls = new List<int>();
        int[] results = new int[2];
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(ls.Contains(target - nums[i]))
            {
                results[0] = ls.IndexOf(target - nums[i]);
                results[1] = i;
                
                break;
            }
            else 
                ls.Add(nums[i]);
        }
        return  results;
 }
}