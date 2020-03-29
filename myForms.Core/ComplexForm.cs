using System.Collections.Generic;

namespace myForms.Core
{
    public class ComplexForm : Form
    {
        public ICollection<SubForm> SubForms { set; get; }
    }
}
