using Architecture.Model;
using System.Threading.Tasks;

namespace Architecture.Application
{
    public interface IUserLogApplicationService
    {
        Task AddAsync(UserLogModel userLogModel);
    }
}
