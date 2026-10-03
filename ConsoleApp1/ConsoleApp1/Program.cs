Console.WriteLine("Hello, World!");
//int N = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[]
{
  2,6,5,4
};

int p1 = 0;
int p2 = nums.Length - 1;

while (p1 < p2)
{
  int temp = nums[p1];
  nums[p1] = nums[p2];
  nums[p2] = temp;
  p1++;
  p2--;
}
foreach (var item in nums)
{
  Console.Write($"{item} ");
}

//bool let = (nums.IsFixedSize).IsReadOnly;