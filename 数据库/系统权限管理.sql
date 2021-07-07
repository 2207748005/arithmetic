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
--�� T_user ��������ݣ���id01�����»���123��KBB��5678900�����ϳ�ɳ��13899005678��ldh123��admin����
insert into T_user values('id01','���»�','123','KBB','5678900','���ϳ�ɳ','13899005678','ldh123','admin')

--��ѯ����������Ϊ��KBB���Ĳ���Ա�Ļ�����Ϣ��
select * from T_user where dept_id='KBB'
--�޸� T_user �����û� Id Ϊ��id01������ϵ��ַΪ��������������
update T_user set address='��������' where user_id='id01'
--��ѯ�����е绰�����ԡ�138����ͷ�Ĳ���Ա��
select * from T_user where handphone like '138%'
--��ѯ�����������ԡ�������ͷ�Ĳ���Ա��
select * from T_user where user_name like '��%'
--��ѯ��ϵͳ�е����н�ɫ��
select * from T_func_role_def

--��ѯ����Ӧ��Ͷ�������ˡ���ɫ�Ĳ���Ա������

--��ѯ����Ͷ�������ˡ���ɫ��ӵ�еĹ��ܣ�

--������ͼ��ѯ����Ա��������������������ţ�
go
create view T_user_view 
as
select user_name ����,user_passwd ����,dept_id ��������  from T_user
go
select * from T_user_view 
--�����洢���̣���ѯ��Ͷ�������ˡ���ɫ��ӵ�еĹ��ܣ�
go
create proc  usp_select
@