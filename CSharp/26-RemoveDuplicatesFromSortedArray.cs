// int[] 是參考型別，因為物件由外面傳入，所以 nums 需要按照陣列去修改值
// 如果直接替換掉，外面那層的參數不會被修改到，斷言會失敗
int RemoveDuplicates(int[] nums)
{
	var distinctArray = nums.Distinct();
	
	int i = 0;
	foreach (int item in distinctArray) 
	{
		nums[i] = item;
		i++;
	}

	return distinctArray.Count();
}