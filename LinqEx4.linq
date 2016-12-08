<Query Kind="Expression">
  <Connection>
    <ID>2201df26-bcc1-4967-8667-2c198c4f8b5d</ID>
    <Persist>true</Persist>
    <Server>DESKTOP-BC72E26</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

//From the shifts scheduled for NAIT's placement contract, 
//show the number of employees needed for each day (ordered by day-of-week). 
//Bonus: display the name of the day of week (first day being Monday).

from shi in Shifts
where 

