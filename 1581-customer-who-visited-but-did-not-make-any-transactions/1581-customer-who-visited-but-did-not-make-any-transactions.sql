/* Write your T-SQL query statement below */



/* Using outer join 
select customer_id, count(*) as count_no_trans from 
(
    Visits a left join Transactions b
    on a.visit_id = b.visit_id 
) where b.visit_id is null
group by customer_id 
*/

select customer_id, count(*) as count_no_trans from 
Visits where visit_id not in (select distinct visit_id from Transactions)
group by customer_id

