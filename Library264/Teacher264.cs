using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{
    public class Teacher264
    {//定义事件的响应方法
        public  Teacher264() { }
        public void ProcessChange(object sender,ScheduleChangedEventArgs264 args)
        {
            Schedule264 newsch = (Schedule264)sender;
            
            Console.WriteLine("老师已经准备好在{0} 上{1}", newsch.Day, newsch.Course);
        }
    }
}
