
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;

namespace MicroRabbit.Banking.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MicroRabbit.Banking.Domain.Models;

    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            this.ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return ctx.Accounts;
        }
    }
}
