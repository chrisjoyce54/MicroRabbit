/// ---------------------------------------------------------------------------
/// <copyright file="IEventHandler.cs" company="Jack Henry &amp; Associates, Inc.">
///     Copyright (c) 1999-2019,, Jack Henry &amp; Associates, Inc. All Rights Reserved.
/// </copyright>
/// <author>Jack Henry &amp; Associates, Inc.</author>
/// <date>Created:  7/9/2019 3:41:55 PM</date>
/// <summary>"IEventHandler.cs" is part of "MicroRabbit.Domain.Core.Bus".  
/// </summary>
/// ---------------------------------------------------------------------------

namespace MicroRabbit.Domain.Core.Bus
{
	using MicroRabbit.Domain.Core.Events;
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Threading.Tasks;

	public interface IEventHandler<in TEvent> : IEventHandler
		where TEvent : Event
	{
		Task Handle(TEvent @event);
	}

	public interface IEventHandler
	{
	}

}
