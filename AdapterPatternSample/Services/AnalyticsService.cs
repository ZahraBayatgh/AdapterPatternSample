using AdapterPatternSample.Interfaces;

namespace AdapterPatternSample.Services;

    public class AnalyticService : IAnalyticService
    {
        public int GenerateIdReport(string json)
        {
            Random random=new Random();

           var id= random.Next(10000, 99999);

           return id;
        }
    }
