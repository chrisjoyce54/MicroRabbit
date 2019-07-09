/// ---------------------------------------------------------------------------
/// <copyright file="Message.cs" company="Jack Henry &amp; Associates, Inc.">
///     Copyright (c) 1999-2019,, Jack Henry &amp; Associates, Inc. All Rights Reserved.
/// </copyright>
/// <author>Jack Henry &amp; Associates, Inc.</author>
/// <date>Created:  7/9/2019 3:49:18 PM</date>
/// <summary>"Message.cs" is part of "MicroRabbit.Domain.Core.Events".  
/// </summary>
/// ---------------------------------------------------------------------------

namespace MicroRabbit.Domain.Core.Events
{
	using MediatR;
	using System;
	using System.Collections.Generic;
	using System.Text;


	public abstract class Message : IRequest<bool>
	{
		public string MessageType { get; protected set; }

		protected Message()
		{
			MessageType = GetType().Name;
		}
	}
}
