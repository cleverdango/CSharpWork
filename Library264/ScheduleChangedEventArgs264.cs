using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{
    public class ScheduleChangedEventArgs264:EventArgs
    {
        public ScheduleChangedEventArgs264() { }
        public ScheduleChangedEventArgs264(string Course)
        {
            this.Course = Course;
        }
        public ScheduleChangedEventArgs264 (DayOfWeek Day)
        {
            this.Day = Day;
        }
        //public ScheduleChangedEventArgs264(string Cou)
        public string Course { get; set; }
        public DayOfWeek Day { get; set; }
    }
}
