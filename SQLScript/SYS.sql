CREATE TABLE sys_menu(
id integer PRIMARY KEY autoincrement,
name varchar(50),
text varchar(50),
tag varchar(200),
level int,
xh int,
fid int
);

insert into sys_menu (name,text,tag,fid,level,xh) values('menuSetting','����','',0,1,1)
insert into sys_menu (name,text,tag,fid,level,xh) values('menuUser','�û�ά��','',1,2,1)
insert into sys_menu (name,text,tag,fid,level,xh) values('menuUserAdd','����û�','',1,)
insert into sys_menu (name,text,tag,fid,level,xh) values('menuUserDelete','ɾ���û�','',1)
insert into sys_menu (name,text,tag,fid,level,xh) values('menuUserLogin','��¼�û�','GesCS.Login',1)
insert into sys_menu (name,text,tag,fid,level,xh) values('menuMedicine','ҩ��','',0)
insert into sys_menu (name,text,tag,fid,level,xh) values('menuMedicineSend','��ҩ','',2)
insert into sys_menu (name,text,tag,fid,level,xh)values('menuMedicineBack','��ҩ','',2)
