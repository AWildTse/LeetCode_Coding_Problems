public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int arr1Length = nums1.Length, median = 0;

        Array.Resize(ref nums1, nums1.Length + nums2.Length);
        Array.Copy(nums2, 0, nums1, arr1Length, nums2.Length);
        Array.Sort(nums1);
        
        if(nums1.Length % 2 == 0) {
            return ((nums1[nums1.Length/2] + nums1[nums1.Length/2 - 1]) / 2.0);
        }
        else
            return (nums1[nums1.Length/2]);
    }
}

/**
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).
s
Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.
Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
 

Constraints:

nums1.length == m
nums2.length == n
0 <= m <= 1000
0 <= n <= 1000
1 <= m + n <= 2000
-106 <= nums1[i], nums2[i] <= 106
**/
