﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RangeKata
{
	[TestFixture]
	public class RangeTests
	{
		[Test]
		public void CanInstantiateTest()
		{
			Range r = new Range(
				2, 
				6, 
				LowRangeEndInclusivity.IsInclusive,
				HighRangeEndInclusivity.IsExclusive);

			Assert.That(r, Is.Not.Null);
			Assert.That(r.Low, Is.EqualTo(2));
			Assert.That(r.High, Is.EqualTo(6));
			Assert.That(
				r.LowEndInclusivity, 
				Is.EqualTo(LowRangeEndInclusivity.IsInclusive));
			Assert.That(
				r.HighEndInclusivity,
				Is.EqualTo(HighRangeEndInclusivity.IsExclusive));
		}

		[Test]
		public void CanDetermineIfRangeContainsListTest()
		{
			List<int> listToCheck = new List<int> { 2, 4 };
			Range r = new Range(
				2,
				6,
				LowRangeEndInclusivity.IsInclusive,
				HighRangeEndInclusivity.IsExclusive);

			bool contains = r.Contains(listToCheck);

			Assert.That(contains, Is.True);
		}

		[Test]
		public void CanDetermineIfRangeContainsIntegerTest()
		{
			Range r = new Range(
				2,
				6,
				LowRangeEndInclusivity.IsInclusive,
				HighRangeEndInclusivity.IsExclusive);

			Assert.That(r.Contains(5), Is.True);
			Assert.That(r.Contains(2), Is.True);
			Assert.That(r.Contains(1), Is.False);
			Assert.That(r.Contains(4), Is.True);
			Assert.That(r.Contains(6), Is.False);
		}
	}
}
