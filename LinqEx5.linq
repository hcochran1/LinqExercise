<Query Kind="Statements">
  <Connection>
    <ID>2201df26-bcc1-4967-8667-2c198c4f8b5d</ID>
    <Persist>true</Persist>
    <Server>DESKTOP-BC72E26</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

//List all the employees with the most years of experience.
var maxYears = EmployeeSkills.Max(y => y.YearsOfExperience);
var EmpMaxYears = from emy in EmployeeSkills
				  where emy.YearsOfExperience == maxYears
				  select new
				  {
				  	MostExperiencedEmployees = from emp in Employees
						   where emy.EmployeeID == emp.EmployeeID
						   select new
						   {
						   		Name = emp.FirstName + " " + emp.LastName
						   }
				  };


maxYears.Dump();
EmpMaxYears.Dump();
