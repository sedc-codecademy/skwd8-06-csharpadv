using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
    }
}
