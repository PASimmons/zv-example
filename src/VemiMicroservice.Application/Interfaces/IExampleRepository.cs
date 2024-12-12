using System.Threading.Tasks;

namespace VemiMicroservice.Application.Interfaces
{
    public interface IExampleRepository
    {
        Task<int> UpdateExampleNameById(int id, string name);
    }
}