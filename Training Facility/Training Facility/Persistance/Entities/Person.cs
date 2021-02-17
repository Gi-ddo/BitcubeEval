using System;


namespace Training_Facility
{
	public abstract class Person
	{
		protected string fornames { get; set; }
		protected string surname { get; set; }
		protected string emailAddress { get; set; }
		protected string dateOfBirth { get; set; }
		protected DateTime parsedDateOfBirth { get; set; }
		protected string firstName { get; set; }
		protected string fullName { get; set; }
	}
}

