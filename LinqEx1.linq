<Query Kind="Expression">
  <Connection>
    <ID>2201df26-bcc1-4967-8667-2c198c4f8b5d</ID>
    <Persist>true</Persist>
    <Server>DESKTOP-BC72E26</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

from skill in Skills
where skill.RequiresTicket.Equals("True")
select new
	{
		Description = skill.Description,
		Employees = from empS in skill.EmployeeSkills
					select new
						{
							Name = from empN in Employees
								   where  empN.EmployeeID == empS.EmployeeID
								   select new
								   {
								    	Name = empN.FirstName + " " + empN.LastName
								   },
							Level = empS.Level,
							YearsExperience = empS.YearsOfExperience
						}
	}