// 二元數[O(log n)]: 每一層找資料都是從中間資料比對，比對到相同或是找到不能比對為止
public int SearchInsert(int[] nums, int target)
{
	int l = 0;
	int r = nums.Length - 1;
	while (l <= r) 
	{
		int m = (l + r) / 2;
		if (nums[m] == target)
		{
			return m;
		}
		else if (nums[m] > target)
		{
			r = m - 1;
		}
		else 
		{
			l = m + 1;
		}
	}

	return l;
}