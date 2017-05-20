using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{
    public class Ellipse264:Shap264
    {
        private int LongR { get; set; }
        private int ShortR { get; set; }

       public Ellipse264(int x,int y,int LongR,int ShortR)
        {
            OPoint = new System.Drawing.Point(x, y);
            this.LongR = LongR;
            this.ShortR = ShortR;
        }
        public override void Draw()
        {
    
            base.Draw();
            if (LongR == ShortR)
            {
                Console.WriteLine("圆==>中心点：" + "{X=" + OPoint.X + ",Y=" + OPoint.Y + "},长轴：" + LongR + "  短轴：" + ShortR);
            }
            else
            {
                Console.WriteLine("椭圆==>中心点：" + "{X=" + OPoint.X + ",Y=" + OPoint.Y + "},长轴：" + LongR + "  短轴：" + ShortR);
            }
        }
    }
}
