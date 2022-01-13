using System;

namespace LinqTest
{
    public class User
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserPhone { get; set; }
    }

    public class Order
    {
        public string? Id { get; set; }
        public string? UserId { get; set; }
        public string? OrderCode { get; set; }
    }

    public class MyLinqTest
    {
        static void SelectTest()
        {
            var nums = new int[] {56,97,98,57,74,86,31,90};
            var queryInfo = from num in nums select num;//num为数据中的每个元素（相当于foreach中迭代变量）
            var numStr = string.Empty;
            foreach (var item in queryInfo) 
            {
                numStr += item + " ";
            }
            Console.WriteLine($"所有分数汇总：{numStr}");
            Console.WriteLine($"最高分：{queryInfo.Max()}");
            Console.WriteLine($"最低分：{queryInfo.Min()}");
            Console.WriteLine($"平均分：{queryInfo.Average()}");
        }
        static void FromTest()
        {
            var arraySet = new List<string>() {"my favorite hobby"," is "," painting and coding"};
            var queryInfo = from str in arraySet from item in str select item;//先从arraySet中获取每个分号内的字符串，再分别从字符串中获取每个字符
            var exeCount = 0;
            var res = string.Empty;
            foreach (var item in queryInfo)// 开始执行查询语句
            {
                res += item;
                exeCount++;
            }
            Console.WriteLine($"执行次数为:{exeCount}, 执行结果为：{res}");
        }
        static void WhereTest()
        {
            var user1 = new User() {UserId = "1", UserName = "张三", UserPhone = "1234567997"};
            var user2 = new User() {UserId = "2", UserName = "李四", UserPhone = "18335789789"};
            var users = new List<User>() { user1, user2 };

            var whereQuery = from user in users where user.UserId == "1" select user;
            foreach (var item in whereQuery)
            {
                Console.WriteLine($"id = 1 的用户姓名为：{item.UserName},手机号为：{item.UserPhone}");
            }
        }
        static void OrderByTest()
        {
            var scores = new int[] { 56,97,98,57,74,86,31,90};
            //var orderQuery = from score in scores orderby score select score;//升序
            var orderQuery = from score in scores orderby score descending select score;//降序
            var sortScoreStr = string.Empty;
            foreach (var item in orderQuery)
            {
            sortScoreStr += item + " ";
            }
            Console.WriteLine($"排序后的分数列表为：{sortScoreStr}");
        }
        static void GroupByTest()
        {
            var numbers = new int[]{1,2,3,4,5,6,7,8,9};
            var numQuery = from num in numbers group num by (num%3);
            foreach (var numKey in numQuery)
            {
                var str = string.Empty;
                switch (numKey.Key)
                {
                    case 0: str = $"整除3余数为0的元素有：{str}"; break;
                    case 1: str = $"整除3余数为1的元素有：{str}"; break;
                    case 2: str = $"整除3余数为2的元素有：{str}"; break;
                }
                foreach (var item in numKey)
                {
                    str += item + " ";
                }
                Console.WriteLine(str);
            }
        }
        static void JoinTest()
        {
            var user1 = new User() {UserId = "1", UserName = "张三", UserPhone = "1234567997"};
            var user2 = new User() {UserId = "2", UserName = "李四", UserPhone = "18335789789"};
            var users = new List<User>() {user1, user2};
            var order1 = new Order {Id = "1", UserId = "1", OrderCode = "orderCode001"};
            var order2 = new Order {Id = "2", UserId = "1", OrderCode = "orderCode002"};
            var order3 = new Order {Id = "3", UserId = "2", OrderCode = "orderCode023"};
            var orders = new List<Order>{order1, order2, order3};
            var joinQuery = from user in users
            join order in orders on user.UserId equals order.UserId
            select new
            {
                userId = user.UserId,
                userName = user.UserName,
                userPhone = user.UserPhone,
                orderCode = order.OrderCode,
            };
            foreach (var item in joinQuery)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Select Test Start");
            SelectTest();
            Console.WriteLine("Select Test End\n");

            Console.WriteLine("From Test Start");
            FromTest();
            Console.WriteLine("From Test End\n");

            Console.WriteLine("Where Test Start");
            WhereTest();
            Console.WriteLine("Where Test End\n");

            Console.WriteLine("OrderBy Test Start");
            OrderByTest();
            Console.WriteLine("OrderBy Test End\n");

            Console.WriteLine("GroupBy Test Start");
            GroupByTest();
            Console.WriteLine("GroupBy Test End\n");

            Console.WriteLine("Join Test Start");
            JoinTest();
            Console.WriteLine("Join Test End\n");
        }
    }
}