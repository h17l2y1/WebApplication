﻿using System;

namespace WebApplication.Entities.Entities.Interfaces
{
	public interface IBaseEntity
	{
		string Id { get; set; }
		DateTime CreationDate { get; set; }
	}
}
