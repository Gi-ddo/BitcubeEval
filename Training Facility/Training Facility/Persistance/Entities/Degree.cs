﻿using System;
using System.Collections.Generic;


namespace Training_Facility
{
	public class Degree
	{
		public string degreeName { get; set; }
		public int durationInYears { get; set; }
		public  List<Course> courses { get; set; }
		public  Lecturer lecturer { get; set; }

		public Degree(string degreeName, int durationInYears, Lecturer lecturer, List<Course> courses)
		{
			this.degreeName = degreeName;
			this.durationInYears = durationInYears;
			this.lecturer = lecturer;
			this.courses = courses;
		}

		public override string ToString()
		{
			return $"Degree:{degreeName}, Duration:{durationInYears} Years, Courses Available:{courses}, Associate Lecturere:{lecturer}";
		}

	}
}

	
