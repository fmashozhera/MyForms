using System;
using System.Collections.Generic;
using System.Text;

namespace myForms.Core
{
    public class ListFieldValueInstance
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        public Guid FieldInstanceId { get; set; }
        public ListFieldInstance FieldInstance { get; set; }
    }
}
