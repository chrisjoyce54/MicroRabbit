
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Interfaces;

namespace MicroRabbit.Banking.Application.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MicroRabbit.Banking.Domain.Models;

    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accoutRepository;

        public AccountService(IAccountRepository accoutRepository)
        {
            this.accoutRepository = accoutRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return accoutRepository.GetAccounts();
        }
    }
}
