using System;
using System.Collections.Generic;
using System.Text;

namespace myForms.Core
{
    public class Form
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public ICollection<FormSection> FormSections { get; set; }
        public ICollection<FormInstance> FormInstances { get; set; }
    }
}
