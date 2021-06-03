using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DARVRIYKASR
{
    class AralashDK: ONLIDK
    {
        public override void Kasr(string value)
        {
            string[] mas = value.Split(',','(',')');
            if(mas.Length==4 && mas[0].Length>0 && mas[1].Length>0 && mas[2].Length>0)
            {
                Console.WriteLine("Aralash davriy kasr");
                int a = int.Parse(mas[0]+mas[1]+mas[2]);
                int b =  int.Parse(mas[0]+mas[1]);
                value = (a - b) + "/" + ToqNoll(mas[1],mas[2]);
            }
            base.Kasr(value); 
        } 
        private string ToqNoll(string mas1,string mas2)
        {
            string g = "";
            for (int i = 0; i < mas2.Length; i++)
            {
                g += "9";
            }
            for (int i = 0; i < mas1.Length; i++)
            {
                g += "0";
            }
            
            return g;
        }
    }
}
