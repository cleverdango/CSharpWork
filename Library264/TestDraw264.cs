using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{
    public class TestDraw264
    {
        public static void DrawAll(List<Shap264>shaps) {
            Shap264 square = new Rectangle264(2, 3, 10, 10);
            shaps.Add(square);
            Shap264 rectangle = new Rectangle264(3, 2, 11, 5);
            shaps.Add(rectangle);
            Shap264 circle = new Ellipse264(2, 3, 10, 3);
            shaps.Add(circle);
            Shap264 ellipse = new Ellipse264(3, 10, 3, 3);
            shaps.Add(ellipse);

        }
        public static void DrawShap()
        {
            List<Shap264> shaps = new List<Shap264>();
           
            DrawAll(shaps);
            foreach (Shap264 a in shaps)
            {
                a.Draw();
            }
        }
    }
}
