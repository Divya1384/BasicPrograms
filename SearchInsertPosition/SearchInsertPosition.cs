namespace SearchInsertPosition
{
    public class SearchInsertPosition
    {
        /*
         * Given a sorted array arr[] consisting of N distinct integers and an integer K, the task is to find the index of K,
         * if it’s present in the array arr[]. Otherwise, find the index where K must be inserted to keep the array sorted.
         */

        public int SearchInsert(int[] nums, int target)
        {
            int min = 0, max = nums.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (target > nums[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return max + 1;
        }
    }
}
