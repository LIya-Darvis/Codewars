public class Kata
{
  public static bool Narcissistic(int val)
  {
    string strVal = val.ToString();
    int len = strVal.Length;
    char[] nums = new char[len];
    int[] nums2 = new int[len];
    int sum = 0;
            
    for (int i = 0; i < len; i++)
    {
      nums[i] = strVal[i];
      int num_n = 1;
      for (int j = 0; j < len; j++)
      {
        int bar = nums[i] - '0';
        num_n = bar * num_n;
        nums2[i] = num_n;
      }
    sum += nums2[i];
    }

    if (val == sum)
      return true;
    else
      return false;
  }
}