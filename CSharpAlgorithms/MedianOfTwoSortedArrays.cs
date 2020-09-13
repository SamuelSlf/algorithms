using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms
{
    /*
     * Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
     * Follow up: The overall run time complexity should be O(log (m+n)).
     * https://www.youtube.com/watch?v=GUb6aILuB8I
     * https://leetcode.com/problems/median-of-two-sorted-arrays/
    */
    public class MedianOfTwoSortedArrays : IMedianOfTwoSortedArrays
    {
        public decimal Execute(int[] nums1, int[] nums2)
        {
            int[] all = new int[nums1.Length + nums2.Length];
            Array.Copy(nums1, all, nums1.Length);
            Array.Copy(nums2, 0, all, nums1.Length, nums2.Length);
            
            // Sort
            Array.Sort(all);

            // odd => me = x(n+1)/2
            if (all.Length % 2 != 0)
            {
                var resultPosition = (all.Length + 1) / 2;

                return all[resultPosition - 1];
            }
            // pair => me = [x(n/2) + x(n/2+1)] / 2
            else
            {
                var result = (decimal)(all[(all.Length / 2) - 1] + all[(all.Length / 2 + 1) - 1]) / 2;

                return result;
            }
        }
    }

    public interface IMedianOfTwoSortedArrays
    {
        decimal Execute(int[] nums1, int[] nums2);
    }
}
