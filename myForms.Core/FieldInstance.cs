using System;
using System.Collections.Generic;
using System.Text;

namespace myForms.Core
{
    public class FieldInstance
    {
        public Guid Id { get; set; }
        public FormSectionInstance FormSectionInstance { get; set; }
        public Guid FormSectionInstanceId { get; set; }
        public Guid FieldId { get; set; }
        public Field Field { get; set; }
    }
}
