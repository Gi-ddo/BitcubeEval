using System;
using System.Collections.Generic;


namespace Training_Facility
{
	public class Course
	{
		private string courseName { get; set; }
		private int durationInMonths { get; set; }
		private Degree degree { get; set; }

		public Course(string courseName, int durationInMonths, Degree degree)
		{
			this.courseName = courseName;
			this.durationInMonths = durationInMonths;
			this.degree = degree;
		}

		public override string ToString()
		{
			return $"Course Name: {courseName}, Duration:{durationInMonths} Months, Degree:{degree}";
		}


	}
}

