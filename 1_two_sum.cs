// Given an array of integers, return indices of the two numbers such that they add up to a specific target.

// First approach -> O(n2) (368ms)
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int currentNum = -1;
        foreach(int num in nums) {
            currentNum++;
            int sum = num;
            for(int i = currentNum+1; i < nums.Length; i++) {
                if (sum + nums[i] == target) {
                    return new int[]{currentNum,i};
                }
            }
        }
        return new int[]{0,0};
    }
}

// Using hash dictionary -> O(n) (320ms)
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashMap = new Dictionary<int, int>();
        int index = -1;
        foreach(int num in nums) {
            index++;
            int complement = target - num;
            if (index > 0 && hashMap.ContainsKey(complement)) {
                return new int[]{index, hashMap[num]};
            }
            hashMap[num] = index;
        }
    }
}