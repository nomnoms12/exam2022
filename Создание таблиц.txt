create table Departs(
    id numeric(4) not null primary key,
    name varchar(100) not null
);

create table Emp(
    tabno numeric(5) primary key,
    name varchar(100) not null,
    born date not null,
    gender char not null,
    depno numeric(4) not null references Departs,
    post varchar(50) not null,
    salary numeric(8,2) not null check(salary > 12000),
    passport char(10) not null unique,
    pass_date date not null,
    pass_get varchar(100) not null,
    born_seat varchar(100),
    edu varchar(30),
    special varchar(100),
    diplom varchar(40),
    phone varchar(30),
    adr varchar(80),
    edate date not null default current_date,
    chief numeric(5) references Emp
);

create table Project(
    no numeric(5),
    pro varchar(15),
    title varchar(200) not null,
    client varchar(100) not null,
    dbegin date not null,
    dend date not null,
    cost numeric(9),
    primary key(no, pro)
);

create table Participants(
    no numeric(5),
    pro varchar(15),
    tabno numeric(5) references Emp,
    dbegin date not null,
    dend date,
    primary key(no, pro, tabno),
    foreign key(pro, no) references Project(pro, no)
);

insert into Departs(id, name)
values
    (1, 'Отдел по работе с клиентами'),
    (2, 'Инженерный отдел'),
    (3, 'Бухгалтерский отдел'),
    (4, 'Отдел директоров'),
    (5, 'Экономический отдел'),
    (6, 'IT отдел'),
    (7, 'Технический отдел');


insert into Emp(tabno, name, born, gender, depno, post, salary,
    passport, pass_date, pass_get, born_seat, edu, special, 
    diplom, phone, adr, edate, chief)
values
    (1, 'Masha Ignateva', '08.10.1989', 'f', 6, 'директор',
        60000, '5449856986', '06.06.2003',
        'УФМС в г. Пскове', 'Псков', 'Колледж ПсковГУ',
        'программист', 'Диплом №73254342',
        '+7 (800) 567-34-34', 'ул. Душкина, д. Плюшкина',
        '03.09.2008', null),
    (2, 'Ivanov Bogdan', '05.06.1983', 'm', 1, 'менеджер',
        16000, '5478560986', '06.06.2003',
        'УФМС по г. Саратов', 'Саратов', 'ПГУ', 'турист',
        'Диплом №7834095634', '+7 (800) 555-35-35',
        'ул. Пушкина, д. Колотушкина', '12.12.2012', 1);

INSERT INTO public.project(
    no, pro, title, client, dbegin, dend, cost)
    VALUES (1, 'МФЦ', 'Много центр', 'Саша', current_date, '2021-10-12', 10000);

INSERT INTO public.participants(
    no, pro, tabno, dbegin, dend)
    VALUES (2, 'МФЦ', 3, current_date, '2023-10-10');
