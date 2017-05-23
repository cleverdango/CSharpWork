using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{

    public static class TestFind264
    {
        private static Action<Product264> display;

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


            Console.WriteLine("\r\n1.单价>20的第一个元素");


            Console.WriteLine("\r\n2.单价>20的最后一个元素");


            Console.WriteLine("\r\n3.Name中包\"程序设计\"的所有元素");


            Console.WriteLine("\r\n4.单价在20～25的所有元素");

        }

        public static void FindWithLINQ()
        {
            List<Product264> products = createProducts();

            Console.WriteLine(" ==== 集合中的元素 ====");

            Console.WriteLine("\r\n1.单价>20的第一个元素");


            Console.WriteLine("\r\n2.单价>20的最后一个元素");


            Console.WriteLine("\r\n3.Name中包\"程序设计\"的所有元素");


            Console.WriteLine("\r\n4.单价在20～25的所有元素");
        }
    }
}
