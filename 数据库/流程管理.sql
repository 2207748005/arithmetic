create table T_flow_step_def(
    step_id int primary key,
	step_name varchar(30),
	step_des varchar(30),
	limit_time int,
	url varchar(64),
	reserve varchar(256)
)
--
create table T_flow_type(
  flow_type_id char(3) primary key,
  flow_type_name varchar(64),
  in_method_id char(3),
  in_scope_id char(3),
  reserve varchar(256)
)
-- 
create table T_sub_project(
   project_id varchar(32) ,
   sub_pro_id char(2) default('0'),
   flow_type_id char(3) foreign key references	T_flow_type(flow_type_id),--外键
   sub_pro_name varchar(64),
   usb_no varchar(64),
   in_method_id char(3) check(in_method_id='1'or in_method_id='2' ),
   in_scope_id char(3),
   in_choice_id char(3),
   proj_type_id char(3),
   engj_type_id char(3),
   pack_type char(1) default('0'),
   grade_type_id char(1),
   flag_done char(1) default('0'),
   flag_forcebreak char(1) default('0'),
   reserve varchar(256)
   primary key(project_id,sub_pro_id)
)
create table T_flow_procedure(
  step_no int foreign key references T_flow_step_def(step_id),--外键
  flow_type_id char(3) foreign key references T_flow_type(flow_type_id),--外键
  serial_no int,
  limit_time int,
  reserve varchar(30)
  primary key(step_no,flow_type_id)
)
--用 SQL 语句完成如下操作： 
-- 在 T_flow_step_def 表中插入数据：“1，中标公示，公示中标 
--情况，30，http://localhost:8080/stepmenu.jsp，在规定时间内 
--如有异议则请联系我们”；
insert into T_flow_step_def VALUES('1','中标公示','公示中标情况','30','http://localhost:8080/stepmenu.jsp','在规定时间内如有异议则请联系我们') 
-- 更新 T_flow_step_def 表中流程步骤 ID 为 1 的记录，将二级菜单链接修改为“http://localhost/stepmenu”；
UPDATE  T_flow_step_def SET url='http://localhost/stepmenu' where step_id='1'
-- 查询出招标方式代号为“1”的所有标段情况信息； 
select * from T_sub_project where in_method_id='1';
-- 查询出招表方式为“邀请”所指代代号的所有标段情况信息； 
select * from T_sub_project where in_method_id='2'
-- 查询处所有发包方式不为“0”的所有标段情况信息；
select * from T_sub_project where pack_type!='0'
-- 查询 T_flow_step_def 表中所有二级菜单链接包含“menu”字符的记录；
select * from T_flow_step_def where url like '%menu%'
-- 查询出所有完成标志为“0”的标段情况信息； 
select * from T_sub_project where flag_done='0'
-- 查询出流程类别名称为“开标”的所有标段情况； 

-- 查询出流程类别名称为“开标”的所有标段记录总数； 

-- 创建视图查询所有流程类别及标段情况，包含流程类别编号、 流程类别名称、标段编号，标段名称；
