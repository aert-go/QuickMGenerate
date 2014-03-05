﻿using QuickMGenerate.UnderTheHood;

namespace QuickMGenerate
{
	public static partial class MGen
	{
		public static Generator<State, object> AsObject<T>(this Generator<State, T> generator)
		{
			return
				s =>
					{  
						var val = generator(s).Value;
						return new Result<State, object>(val, s);
					};
		}
	}
}