using Architecture.CrossCutting;
using Architecture.Domain;
using Architecture.Model;
using DotNetCore.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Architecture.Database
{
    public sealed class UserRepository : EntityFrameworkCoreRelationalRepository<UserEntity>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {
        }

        public Task<SignedInModel> SignInAsync(SignInModel signInModel)
        {
            return SingleOrDefaultAsync<SignedInModel>
            (
                userEntity =>
                userEntity.SignIn.Login == signInModel.Login &&
                userEntity.Status == Status.Active
            );
        }

        public Task UpdateStatusAsync(UserEntity userEntity)
        {
            return UpdatePartialAsync(userEntity.Id, new { userEntity.Status });
        }
    }
}
