using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLibrary
{
    public interface IModifiedEntity
    {
        DateTime Created { get; set; }
        DateTime? Updated { get; set; }
        DateTime? Deleted { get; set; }
        string UserCreated { get; set; }
        string UserUpdated { get; set; }
        string UserDeleted { get; set; }
    }
}
