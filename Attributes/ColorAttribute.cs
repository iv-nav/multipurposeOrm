using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipurposeOrm.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public class ColorAttribute : Attribute
    {
        public ColorAttribute(ConsoleColor color = ConsoleColor.Cyan)
        {
            Color = color;
        }

        public ConsoleColor Color { get; }
    }
}
