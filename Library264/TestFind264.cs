using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{

    public static class TestFind264
    {
        private static Action<Product264> display =
            (product => Console.WriteLine(product));

        private static List<Product264> createProducts()
        {
            return new List<Product264>()
            {
                new Product264(){Name="C程序设计",Price=20,Quantity=50},
                new Product264(){Name="C#程序设计",Price= 23,Quantity= 30},
                new Product264(){Name="Java程序设计",Price= 21,Quantity= 40},
                new Product264(){Name="软件工程导论",Price= 18,Quantity= 60},
                new Product264(){Name="操作系统原理",Price= 30,Quantity= 20},
                new Product264(){Name="Linux程序设计",Price= 26,Quantity= 70},
            };
        }

        public static void Find()
        {
            List<Product264> list = createProducts();

            Console.WriteLine(" ==== 集合中的元素 ====");
            list.ForEach(display);

            Console.WriteLine("\r\n1.单价>20的第一个元素");
            Console.WriteLine(list.Find(price20));

            Console.WriteLine("\r\n2.单价>20的最后一个元素");
            Console.WriteLine(list.FindLast(price20));

            Console.WriteLine("\r\n3.Name中包\"程序设计\"的所有元素");
            list.FindAll(delegate (Product264 p) {
                return p.Name.Contains("程序设计");
            }).ForEach(display);

            Console.WriteLine("\r\n4.单价在20～25的所有元素");
            list.FindAll(pro => pro.Price >= 20 && pro.Price < 25).ForEach(display);
        }

        public static void FindWithLINQ()
        {
            List<Product264> products = createProducts();
            var query1 = from p in products
                         select p;
            Console.WriteLine(" ==== 集合中的元素 ====");
            query1.ToList().ForEach(display);

            var query2 = (from p in products
                          where p.Price > 20
                          select p).FirstOrDefault();
            Console.WriteLine("\r\n1.单价>20的第一个元素");
            Console.WriteLine(query2);

            var query3 = (from p in products
                          where p.Price > 20
                          select p).LastOrDefault();
            Console.WriteLine("\r\n2.单价>20的最后一个元素");
            Console.WriteLine(query3);

            var query4 = from p in products
                         where p.Name.Contains("程序设计")
                         select p;
            Console.WriteLine("\r\n3.Name中包\"程序设计\"的所有元素");
            query4.ToList().ForEach(display);

            var query5 = from p in products
                         where p.Price >= 20 && p.Price < 25
                         select p;
            Console.WriteLine("\r\n4.单价在20～25的所有元素");
            query5.ToList().ForEach(display);
        }

        private static bool price20(Product264 p)
        {
            return p.Price > 20;
        }
    }
}
