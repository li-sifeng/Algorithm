using System;
using System.Collections.Generic;

namespace MyTestCode
{
    public static class Program
    {
        public static bool ipv4Validate(string s)
        {
            if (null == s)
            {
                return false;
            }
            string[] ipSecStr = s.Split('.');
            if (ipSecStr.Length != 4)
            {
                return false;   // Case x.x.x.x.x or x.x.x
            }
            for (int i = 0; i < ipSecStr.Length; i++)
            {
                if (0 == i && ipSecStr[i][0] == '0')
                {
                    return false;   // Case 0.x.x.x
                }
                //Console.WriteLine("{0} length is {1}", ipSecStr[i], ipSecStr[i].Length);
                if (ipSecStr[i][0] == '0' && ipSecStr[i].Length > 1)
                {
                    return false;   // Case: x.0x.x.x
                }
                for (int j = 0; j < ipSecStr[i].Length; j++)
                {
                    if (!char.IsDigit(ipSecStr[i][j]))
                    {
                        return false;   // Case: 1AB.x.x.x
                    }
                }
                int ipPart = int.Parse(ipSecStr[i]);
                if (ipPart > 255)
                {
                    return false;   // Case x.258.x.x
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an IPV4 Address");
            string? ipv4 = Console.ReadLine();
            if (ipv4 == null)
            {
                Console.WriteLine("Input is a NULL string!");
                return;
            }
            if (true == ipv4Validate(ipv4))
            {
                Console.WriteLine("{0} is a valid IPV4 Address!", ipv4);
            }
            else
            {
                Console.WriteLine("{0} is an invalid IPV4 Address!", ipv4);
            }
        }
    }
}
