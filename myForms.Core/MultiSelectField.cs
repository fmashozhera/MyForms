using System.Collections.Generic;

namespace myForms.Core
{
    public class MultiSelectField : Field
    {
        public ICollection<MultiSelectValue> Values { get; set; }
        public bool AllowMultipleValues { get; set; }

    }
}
