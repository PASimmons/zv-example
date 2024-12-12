using VemiMicroservice.Domain.Models;
using System.Threading.Tasks;

namespace VemiMicroservice.Application.Interfaces
{
    public interface IExampleServiceClient
    {
        Task<Example> GetExampleById(int id);
    }
}