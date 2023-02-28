using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    public class Videos : Media
    {
       public string format { get; set; }
        public int length { get; set; }
        
        public int[] regions { get; set; }


        public override void Display()
        {
            Console.WriteLine("ID:" + Id +"\nVideo Title:"+ Title + "\nVideo is available on:"+ format + "\nSeconds Long:" + length + "\nRegions:" + string.Join(",", regions));
            Console.WriteLine("");


        }

    }
}
