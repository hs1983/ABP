using Abp.AutoMapper;
using AbpCompanyName.AbpProjectName.Entitis.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.Persons.Dto
{
    [AutoMap(typeof(Person))]
    public class CreatePersonInput
    {
        [Required]
        [MaxLength(20), MinLength(2)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50), MinLength(2)]
        public string Address { get; set; }

        [Required]
        public int Age { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
