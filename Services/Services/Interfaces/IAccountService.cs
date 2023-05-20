using Services.DTOs.Account;


namespace Services.Services.Interfaces
{
    public interface IAccountService
    {
        Task SignUpAsync(RegisterDto model);
    }
}
