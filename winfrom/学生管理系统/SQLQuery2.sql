
create database studentDB

use studentDB

create table T_user(
    user_id varchar(12) primary key,
	user_name varchar(50) not null,
	user_password varchar(12) not null
)

insert into T_user values('admin','Admin','123456')
insert into T_user values('hehe','Hehe','111111')