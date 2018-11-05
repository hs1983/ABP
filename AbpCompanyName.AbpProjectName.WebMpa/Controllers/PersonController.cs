using AbpCompanyName.AbpProjectName.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AbpCompanyName.AbpProjectName.WebMpa.Controllers
{
    public class PersonController : AbpProjectNameControllerBase
    {
        private readonly IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<JsonResult> Index()
        {
            var output = await _service.GetPersonsAsync();
            return Json(output, JsonRequestBehavior.AllowGet);
        }
    }
}