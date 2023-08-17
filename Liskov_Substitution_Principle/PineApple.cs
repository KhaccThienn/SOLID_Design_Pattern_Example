﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
	internal class PineApple : IFruit
	{
		public string GetColor()
		{
			return "Yellow Orange";
		}
	}
}
