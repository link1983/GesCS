CREATE TABLE sys_menu(
id integer PRIMARY KEY autoincrement,
text varchar(50),
tag varchar(200),
xh int,
fid int
);

insert into sys_menu (text,tag,xh,fid) values('����','',1,0)
insert into sys_menu (text,tag,xh,fid) values('�û�ά��','',1,1)
insert into sys_menu (text,tag,xh,fid) values('����û�','',1,3)
insert into sys_menu (text,tag,xh,fid) values('ɾ���û�','',2,3)
insert into sys_menu (text,tag,xh,fid) values('��¼�û�','GesCS.Login',3,3)
insert into sys_menu (text,tag,xh,fid) values('ҩ��','',2,0)
insert into sys_menu (text,tag,xh,fid) values('��ҩ','',1,2)
insert into sys_menu (text,tag,xh,fid) values('��ҩ','',2,2)
