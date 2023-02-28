using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6
{
    public class Shows : Media
    {
        public int season { get; set; }
        public int episode { get; set; }
        
        public string[] writers { get; set; }

        public override void Display()
        {
            Console.WriteLine("ID:" + Id + "\nShow Title:" + Title + "\nSeason:" + season + "\nEpisode:" + episode + "\nWriters:" + string.Join("|", writers));
            Console.WriteLine("");
           
        }
    }
}
