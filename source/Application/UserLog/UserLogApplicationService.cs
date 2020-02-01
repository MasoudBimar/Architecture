using Architecture.Database;
using Architecture.Domain;
using Architecture.Model;
using System.Threading.Tasks;

namespace Architecture.Application
{
    public sealed class UserLogApplicationService : IUserLogApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserLogRepository _userLogRepository;

        public UserLogApplicationService
        (
            IUnitOfWork unitOfWork,
            IUserLogRepository userLogRepository
        )
        {
            _unitOfWork = unitOfWork;
            _userLogRepository = userLogRepository;
        }

        public async Task AddAsync(UserLogModel userLogModel)
        {
            var userLogEntity = UserLogFactory.Create(userLogModel);

            await _userLogRepository.AddAsync(userLogEntity);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
