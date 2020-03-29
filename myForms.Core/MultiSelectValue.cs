using System;
using System.Collections.Generic;
using System.Text;

namespace myForms.Core
{
    public class MultiSelectValue
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }
        public MultiSelectField MultiSelectField { get; set; }
        public Guid MultiSelectFieldId { get; set; }
    }
}
