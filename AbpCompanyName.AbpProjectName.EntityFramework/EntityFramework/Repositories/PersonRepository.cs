using Abp.EntityFramework;
using AbpCompanyName.AbpProjectName.Entitis.Persons;
using AbpCompanyName.AbpProjectName.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.EntityFramework.Repositories
{
    public class PersonRepository : AbpProjectNameRepositoryBase<Person>, IPersonRepository
    {

        protected PersonRepository(IDbContextProvider<AbpProjectNameDbContext> dbContextProvider)
           : base(dbContextProvider)
        {

        }

        List<Person> IPersonRepository.Get()
        {
            var query = GetAll();
            List<Person> list=query.ToList<Person>();
            return list;
        }
    }
}
