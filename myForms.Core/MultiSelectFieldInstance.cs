using System;
using System.Collections.Generic;
using System.Text;

namespace myForms.Core
{
    public class MultiSelectFieldInstance : FieldInstance
    {
        public ICollection<MultiSelectValueInstance> Values { get; set; }
    }
}
