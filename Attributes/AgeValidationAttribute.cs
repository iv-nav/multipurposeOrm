﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipurposeOrm.Attributes
{
    public class AgeValidationAttribute : Attribute
    {
        public int Age { get; set; }

        public AgeValidationAttribute() { }

        public AgeValidationAttribute(int age)
        {
            Age = age;
        }
    }
}
