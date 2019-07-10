/// ---------------------------------------------------------------------------
/// <copyright file="IEventBus.cs" company="Jack Henry &amp; Associates, Inc.">
///     Copyright (c) 1999-2019,, Jack Henry &amp; Associates, Inc. All Rights Reserved.
/// </copyright>
/// <author>Jack Henry &amp; Associates, Inc.</author>
/// <date>Created:  7/9/2019 3:38:10 PM</date>
/// <summary>"IEventBus.cs" is part of "MicroRabbit.Domain.Core.Bus".  
/// </summary>
/// ---------------------------------------------------------------------------

namespace MicroRabbit.Domain.Core.Bus
{
	using MicroRabbit.Domain.Core.Commands;
	using MicroRabbit.Domain.Core.Events;
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Threading.Tasks;

	public interface IEventBus
	{
		Task SendCommand<T>(T command) where T : Command;
		void Publish<T>(T @event) where T : Event;
		void Subscribe<T, TH>()
			where T : Event
			where TH : IEventHandler<T>;
	}
}
