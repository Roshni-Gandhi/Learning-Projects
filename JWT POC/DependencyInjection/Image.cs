using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Image :Presentation
    {
        public string ImageName { get; set; }
        public string AltText { get; set; }

        public void AddLinkToImage(string link)
        {
            Console.WriteLine($"added {link} to image");
        }

        public override void Copy()
        {
            Console.WriteLine("image has been copied");
        }

        public override void Duplicate()
        {
            Console.WriteLine("image has been duplicated");
        }
    }
}
