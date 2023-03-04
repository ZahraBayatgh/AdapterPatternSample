using AdapterPatternSample.Data;

namespace AdapterPatternSample.Interfaces
{
    public interface IAnalyticAdapter
    {
        int ProcessEmployees(List<Employee> employees);

    }
}
