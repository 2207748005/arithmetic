create database shopDB

use shopDB

create table T_user(
   id int primary key identity,
   name varchar(25) not null,
   trueName varchar(25) not null,
   cardId varchar(18) not null,
   email varchar(50) not null,
   telephone varchar(25) not null,
   qqId varchar(25) ,
   pwd varchar(25) default(123456) not null,
   regTime datetime default(getdate()) not null,
   question varchar(60),
   answer varchar(100),
   state int default(1) not null
)

insert into T_user values('1x','张丽','22010202010120','123123@qq.com','123213','12312','123',GETDATE(),'您的生日','不告诉你',1);