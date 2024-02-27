using DockerDemo.Logic.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace DockerDemo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IWelcomeService _welcomeService;

        public ValuesController(IWelcomeService welcome)
        {
            _welcomeService = welcome;
        }
        /// <summary>
        /// Getting next cycle of the template
        /// </summary>
        /// <param name="templateId">Payroll group Id</param>
        /// <returns></returns>
        [HttpGet("WelcomeMessage/{name}", Name = "WelcomeMessage")]
        public async Task<IActionResult> WelcomeMessage(string name)
        {
            var response = await _welcomeService.GetWelcomeMessage(name);
            return Ok(response);
            //_loggingService.LogInformation($"Getting the template period for template with id {templateId}", "GetTempaltePeriod");
            //var errors = await _payrollService.ValidateFileExport(templateId);
            //if (errors.errors.Count == 0)
            //{
            //    var respose = await _payrollService.GetTemplatePeriod(templateId);
            //    if (respose != null)
            //    {
            //        return 
            //    }
            //    return BadRequestResult(Constant.Message.Error);
            //}
            //return BadRequestResult(Constant.Message.Error, errors);
        }
    }
}
