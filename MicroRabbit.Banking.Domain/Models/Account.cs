
namespace MicroRabbit.Banking.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Account
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
    }
}
