/* Write your T-SQL query statement below */

select id 
from 
(Weather a inner join (select CONVERT(CHAR(10), DateAdd(dd, +1, recordDate), 23) as recordDate , temperature as yesterDayTemperature from Weather) b
on a.recordDate = b.recordDate)
where temperature > yesterDayTemperature



