public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] combined = nums1.Concat(nums2).ToArray();
        Array.Sort(combined);
        int midPoint = combined.Length/2;
        double median =0.0;
        if(combined.Length%2 == 0)
        {
            Console.WriteLine($"MP:{midPoint} Com[mp-1]:{combined[midPoint-1]} Com[mp]:{combined[midPoint]}");
            median = (combined[midPoint-1]+combined[midPoint])/2.0;
        }
        else{
            median = combined[midPoint];
        }
        return median;
    }
}
