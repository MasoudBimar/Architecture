using DotNetCore.EntityFrameworkCore;
using Architecture.Domain;

namespace Architecture.Database
{
    public sealed class UserLogRepository : EntityFrameworkCoreRelationalRepository<UserLogEntity>, IUserLogRepository
    {
        public UserLogRepository(Context context) : base(context)
        {
        }
    }
}
