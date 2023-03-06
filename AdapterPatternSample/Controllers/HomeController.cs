using AdapterPatternSample.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdapterPatternSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeesService;
        private readonly IAnalyticAdapter _analyticAdapter;

        public HomeController(IEmployeeService employeesService, IAnalyticAdapter analyticAdapter)
        {
            _employeesService = employeesService;
            _analyticAdapter = analyticAdapter;
        }
       
        [HttpGet]
        public IActionResult GenerateId()
        {
            var employees = _employeesService.GetEmployees();

            var result = _analyticAdapter.ProcessEmployees(employees);
            return Ok(result);
        }
    }
}