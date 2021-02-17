using System;
using System.Collections.Generic;

public  class Lecturer : Person
{
	private List<Degree> degrees { get; set; }

	public Lecturer(string fornames, string surname, string emailAddress,string dateOfBirth ,List<Degree> degrees)
    {
		this.fornames = fornames;
		this.surname = surname;
		this.emailAddress = emailAddress;
		this.dateOfBirth = dateOfBirth;
		this.parsedDateOfBirth = DateTime.Parse(dateOfBirth);
		this.degrees = degrees;
		this.firstName = fornames.Substring(0, fornames.IndexOf(" "));
		this.fullName = $"{fornames}{surname}";
    }

	public override string ToString()
	{
		return $"{fullName}, Date of Birth:{dateOfBirth}, Email Address:{emailAddress}, Associate Degrees:{degrees}";
	}
}
