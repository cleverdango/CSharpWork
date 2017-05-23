using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{
   public class Student264:IComparable<Student264>
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public string Source { get; set; }
        public int CompareTo(Student264 other)
        {
            return int.Parse(this.ID) - int.Parse(other.ID);
           
           
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        public Student264() { }
        public Student264(string Name)
        {
            this.Name = Name;
        }
        //定义事件的响应方法
        public void Knowed(object sender,ScheduleChangedEventArgs264 args)
        {
            Schedule264 newsch = (Schedule264)sender;            
            Console.WriteLine("学生{0}已经收到通知：在{1}上{2}课", Name, newsch.Course, newsch.Day);

        }
    }
}
