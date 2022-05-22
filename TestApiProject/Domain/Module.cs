using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using NPOI.SS.Formula.Functions;

namespace Domain
{
    public class Module : IEntity<T>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       
    }
}
