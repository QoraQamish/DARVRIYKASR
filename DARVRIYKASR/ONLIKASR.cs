using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DARVRIYKASR
{
    public class ONLIDK: DAVRKASR
    {
        public override void Kasr(string value)
        {
            string[] mas = value.Split(',', '(', ')');
            if(mas.Length==4 &&  mas[1].Length==0)
            {
                Console.WriteLine("Oddiy davriy kasr");
                int a = int.Parse(mas[0] + mas[2]);
                int b = int.Parse(mas[0]);
                value = (a-b)+"/"+ Toq(mas[2]);
            }
            base.Kasr(value);   
        }
        private string Toq(string mas)
        {
            string g = "";
            for (int i = 0; i < mas.Length; i++)
            {
                g += "9";
            }
            return g;
        }
    }
}
