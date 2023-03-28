﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Helpers
{
	public static class RandomValueGenerator
	{
		public static string GenerateFileName(string extension)
		{
			return Guid.NewGuid().ToString().Replace("-", "") + extension;
		}
	}
}
