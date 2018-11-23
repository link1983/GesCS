CREATE TABLE sys_menu(
id integer PRIMARY KEY autoincrement,
name varchar(50),
text varchar(50),
tag varchar(200),
level int,
xh int,
fid int
);

insert into sys_menu (name,text,tag,fid,level,xh) values('menuSetting','设置','',0,1,1)
insert into sys_menu (name,text,tag,fid,level,xh) values('menuUser','用户维护','',1,2,1)
insert into sys_menu (name,text,tag,fid,level,xh) values('menuUserAdd','添加用户','',1,)
insert into sys_menu (name,text,tag,fid,level,xh) values('menuUserDelete','删除用户','',1)
insert into sys_menu (name,text,tag,fid,level,xh) values('menuUserLogin','登录用户','GesCS.Login',1)
insert into sys_menu (name,text,tag,fid,level,xh) values('menuMedicine','药物','',0)
insert into sys_menu (name,text,tag,fid,level,xh) values('menuMedicineSend','发药','',2)
insert into sys_menu (name,text,tag,fid,level,xh)values('menuMedicineBack','退药','',2)
