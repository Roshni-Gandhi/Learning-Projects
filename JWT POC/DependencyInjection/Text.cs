using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Text : Presentation
    {
        public string FontSize { get; set; }
        public string FontName { get; set; }

        public void AddFontStyle(string styleName)
        {
            Console.WriteLine($"{styleName} has been added");
        }

        public override void Copy()
        {
            Console.WriteLine("Text has been copied");
        }

        public override void Duplicate()
        {
            Console.WriteLine("Text has been duplicated");
        }
    }
}
