
namespace MicroRabbit.Transfer.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TransferLog
    {
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal Amount { get; set; }
    }
}
