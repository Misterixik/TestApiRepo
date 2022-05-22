using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal interface IEntity
    {
        Guid Id { get; set; }

    }

    internal interface IEntity<T>
    {
        int Id { get; set; }
    }

    
}
