using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipurposeOrm.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class MyAttr : Attribute
    {
        public object Value { get; private set; }

        public MyAttr(object value)
        {
            Value = value;
        }
    }
}
