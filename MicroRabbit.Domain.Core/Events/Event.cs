/// ---------------------------------------------------------------------------
/// <copyright file="Event.cs" company="Jack Henry &amp; Associates, Inc.">
///     Copyright (c) 1999-2019,, Jack Henry &amp; Associates, Inc. All Rights Reserved.
/// </copyright>
/// <author>Jack Henry &amp; Associates, Inc.</author>
/// <date>Created:  7/9/2019 3:53:01 PM</date>
/// <summary>"Event.cs" is part of "MicroRabbit.Domain.Core.Events".  
/// </summary>
/// ---------------------------------------------------------------------------

namespace MicroRabbit.Domain.Core.Events
{
	using System;
	using System.Collections.Generic;
	using System.Text;


	public abstract class Event
	{
		public DateTime Timestamp { get; protected set; }

		protected Event()
		{
			Timestamp = DateTime.UtcNow;
		}
	}
}
