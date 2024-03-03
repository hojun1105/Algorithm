/* Write your T-SQL query statement below */
select p.product_id as product_id, 
CASE 
    WHEN SUM(ISNULL(u.units, 0)) = 0 THEN 0
    ELSE ROUND(CONVERT(FLOAT, SUM(p.price * u.units)) / NULLIF(SUM(u.units), 0), 2)
  END AS average_price
from Prices p 
left outer join UnitsSold u 
on p.product_id = u.product_id 
and u.purchase_date between p.start_date and p.end_date
group by p.product_id