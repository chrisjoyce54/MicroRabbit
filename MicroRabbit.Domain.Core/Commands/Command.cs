/// ---------------------------------------------------------------------------
/// <copyright file="Command.cs" company="Jack Henry &amp; Associates, Inc.">
///     Copyright (c) 1999-2019,, Jack Henry &amp; Associates, Inc. All Rights Reserved.
/// </copyright>
/// <author>Jack Henry &amp; Associates, Inc.</author>
/// <date>Created:  7/9/2019 3:44:58 PM</date>
/// <summary>"Command.cs" is part of "MicroRabbit.Domain.Core.Commands".  
/// </summary>
/// ---------------------------------------------------------------------------

namespace MicroRabbit.Domain.Core.Commands
{
	using MicroRabbit.Domain.Core.Events;
	using System;
	using System.Collections.Generic;
	using System.Text;


	public abstract class Command : Message
	{
		public DateTime Timestamp { get; protected set; }

		protected Command()
		{
			Timestamp = DateTime.UtcNow;
		}
	}
}
