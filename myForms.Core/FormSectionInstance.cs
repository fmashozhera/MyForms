using System;
using System.Collections.Generic;
using System.Text;

namespace myForms.Core
{
    public class FormSectionInstance
    {
        public Guid Id { get; set; }
        public Guid FormInstanceId { get; set; }
        public FormInstance FormInstance { get; set; }
        public Guid FormSectionId { get; set; }
        public FormSection FormSection { get; set; }
        public ICollection<FieldInstance> Fields { get; set; }
    }
}
