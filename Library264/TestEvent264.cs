using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{
    public class TestEvent264
    {
        public static void Test()
        {
            //接受方：老师和学生
            Student264 stu1 = new Student264("张三");
            Student264 stu2 = new Student264("李四");
            Teacher264 tch1 = new Teacher264();
            //发送方：课程表
            Schedule264 sch1 = new Schedule264("c++", DayOfWeek.Friday);
            //发送方：发生改变->触发事件 接受方：处理事件
            sch1.ScheduleChanged += stu1.Knowed;
            sch1.ScheduleChanged += stu2.Knowed;
            sch1.ScheduleChanged += tch1.ProcessChange;

          
            sch1.Course = "c#";
            sch1.Day = DayOfWeek.Thursday;

        }


    }
}
