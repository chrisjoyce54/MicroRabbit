
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MicroRabbit.Banking.Application.Models;
    using MicroRabbit.Banking.Domain.Models;

    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accoutRepository;
        private readonly IEventBus bus;

        public AccountService(IAccountRepository accoutRepository, IEventBus bus)
        {
            this.accoutRepository = accoutRepository;
            this.bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return accoutRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.Amount
            );
            bus.SendCommand(createTransferCommand);
        }
    }
}
