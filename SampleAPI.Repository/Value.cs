using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SampleAPI.Data;

namespace SampleAPI.Repository
{
    public class ValueRepo: IValueRepo
    {

        public async Task<double> CalCulater(Operation operation)
        {
            double output = 0;
            switch(operation.OperationType)
            {
                case OperationType.Addition:
                    output = operation.NumberA + operation.NumberB;
                    break;
                case OperationType.Subtraction:
                    output = operation.NumberA - operation.NumberB;
                    break;
                case OperationType.Multiplication:
                    output = operation.NumberA * operation.NumberB;
                    break;
                case OperationType.Division:
                    output = operation.NumberA / operation.NumberB;
                    break;

            }
            return output;
        }


        public async Task<IPtoCountry> GetIpInfo(string ip)
        {
            System.Net.Http.HttpClient httpClient1 = new HttpClient();
            SampleAPI.Infrastructure.HttpClient httpClient = new SampleAPI.Infrastructure.HttpClient(httpClient1);
            var response = await httpClient.GetValues("https://api.ip2country.info/ip?" + ip);
            var result = await response.Content.ReadAsStringAsync();
            var output = JsonConvert.DeserializeObject<IPtoCountry>(result);

            if(output.countryCode == "US")
            {
                output.outPutText = "TEST US";
            }
            return output;
        }
    }
}
