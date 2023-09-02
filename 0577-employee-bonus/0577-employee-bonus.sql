/* Write your T-SQL query statement below */
select A.name as name,B.bonus as bonus
from Employee as A 
left join Bonus as B
on A.empId=B.empId
where B.bonus < 1000 or B.bonus is null