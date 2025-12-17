const nums: number[] = [2,15,11,7];
const target: number = 9
const twoNums: number[] = twoSum(nums, target);

if (twoNums.length > 0) {
    console.log(`The two indexes that add to ${target} are ${twoNums}.`);
} else {
    console.log("No numbers add to reach the target.")
}

function twoSum(nums: number[], target: number): number[] {
    for (let i = 0; i < nums.length; i++) {
        for (let j = 0; j < nums.length; j++) {
            if (nums[i] != nums[j] && nums[i] + nums[j] == target) {
                return [i, j]
            }    
        }
    }
    return [];
};