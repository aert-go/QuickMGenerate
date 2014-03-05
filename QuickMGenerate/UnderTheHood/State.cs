﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace QuickMGenerate.UnderTheHood
{
	public class State
	{
		public readonly Random Random = new Random();

		public readonly List<PropertyInfo> StuffToIgnore = new List<PropertyInfo>();

		public readonly Dictionary<Type, Generator<State, object>> PrimitiveGenerators
			= new Dictionary<Type, Generator<State, object>>
			  	{
			  		{ typeof(int), MGen.Int().AsObject() },
					{ typeof(int?), MGen.Int().Nullable().AsObject() },
					{ typeof(char), MGen.Char().AsObject() },
					{ typeof(char?), MGen.Char().Nullable().AsObject() },
					{ typeof(bool), MGen.Bool().AsObject() }
				};
	}
}