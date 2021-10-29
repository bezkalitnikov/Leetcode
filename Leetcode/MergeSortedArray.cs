public class MergeSortedArray
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var idxInsert = m;
        var idxNums1 = 0;
        var idxNums2 = 0;

        while (idxNums2 < n)
        {
            if (idxNums1 == idxInsert)
            {
                // All nums from nums1 are processed
                // just copy remain from nums2 to nums1
                for (; idxNums2 < n; ++idxNums1, ++idxNums2)
                {
                    nums1[idxNums1] = nums2[idxNums2];
                }
                
                return;
            }

            if (nums1[idxNums1] <= nums2[idxNums2])
            {
                idxNums1++;
            }
            else 
            {
                for (var i = idxInsert++; i > idxNums1; --i)
                {
                    nums1[i] = nums1[i - 1];
                }
                
                nums1[idxNums1++] = nums2[idxNums2++];
            }
        }
    }
}