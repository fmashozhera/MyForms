using System;
using System.Collections.Generic;
using System.Text;

namespace myForms.Core
{
    public class ListFieldInstance : FieldInstance
    {
        public ICollection<ListFieldValueInstance> Values { get; set; }
    }
}
