using System;
using System.Collections.Generic;

public class Degree
{
	private string degreeName { get; set; }
	private int durationInYears { get; set; }
	private List<Course> courses { get; set; }
	private Lecturer lecturer { get; set; }

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
	
