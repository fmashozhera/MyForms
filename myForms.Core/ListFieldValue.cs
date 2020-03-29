using System;
using System.Collections.Generic;
using System.Text;

namespace myForms.Core
{
    public class ListFieldValue
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        public ListField ListField { get; set; }
        public Guid ListFieldId { get; set; }
    }
}
