using System;

namespace MyOSDetection
{
    public class OSDetectionTest
    {
        public static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
            {
                Console.WriteLine("Your OS is Windows");
            }
            else if (OperatingSystem.IsAndroid())
            {
                Console.WriteLine("Your OS is Android");
            }
            else if (OperatingSystem.IsLinux())
            {
                Console.WriteLine("Your OS is Linux");
            }
            else if (OperatingSystem.IsIOS())
            {
                Console.WriteLine("Your OS is iOS");
            }
        }
    }
}