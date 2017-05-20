using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{
    public class Schedule264
    {
        private string course;
        private DayOfWeek day;

        public Schedule264(string course,DayOfWeek day)
        {
            this.course = course;
            this.day = day;
        }
        public Schedule264()
        {
        }
        public string Course {
            get { return course; }
            set
            {
                if (course != value)
                {
                    course = value;
                    OnScheduleChanged(new ScheduleChangedEventArgs264(value));
                    
                }
            }
        }

        public DayOfWeek Day
        {
            get { return day; }
            set
            {
                if (day != value)
                {
                    day = value;
                    OnScheduleChanged(new ScheduleChangedEventArgs264(value));
                    
                }
            }
        }
        //用事件委托定义事件
        public event EventHandler<ScheduleChangedEventArgs264> ScheduleChanged;
        //通知订阅者
        protected void OnScheduleChanged(ScheduleChangedEventArgs264 args) {
            //当事件存在时，触发该事件
            if (ScheduleChanged != null)
            {
                ScheduleChanged(this, args);

            }
            
        }
   
        
    }
}
