using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using AbpCompanyName.AbpProjectName.Entitis.Persons;
using AbpCompanyName.AbpProjectName.Persons.Dto;

namespace AbpCompanyName.AbpProjectName.Persons
{
    public class PersonService : ApplicationService, IPersonService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task CreateUser(CreatePersonInput input)
        {
            var per = input.MapTo<Person>();

            per.Name = input.Name;
            per.Address = input.Address;
            per.Age = input.Age;
            per.CreationTime = DateTime.Now;

           _personRepository.InsertAsync(per);
        }

        public void DelPersonByName(string name)
        {
       

            List<Person> task = _personRepository.GetAllList().Where(p => p.Name.Equals(name)).ToList<Person>();

            Person per = new Person();
            if (task.Count > 0)
            {
                per = task[0];
                _personRepository.Delete(per);
            }
            Logger.Info("****************************test*************************************");
        }


        /// <summary>
        /// 根据姓名获取Person实体
        /// </summary>
        /// <param name="name">姓名</param>
        /// <returns>PersonListDto</returns>
        public async Task<PersonListDto> GetPersonByName(string name)
        {
            List<Person> task= _personRepository.GetAllList().Where(p=>p.Name.Equals(name)).ToList<Person>();

            Person per = new Person();
            if(task.Count>0)
            {
                per = task[0];
            }
            return per.MapTo<PersonListDto>();
        }

        /// <summary>
        /// 异步获取Person列表
        /// </summary>
        /// <returns>List-PersonListDto</returns>

        public async Task<ListResultDto<PersonListDto>> GetPersonsAsync()
        {
            var persons = await _personRepository.GetAllListAsync();
            Logger.Info("****************************GetPersonsAsync*************************************");
            return new ListResultDto<PersonListDto>(
                persons.MapTo<List<PersonListDto>>()
                );
        }

      
    }
}
