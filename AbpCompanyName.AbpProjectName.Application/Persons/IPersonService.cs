using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpCompanyName.AbpProjectName.Persons.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Web.Http;

namespace AbpCompanyName.AbpProjectName.Persons
{
    public interface IPersonService:IApplicationService 
    {
        /// <summary>
        /// 异步获取Person列表
        /// </summary>
        /// <returns>List-PersonListDto</returns>
        [HttpGet]
        Task<ListResultDto<PersonListDto>> GetPersonsAsync();

        /// <summary>
        /// 根据姓名获取Person实体
        /// </summary>
        /// <param name="name">姓名</param>
        /// <returns>PersonListDto</returns>
        [HttpGet]
        Task<PersonListDto> GetPersonByName(string name);

        /// <summary>
        /// 删除指定Person
        /// </summary>
        /// <param name="name">Person姓名</param>
        [HttpPost]
        void DelPersonByName(string name);

        /// <summary>
        /// 创建Person
        /// </summary>
        /// <param name="input">person实体</param>
        /// <returns></returns>
        [HttpPost]
        Task CreateUser(CreatePersonInput input);

    }
}
