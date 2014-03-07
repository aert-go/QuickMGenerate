﻿using Xunit;

namespace QuickMGenerate.Tests.Primitives
{
	[Decimals(
		Content = "Use `MGen.Decimal()`.",
		Order = 0)]
	public class DecimalGeneration
	{
		[Fact]
		[Decimals(
			Content = "The overload `MGen.Decimal(decimal min, decimal max)` generates a decimal higher or equal than min and lower than max.",
			Order = 1)]
		public void Zero()
		{
			var generator = MGen.Decimal(0, 0);
			for (int i = 0; i < 10; i++)
			{
				Assert.Equal(0, generator.Generate());
			}
		}

		[Fact]
		[Decimals(
			Content = "The default generator is (min = 1, max = 100).",
			Order = 2)]
		public void DefaultGeneratorBetweenOneAndHundred()
		{
			var generator = MGen.Decimal();
			for (int i = 0; i < 10; i++)
			{
				var val = generator.Generate();
				Assert.True(val >= 1);
				Assert.True(val < 100);
			}
		}

		[Fact]
		[Decimals(
			Content = "Can be made to return `decimal?` using the `.Nullable()` extension.",
			Order = 3)]
		public void Nullable()
		{
			var generator = MGen.Decimal().Nullable();
			var isSomeTimesNull = false;
			var isSomeTimesNotNull = false;
			for (int i = 0; i < 50; i++)
			{
				var value = generator.Generate();
				if (value.HasValue)
				{
					isSomeTimesNotNull = true;
					Assert.NotEqual(0, value.Value);
				}
				else
					isSomeTimesNull = true;
			}
			Assert.True(isSomeTimesNull);
			Assert.True(isSomeTimesNotNull);
		}

		[Fact]
		[Decimals(
			Content = " - `decimal` is automatically detected and generated for object properties.",
			Order = 4)]
		public void Property()
		{
			var generator = MGen.One<SomeThingToGenerate>();
			for (int i = 0; i < 10; i++)
			{
				Assert.NotEqual(0, generator.Generate().AProperty);
			}
		}

		[Fact]
		[Decimals(
			Content = " - `decimal?` is automatically detected and generated for object properties.",
			Order = 5)]
		public void NullableProperty()
		{
			var generator = MGen.One<SomeThingToGenerate>();
			var isSomeTimesNull = false;
			var isSomeTimesNotNull = false;
			for (int i = 0; i < 50; i++)
			{
				var value = generator.Generate().ANullableProperty;
				if (value.HasValue)
				{
					isSomeTimesNotNull = true;
					Assert.NotEqual(0, value.Value);
				}
				else
					isSomeTimesNull = true;
			}
			Assert.True(isSomeTimesNull);
			Assert.True(isSomeTimesNotNull);
		}

		public class SomeThingToGenerate
		{
			public decimal AProperty { get; set; }
			public decimal? ANullableProperty { get; set; }
		}

		public class DecimalsAttribute : ThePrimitiveGeneratorsAttribute
		{
			public DecimalsAttribute()
			{
				Caption = "Decimals.";
				CaptionOrder = 5;
			}
		}
	}
}