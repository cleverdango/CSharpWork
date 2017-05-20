using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Library264
{
    public class Shap264
    {
        protected static int startBH = 100;
        protected int BH { get; set; }
        protected Point OPoint{get;set;}
        virtual public void Draw()
        {
            Console.WriteLine("正在画#" + this.BH + ": ");
        }
        public Shap264()
        {
            

            this.BH = startBH;
            startBH++;

        }
        

    }
}
