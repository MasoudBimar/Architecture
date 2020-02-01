using DotNetCore.Repositories;
using Architecture.Domain;

namespace Architecture.Database
{
    public interface IUserLogRepository : IRelationalRepository<UserLogEntity> { }
}
