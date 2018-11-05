using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using AbpCompanyName.AbpProjectName.Entitis.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;


namespace AbpCompanyName.AbpProjectName.Repository
{
    public interface IPersonRepository : IRepository<Person> 
      
    {
        List<Person> Get();
    }
}
