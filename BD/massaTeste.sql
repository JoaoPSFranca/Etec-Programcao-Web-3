insert into pessoa values (1, '627.750.999-39', 'Tiago Araújo', '(21) 2772-7090');
insert into pessoa values (2, '266.863.748-14', 'Patrícia Galvão', '(68) 3913-8235');
insert into pessoa values (3, '059.480.317-99', 'Bruno Duarte', '(75) 3681-7139');

select * from pessoa;

insert into raca values(1,'Pinscher', 'Pequeno');
insert into raca values(2,'Beagle', 'Medio');
insert into raca values(3,'Labrador', 'Grande');

select * from raca;

insert into pet values(1, 1, 2, 'Meg', 15.0, '2020-12-23');
insert into pet values(2, 1, 1, 'Eudora', 7.5, '2018-07-15');
insert into pet values(1, 2, 1, 'Karla', 10.0, '2019-06-18');
insert into pet values(1, 3, 3, 'Zeus', 20.0, '2015-04-21');
insert into pet values(2, 3, 2, 'Diana', 13.0, '2017-05-28');
insert into pet values(3, 3, 1, 'Chuchu', 8.0, '2019-02-12');

select * from pet;