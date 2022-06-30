-- 1
select *
from emp
where depno in (2, 6, 7) and
    date_part('year', born) between 1980 and 1989;

-- 2
select *
from emp
where post like 'программист' and
    salary*0.87 >= 40000;

-- 3
select split_part(name, ' ', 1)
from emp
where post like 'начальник отдела';

-- 4
select distinct depno
from emp
where post like 'экономист';

-- 5
select distinct post, salary*0.87
from emp;

-- 6
select count(*)
from emp
where gender like 'f';

-- 7
select depno, min(salary), max(salary)
from emp
where depno in (1, 2)
group by depno;

-- 8
select count(*)
from emp
where depno = 6;

-- 9
select depno, min(salary), max(salary),
    max(salary) - min(salary)
from emp
group by depno;

-- 10
select post, min(salary), max(salary)
from emp
group by post;

-- 11
select depno, post, avg(salary)
from emp
group by depno, post;

-- 12
select depno
from emp
group by depno
having count(*) < 4;

-- 13
select depno
from emp
group by depno
having age(current_date, max(born)) < interval '20 years';

-- 14
select depno
from emp
group by depno
having avg(age(current_date, born)) > interval '40 years';

-- 15
select emp.tabno, emp.name, project.no, project.pro, project.title
from emp, participants, project
where emp.tabno = participants.tabno and
    project.no = participants.no and
    project.pro = participants.pro;

-- 25
select project.no, project.pro, project.title, count(participants.no)
from project
left join participants on project.no = participants.no and
    project.pro = participants.pro
group by project.no, project.pro;

-- 26
select project.no, project.pro, project.title, count(participants.no)
from project
left join participants on project.no = participants.no and
    project.pro = participants.pro
group by project.no, project.pro
having count(participants.no) > 10;

-- 28
select depno
from emp
group by depno
having count(distinct gender) = 1;

-- 32
select tabno, name
from emp
where salary < (select avg(salary)
                from emp as emp2
                where emp2.depno=emp.depno);

-- 34
select tabno, name
from emp
where salary = (select max(salary)
                from emp as emp2
                where emp2.depno=emp.depno);
