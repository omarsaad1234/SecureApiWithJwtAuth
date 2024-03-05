using SecureApiWithJwtAuth.Models;

namespace SecureApiWithJwtAuth.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
    }
}
