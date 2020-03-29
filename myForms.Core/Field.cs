using System;
using System.Collections.Generic;

namespace myForms.Core
{
    public class Field
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DataType DataType { get; set; }
        public int Index { get; set; }
        public Guid FormSectionId { get; set; }
        public virtual FormSection FormSection { get; set; }
        public virtual ICollection<FieldConstraint> FieldConstraints { get; set; }
        public ICollection<FieldInstance> FieldInstances { get; set; }
    }
}
