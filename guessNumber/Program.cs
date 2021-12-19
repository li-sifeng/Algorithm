using System;
using System.Collections.Generic;

namespace GuessNumber
{
    public static class MyTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("猜数字游戏，请输入猜数字的上限：");
            int maxNum = 0;
            try {
                maxNum = Convert.ToInt32(Console.ReadLine());
                if (maxNum <= 1)
                {
                    Console.WriteLine("错误的数字上限");
                    return ;
                }
            }
            catch (FormatException) {
                Console.WriteLine("输入数字有误，游戏结束");
                return ;
            }
            Random random = new Random();
            int target = random.Next(1, maxNum);
            //Console.WriteLine("random={0}", target);
            //Console.WriteLine("This is a guess number game");
            int num = 0;
            int cnt = 0;
            do
            {
                cnt++;
                //Console.WriteLine("Please input a Number: ");
                Console.WriteLine("请输入一个数字: ");
                try {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) {
                    Console.WriteLine("输入数字有误，游戏结束");
                    return ;
                }
                if (num > target)
                {
                    //Console.WriteLine("Too Big!");
                    Console.WriteLine("太大了!");
                }
                else if (num < target)
                {
                    //Console.WriteLine("Too Small!");
                    Console.WriteLine("太小了!");
                }
                else
                {
                    //Console.WriteLine("Yes! The target is {0}! You total tried {1} times!", target, cnt);
                    Console.WriteLine("恭喜你，答对了! 答案就是{0}! 你一共猜了{1}次!", target, cnt);
                    break;
                }
            } while (num != target);
        }
    }
}