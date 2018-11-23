CREATE TABLE sys_menu(
id integer PRIMARY KEY autoincrement,
text varchar(50),
tag varchar(200),
xh int,
fid int
);

insert into sys_menu (text,tag,xh,fid) values('设置','',1,0)
insert into sys_menu (text,tag,xh,fid) values('用户维护','',1,1)
insert into sys_menu (text,tag,xh,fid) values('添加用户','',1,3)
insert into sys_menu (text,tag,xh,fid) values('删除用户','',2,3)
insert into sys_menu (text,tag,xh,fid) values('登录用户','GesCS.Login',3,3)
insert into sys_menu (text,tag,xh,fid) values('药物','',2,0)
insert into sys_menu (text,tag,xh,fid) values('发药','',1,2)
insert into sys_menu (text,tag,xh,fid) values('退药','',2,2)
