using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Library264
{
    public class BigNum264
    {
        private string[] bits = { "分", "角", "元", "拾", "佰", "仟", "万", "拾万", "佰万" };
        private string[] nums = { "零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖" };
        public Color Color
        {
            get
            {
                if (this.Money > 0)
                    return Color.Blue;
                else
                    return Color.Red;
            }
        }
        public decimal Money { get; set; }

        public BigNum264(decimal money)
        {
            this.Money = money;
        }

        private string getDotString(string dotString)
        {
            string zhString = "";
            if (dotString.Length == 0)
            {
                dotString += "00";
            }
            else if (dotString.Length == 1)
            {
                dotString += "0";
            }
   

            for (int i = 0, j = 1; i < 2; i++, j--)
            {
                zhString += nums[dotString[i] - '0'] + bits[j];
            }
            return zhString;
        }

        private string getIntString(string intString)
        {
            string zhString = "";
            for (int i = intString.Length - 1, j = 2; i >= 0; i--, j++)
            {
                zhString = nums[intString[i] - '0'] + bits[j] + zhString;

            }
            return zhString;

        }



        
        public string ToString()
        {
            //小数点取后两位并取绝对值
            decimal roundedMoney = Math.Abs(Math.Round(this.Money, 2));
            
            string[] moneyPart = roundedMoney.ToString().Split('.');
            //没有小数位
            if (moneyPart.Length == 1)
            {
                return this.getIntString(moneyPart[0]) + this.getDotString("");
            }
            
            else
            {
                return this.getIntString(moneyPart[0]) + this.getDotString(moneyPart[1]);
            }
         

        }
    }
}
