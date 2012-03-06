using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeKata
{
	public class Range
	{
		public int Low { get; set; }
		public int High { get; set; }

		public Range(
			int lowEndOfRange, 
			int highEndOfRange, 
			LowRangeEndInclusivity lowEndInclusivity, 
			HighRangeEndInclusivity highEndInclusivity)
		{
			Low = lowEndOfRange;
			High = highEndOfRange;
			LowEndInclusivity = lowEndInclusivity;
			HighEndInclusivity = highEndInclusivity;			
		}

		public LowRangeEndInclusivity LowEndInclusivity { get; set; }
		public HighRangeEndInclusivity HighEndInclusivity { get; set; }

	}
}
