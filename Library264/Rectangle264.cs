using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{
    public class Rectangle264:Shap264
    {
        private int Height { get; set; }
        private int Width { get; set; }
        public Rectangle264(int x,int y,int Height,int Width)
        {
            OPoint = new System.Drawing.Point(x, y);
            this.Height = Height;
            this.Width = Width;
        }
        public override void Draw()
        {
            base.Draw();
            if (Height != Width)
            {
                Console.WriteLine("长方形==>中心点：" + "{X=" + OPoint.X + ",Y=" + OPoint.Y + "},宽：" + Width + "  高：" + Height);
            }
            else
            {
                Console.WriteLine("正方形==>顶点：" + "{X=" + OPoint.X + ",Y=" + OPoint.Y + "},边长：" + Height);
            }
            
        }

    }
}
