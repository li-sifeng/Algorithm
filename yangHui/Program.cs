using System;

namespace Yanghui
{
    public class yanghui
    {
        static void Main(string[] arg)
        {
            int n = 0;
            while (0 == n){
                try {
                    Console.WriteLine("Please input line num of YangHui-Triagle:");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) {
                    Console.WriteLine("Invalid number, try again!");
                }
            }
            Console.WriteLine("Total {0} line!", n);
            int[] nums = new int[n];
            nums[0] = 1;
            for (int i=1; i<=n; i++)
            {
                for (int j=n-i; j>0; j--)
                {
                    Console.Write("  ");
                }
                for (int j=i-1; j>0; j--)
                {
                    nums[j] += nums[j-1];
                    Console.Write("{0}  ", nums[j]);
                }
                Console.WriteLine("1");
            }
        }
    }
}