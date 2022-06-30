-- Единоличные владельцы помещений (доля которых равна 1) с указанием адреса квартиры, которой они владеют
select share, flatnum, name, streetname
from ownership, owners, address
where share like '1' and
    ownership.owner = owners.id and
    ownership.numbuilding = address.numbuilding;

-- Собственники с перечнем их документов (в том числе тех, у которых нет документов)
select name, doctype, docseria, docnum
from owners
left join documents on documents.owner = owners.id;

-- Квартиры, у которых более 10 собственников
select ownership.numbuilding, streetname, numhouse, flatnum, count(owner) as amount_of_owners
from ownership, address
where ownership.numbuilding = address.numbuilding
group by ownership.numbuilding, streetname, numhouse, flatnum
having count(owner) > 10;

-- Текущие собственники квартир по улице Чкалова
select name
from owners, ownership, address
where streetname like 'Chkalova st.' and
    owners.id = ownership.owner and
    ownership.numbuilding = address.numbuilding;

-- Квартиры, у которых в настоящее время нет собственников
select ownership.numbuilding, streetname, numhouse, flatnum
from ownership, address
where ownership.numbuilding = address.numbuilding and owner is null;

-- Квартиры, у которых в настоящее время нет собственников
select address.numbuilding, streetname, numhouse, flatnum
from ownership, address
where ownership.numbuilding = address.numbuilding and
    (select count(owner)
     from ownership as ownership2
     where ownership2.numbuilding = ownership.numbuilding) = 0; 

-- Квартиры, в числе собственников которых в настоящее время есть несовершеннолетние дети
-- Views that do not select from a single table or view are not automatically updatable.
create view minors as
    select distinct address.numbuilding, streetname, numhouse, flatnum
    from ownership, owners, address
    where ownership.owner = owners.id and 
        ownership.numbuilding = address.numbuilding and
        age(current_date, bdate) < interval '18 years';

-- Количество собственников по домам
-- Views that do not select from a single table or view are not automatically updatable.
create view house_owners as
    select address.numbuilding, streetname, numhouse, count(owner) as amount_of_owners
    from ownership, address
    where ownership.numbuilding = address.numbuilding
    group by address.numbuilding, streetname, numhouse;

-- Количество текущих собственников
-- Views that do not select from a single table or view are not automatically updatable.
create view amount_of_owners as
    select ownership.numbuilding, streetname, numhouse, flatnum, count(owner) as amount_of_owners
    from ownership, address
    where ownership.numbuilding = address.numbuilding
    group by ownership.numbuilding, streetname, numhouse, flatnum;

-- Квартиры, у которых более 1 собственников, в числе которых в настоящее время есть несовершеннолетние дети
select ownership.numbuilding, streetname, numhouse, flatnum
from ownership, address
where ownership.numbuilding = address.numbuilding
group by ownership.numbuilding, streetname, numhouse, flatnum
having count(owner) > 1
intersect
select * from minors;

-- Квартиры, у которых более 1 собственников и те, в числе собственников которых в настоящее время есть несовершеннолетние дети
select ownership.numbuilding, streetname, numhouse, flatnum
from ownership, address
where ownership.numbuilding = address.numbuilding
group by ownership.numbuilding, streetname, numhouse, flatnum
having count(owner) > 1
union
select * from minors;

-- Квартиры, у которых более 1 собственников, в числе которых в настоящее время нет несовершеннолетних детей
select ownership.numbuilding, streetname, numhouse, flatnum
from ownership, address
where ownership.numbuilding = address.numbuilding
group by ownership.numbuilding, streetname, numhouse, flatnum
having count(owner) > 1
except
select * from minors;
