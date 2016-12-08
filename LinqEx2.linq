<Query Kind="Statements">
  <Connection>
    <ID>2201df26-bcc1-4967-8667-2c198c4f8b5d</ID>
    <Persist>true</Persist>
    <Server>DESKTOP-BC72E26</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

from skill in Skills
orderby skill.Description ascending
select new
	{
		Description = skill.Description	
	}