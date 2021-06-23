using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public abstract class Presentation
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public abstract void Copy();
        public abstract void Duplicate();
    }
}
