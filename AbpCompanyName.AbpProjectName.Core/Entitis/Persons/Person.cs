using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.Entitis.Persons
{
    public class Person : FullAuditedEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }
    }
}
