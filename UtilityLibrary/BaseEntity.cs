using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLibrary
{
    public interface IBaseEntity<T> : IModifiedEntity
    {
        T Id { get; set; }
    }

    public abstract class BaseEntity<T> : IBaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }
        public string UserCreatedId { get; set; }
        public string UserUpdatedId { get; set; }
        public string UserDeletedId { get; set; }
    }
}
