﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public interface IEntity<TKey>
	{
		TKey Id { get; set; }
	}

	public interface IEntity : IEntity<int> { }
	
	
}
