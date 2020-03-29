using System;
using System.Collections.Generic;

namespace myForms.Core
{
    public class ListField : Field
    {
        public ICollection<ListFieldValue> Values { get; set; }
    }
}
