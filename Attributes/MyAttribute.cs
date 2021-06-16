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
        public string Field { get; set; }
        public MyAttr(string field)
        {
            Field = field;
        }

        protected bool IsAuthorized(object actionContext)
        {
            // do any stuff here
            // it will be invoked when the decorated method is called
            return true;
        }
    }
}
