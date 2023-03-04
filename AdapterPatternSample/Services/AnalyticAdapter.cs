using AdapterPatternSample.Data;
using AdapterPatternSample.Interfaces;

namespace AdapterPatternSample.Services
{
    public class AnalyticAdapter : IAnalyticAdapter
    {
        private readonly IAnalyticService _analyticService;

        public AnalyticAdapter(IAnalyticService analyticService)
        {
            _analyticService = analyticService;
        }

        public int ProcessEmployees(List<Employee> employees)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(employees);

            var result = _analyticService.GenerateIdReport(json);
            return result;
        }
    }
}
