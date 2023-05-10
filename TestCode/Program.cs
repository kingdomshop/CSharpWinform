
delegate void myDel();
class Test
{
    public void print1()
    {
        Console.WriteLine(".........print1");
    }
    public static void print2()
    {
        Console.WriteLine(".........print2");
    }
}
class Program
{
    //static void main()
    //{
    //    test test = new test();
    //    mydel md = new mydel(test.print1);
    //    md += test.print2;
    //    int[] arr = { 1, 1, 2 };
    //    int length = removeduplicates(arr);
    //}

    public static int RemoveDuplicates(int[] nums)
    {
        int j = 0;
        int l = nums.Length;
        for(int i=0; i < nums.Length-1; i++)
        {
            if (nums[i] == nums[i+1])
            {
                for (int k=i; k < nums.Length-1-j; k++)
                {
                    nums[k] = nums[k + 1];
                }
                j += 1;
                i -= 1;
            }
        }
        
        return nums.Length-j;
    }


}
