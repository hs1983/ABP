using Abp.Application.Services.Dto;
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
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto: EntityDto<long>
    {

        public string Name { get; set; }


        public string Address { get; set; }


        public int Age { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
