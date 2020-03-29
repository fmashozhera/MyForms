using System;
using System.Collections.Generic;
using System.Text;

namespace myForms.Core
{
    public class FormSection
    {
        public Guid Id { get; set; }        
        public string Name { get; set; }        
        public Form Form { get; set; }  
        public int Index { get; set; }
        public Guid FormId { get; set; }
        public ICollection<Field> Fields { get; set; }
        public ICollection<FormSectionInstance> FormSectionInstances { get; set; }
    }
}
