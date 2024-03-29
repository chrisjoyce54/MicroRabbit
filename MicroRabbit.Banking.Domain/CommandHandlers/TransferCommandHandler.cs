﻿
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    using MediatR;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus bus;

        public TransferCommandHandler(IEventBus bus)
        {
            this.bus = bus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            // publish event to RabbitMq
            bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
            return Task.FromResult(true);
        }
    }
}
