select a.student_id,a.student_name, b.subject_name,
count(e.subject_name) as attended_exams
from 
Students as a
cross join 
Subjects as b
left join 
Examinations as e
ON 
a.student_id = e.student_id 
and b.subject_name = e.subject_name
group by a.student_id,a.student_name,b.subject_name
order by a.student_id,a.student_name,b.subject_name



