
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Transfer.Application.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MicroRabbit.Transfer.Domain.Models;

    public class TransferService : ITransferService
    {
        private readonly ITransferRepository transferRepository;
        private readonly IEventBus bus;

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            this.transferRepository = transferRepository;
            this.bus = bus;
        }
        public IEnumerable<TransferLog> GetTransfers()
        {
            return transferRepository.GetTransfers();
        }
    }
}
