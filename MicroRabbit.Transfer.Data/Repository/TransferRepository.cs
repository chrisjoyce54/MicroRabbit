
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MicroRabbit.Transfer.Domain.Models;

    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            this.ctx = ctx;
        }
        public IEnumerable<TransferLog> GetTransfers()
        {
            return ctx.TransferLogs;
        }
        public int Add(TransferLog transferLog)
        {
            ctx.TransferLogs.Add(transferLog);
            return ctx.SaveChanges();
        }
    }
}
