using MyForms.Domain;
using System.Threading.Tasks;

namespace MyForms.Data.Interfaces;

public interface IUnitOfWork
{
    public IRepository<ComplexForm> ComplexForms { get;  }
    public IRepository<DateRangeConstraint> DateRangeConstraints { get;  }
    public IRepository<Field> Fields { get;  }
    public IRepository<FieldNumericConstraint> FieldNumericConstraints { get;  }
    public IRepository<FormTemplate> Forms { get;  }
    public IRepository<FormSection> FormSections { get;  }
    public IRepository<ListField> ListFields { get;  }
    public IRepository<ListFieldValue> ListFieldValues { get;  }
    public IRepository<MultiSelectField> MultiSelectFields { get;  }
    public IRepository<SimpleField> SimpleFields { get;  }
    public IRepository<StringRegularExpressionConstraint> StringRegularExpressionConstraints { get;  }
    public IRepository<FormInstance> FormInstances { get;  }
    public IRepository<FormSectionInstance> FormSectionInstances { get;  }
    public IRepository<FieldInstance> FieldInstances { get;  }
    public IRepository<ListFieldInstance> ListFieldInstances { get;  }
    public IRepository<ListFieldValueInstance> ListFieldValueInstances { get;  }
    public IRepository<SimpleFieldInstance> SimpleFieldInstances { get;  }
    public IRepository<MultiSelectFieldInstance> MultiSelectFieldInstances { get;  }
    public IRepository<MultiSelectValueInstance> MultiSelectValueInstances { get;  }
    Task<int> Complete();
}
