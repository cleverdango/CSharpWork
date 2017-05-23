using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{
    public static class TestSort264
    {
        static Action<Student264> displayAll = (stu => Console.WriteLine("ID={0}\t{1}\t{2}\t{3}\r\n", stu.ID, stu.Name, stu.Score, stu.Source));
        static Action<Student264> displayName = (stu => Console.WriteLine("ID={0}\t{1}\r\n", stu.ID, stu.Name));
        static Action<Student264> displayScore = (stu => Console.WriteLine("ID={0}\t{1}\t{2}\r\n", stu.ID, stu.Name, stu.Score));
        static Action<Student264> displaySource = (stu => Console.WriteLine("ID={0}\t{1}\t{2}\r\n", stu.ID, stu.Name, stu.Source));


        private static List<Student264> buildStudents()
        {
            return new List<Student264>()
            {
                new Student264(){ ID="101", Name = "林平", Score=420, Source="三明" },
                new Student264(){ ID="103", Name = "张中来", Score=365, Source="厦门" },
                new Student264(){ ID="106", Name = "王一新", Score=407, Source="三明" },
                new Student264(){ ID="108", Name = "刘莉莉", Score=392, Source="厦门" },
            };
        }

        public static void Sort()
        {
            List<Student264> students = buildStudents();

            Console.WriteLine("1.按学号排序(使用默认比较方法)");
            students.Sort();//自动调用CompareTo

            Console.WriteLine("\r\n2.按姓名排序(使用委托对象)");
            //Comparison<Student264> byName = sortByName;
            students.Sort(sortByName);
            students.ForEach(displayName);

            Console.WriteLine("\r\n3.按成绩排序(使用匿名方法)");
            students.Sort(delegate (Student264 s1, Student264 s2)
            {
                return String.Compare(s1.Score.ToString(), s2.Score.ToString());
            });
            students.ForEach(displayScore);

            Console.WriteLine("\r\n4.按生源地排序(Lambda表达式)");
            students.Sort((s1, s2) => String.Compare(s1.Source, s2.Source));
            students.ForEach(displaySource);

        }

        private static int sortByName(Student264 s1, Student264 s2)
        {
            return String.Compare(s1.Name, s2.Name);
        }

        public static void SortWithLINQ()
        {
            List<Student264> students = buildStudents();
            var r1 =
            from stu in students
            orderby stu.Score
            select stu;
            Console.WriteLine("1.按学号排序");
            r1.ToList().ForEach(displayName);

            var r2 =
                from stu in students
                orderby stu.Name
                select stu;
            Console.WriteLine("\r\n2.按姓名排序");
            r2.ToList().ForEach(displayName);


            var r3 =
                from stu in students
                orderby stu.Score
                select stu;
            Console.WriteLine("\r\n3.按成绩排序");
            r3.ToList().ForEach(displayScore);

            var r4 =
                from stu in students
                orderby stu.Source
                select stu;
            Console.WriteLine("\r\n4.按生源地排序");
            r4.ToList().ForEach(displaySource);

        }


    }
}
