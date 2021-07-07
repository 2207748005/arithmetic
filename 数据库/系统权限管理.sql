create database ConstructionDB 

use ConstructionDB

create table T_user(
  user_id char(4) primary key,
  user_name char(16),
  user_passwd char(16),
  dept_id char(3),
  telephone varchar(16),
  address varchar(32),
  handphone varchar(16),
  usb_no varchar(16),
  reserve varchar(16)
)

create table T_func_item(
   func_id char(3) primary key,
   func_name varchar(32),
   reserve varchar(64)
)

create table T_func_role_def(
  func_role_id char(3) primary key,
  func_role_name varchar(32),
  reserve varchar(64)
)
create table Relationship_1(
   func_id char(3) foreign key references T_func_item(func_id),
   func_role_id char(3) foreign key references T_func_role_def(func_role_id)
)
create table Relationship_2(
   func_role_id char(3) foreign key references T_func_role_def(func_role_id),
   user_id char(4) foreign key references T_user(user_id)
)
--在 T_user 表插入数据：“id01，刘德华，123，KBB，5678900，湖南长沙，13899005678，ldh123，admin”；
insert into T_user values('id01','刘德华','123','KBB','5678900','湖南长沙','13899005678','ldh123','admin')

--查询出所属部门为“KBB”的操作员的基本信息；
select * from T_user where dept_id='KBB'
--修改 T_user 表中用户 Id 为“id01”的联系地址为“湖南岳阳”；
update T_user set address='湖南岳阳' where user_id='id01'
--查询出所有电话号码以“138”开头的操作员；
select * from T_user where handphone like '138%'
--查询出所用姓名以“刘”开头的操作员；
select * from T_user where user_name like '刘%'
--查询出系统中的所有角色；
select * from T_func_role_def

--查询出对应“投标责任人”角色的操作员数量；

--查询出“投标责任人”角色所拥有的功能；

--创建视图查询操作员的姓名，密码和所属部门；
go
create view T_user_view 
as
select user_name 姓名,user_passwd 密码,dept_id 所属部门  from T_user
go
select * from T_user_view 
--创建存储过程，查询“投标责任人”角色所拥有的功能；
go
create proc  usp_select
@