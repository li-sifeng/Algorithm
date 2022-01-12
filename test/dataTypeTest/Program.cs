using System;

namespace DataTypeTest
{
    public class MyDataTypeTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"[int] Type valid range is {int.MinValue} ~ {int.MaxValue}");
            Console.WriteLine($"[long] Type valid range is {long.MinValue} ~ {long.MaxValue}");
            Console.WriteLine($"[float] Type valid range is {float.MinValue} ~ {float.MaxValue}");
            Console.WriteLine($"[double] Type valid range is {double.MinValue} ~ {double.MaxValue}");
            Console.WriteLine($"[decimal] Type valid range is {decimal.MinValue} ~ {decimal.MaxValue}");
        }
    }
}