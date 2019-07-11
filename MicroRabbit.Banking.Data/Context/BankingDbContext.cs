
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Context
{
    using MicroRabbit.Banking.Domain.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
