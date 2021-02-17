using System;

public class Student : Person
{
	private Degree degree { get; set; }
	
	public Student(string fornames, string surname, string emailAddress, string dateOfBirth, Degree degree)
    {
		this.fornames = fornames;
		this.surname = surname;
		this.emailAddress = emailAddress;
		this.dateOfBirth = dateOfBirth;
		this.parsedDateOfBirth = DateTime.Parse(dateOfBirth);
		this.degree = degree;
		this.firstName = fornames.Substring(0, fornames.IndexOf(" "));
		this.fullName = $"{fornames}{surname}";
    }

    public override string ToString()
    {
        return $"{fullName}, Date of Birth:{dateOfBirth}, Email Address{emailAddress}, Associate Degree{degree}";
    }
}
