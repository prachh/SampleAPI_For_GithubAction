using System;
using System.Threading.Tasks;
using SampleAPI.Data;

namespace SampleAPI.Repository
{
    public interface IValueRepo
    {
        Task<double> CalCulater(Operation operation);

        Task<IPtoCountry> GetIpInfo(string ip);

    }
}
