using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library264;
namespace ConsoleApp1
{
    class Program
    {

       
        static void Main(string[] args)
        {
            
            Console.WriteLine("=========211406264：成雯珺=========\n");
            Console.WriteLine("1--------实验12 继承与多态");
            Console.WriteLine("2--------实验13 集合排序的多种实现");
            Console.WriteLine("3--------实验13 用LINQ排序");
            Console.WriteLine("4--------实验13 集合查找");
            Console.WriteLine("5--------实验13 用扩展方法和LINQ查找");
            Console.WriteLine("6--------实验14 c#事件");
            Console.WriteLine("0--------退出\n");
            Console.WriteLine("========================================");
            Console.Write("请输入您的选择：");
            string readkey = Console.ReadLine();
            switch (readkey[0])
            {
                case '1':
                    TestDraw264.DrawShap();
                    break;
                case '2':
                    TestSort264.Sort();
                    break;
                case '3':
                    TestSort264.SortWithLINQ();
                    break;
                case '4':
                    TestFind264.Find();
                    break;
                case '5':
                    TestFind264.FindWithLINQ();
                    break;
                case '6':
                    TestEvent264.Test();
                    break;
                case '0': break;
            }

            //Console.WriteLine("您已选择" + readkey[0]);
            Console.ReadLine();
        }
        static void Main1(string[] args)
        {
           
            
        }

    }
}
