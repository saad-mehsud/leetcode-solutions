public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int i = 0;
        int k = nums.Length;
         k=k-1;
        while(true)
        {
            if(k != i && nums[i] + nums[k] == target)
            {

                 return [i,k];
            }
            else if (k == i)
            {
                i = i+1;
                k =  (nums.Length)-1;
            }
            else{
                k--;
            }
        }
    }
}
