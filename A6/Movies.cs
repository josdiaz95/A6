using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace A6
{
    public class Movies : Media
    {

        public string[] genres { get; set; }

        
        public override void Display()
        {
            Console.WriteLine("ID:" +Id+ "\nMovie Title:" + Title + "\nGenres:"+ string.Join("|",genres));
            Console.WriteLine("");
      
        }
      
    }
}
