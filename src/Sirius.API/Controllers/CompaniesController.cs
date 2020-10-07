using Microsoft.AspNetCore.Mvc;
using Sirius.Domain.Interfaces;

namespace Sirius.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private ICompanyService companyService;

        public CompaniesController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(companyService.GetCompanies());
        }

        //[HttpPost]
        //public IActionResult Create([FromBody] Company company)
        //{
        //    CreateCompanyModel createCompanyModel = new CreateCompanyModel(company.Name
        //        , company.Nickname
        //        , company.CNPJ
        //        , company.Phone
        //        , company.Email);

        //    if (createCompanyModel.Invalid)
        //        return StatusCode(412, createCompanyModel.Notifications);

        //    new Settings(new SenderEmail("Sirius"
        //        , "smtp.gmail.com"
        //        , 587
        //        , "orion.sirius.noreply@gmail.com"
        //        , "4OnrL#TFM4Dz"));

        //    return Created("Companies", companyService.CreateCompany(createCompanyModel));
        //}
    }
}
