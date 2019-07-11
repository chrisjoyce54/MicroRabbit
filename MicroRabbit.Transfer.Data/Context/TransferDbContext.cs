
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Context
{
    using MicroRabbit.Transfer.Domain.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
