using System.Collections.Generic;

namespace MyForms.Domain;

public class ComplexForm : FormTemplate
{
    public ICollection<SubForm> SubForms { set; get; }
}
