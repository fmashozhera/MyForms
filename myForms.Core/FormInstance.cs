using System;
using System.Collections.Generic;
using System.Text;

namespace myForms.Core
{
    public class FormInstance
    {
        public Guid Id { get; set; }
        public Guid FormId { get; set; }
        public Form Form { get; set; }
        public ICollection<FormSectionInstance> Sections { get; set; }       
    }
}
