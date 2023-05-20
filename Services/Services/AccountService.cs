using Services.DTOs.Account;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class AccountService : IAccountService
    {
        public async Task SignUpAsync(RegisterDto model)
        {
            throw new NotImplementedException();
        }
    }
}
