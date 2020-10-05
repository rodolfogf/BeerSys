use beersys;
update brand set id_brand = 3 where id_brand = 5;
create table user(
	id_user int auto_increment primary key,
    name_user varchar(50),
    password_user varchar(50)
);
insert into user(name_user,password_user,is_admin) values ('jose',123,true);
insert into user(name_user,password_user,is_admin) values ('maria',123,false);
INSERT INTO style (name_style, id_family) VALUES ('Brahma Pilsen', 1);

select * from product;
alter table user add is_admin bool;
alter table product MODIFY vessel_indice varchar(30);

truncate table style;
select * from user;
select * from brand;
select * from style;
select is_admin from user;
select id_family from family where name_family = 'Lager';
select * from style;
delete from user where id_user = 7;
delete from style where id_style = 2;
select count(*) from user where name_user = 'jose' and password_user = 123 and is_admin = false;