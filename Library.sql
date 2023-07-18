/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     2023/7/2 21:13:05                            */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('borrowInfo') and o.name = 'FK_BORROWIN_REFERENCE_READERIN')
alter table borrowInfo
   drop constraint FK_BORROWIN_REFERENCE_READERIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('borrowInfo') and o.name = 'FK_BORROWIN_REFERENCE_BOOKINFO')
alter table borrowInfo
   drop constraint FK_BORROWIN_REFERENCE_BOOKINFO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('bookInfo')
            and   type = 'U')
   drop table bookInfo
go

if exists (select 1
            from  sysobjects
           where  id = object_id('borrowInfo')
            and   type = 'U')
   drop table borrowInfo
go

if exists (select 1
            from  sysobjects
           where  id = object_id('login')
            and   type = 'U')
   drop table login
go

if exists (select 1
            from  sysobjects
           where  id = object_id('readerInfo')
            and   type = 'U')
   drop table readerInfo
go

/*==============================================================*/
/* Table: bookInfo                                              */
/*==============================================================*/
create table bookInfo (
   ISBN                 varchar(30)          not null,
   bname                varchar(30)          not null,
   press                varchar(30)          null,
   author               varchar(30)          null,
   totalnum             int                  not null,
   avanum               int                  not null,
   borrow               varchar(30)          not null,
   constraint PK_BOOKINFO primary key (ISBN)
)
go

/*==============================================================*/
/* Table: borrowInfo                                            */
/*==============================================================*/
create table borrowInfo (
   account              varchar(30)          not null,
   ISBN                 varchar(30)          not null,
   bdate                datetime             not null,
   ddl                  datetime             not null,
   rdate                datetime             null,
   fine                 int                  not null,
   constraint PK_BORROWINFO primary key (account, ISBN)
)
go

/*==============================================================*/
/* Table: login                                                 */
/*==============================================================*/
create table login (
   account              varchar(30)          not null,
   password             varchar(30)          not null,
   authority            int                  not null,
   constraint PK_LOGIN primary key (account)
)
go

/*==============================================================*/
/* Table: readerInfo                                            */
/*==============================================================*/
create table readerInfo (
   account              varchar(30)          not null,
   name                 varchar(30)          not null,
   sex                  varchar(30)          not null,
   job                  varchar(30)          null,
   totalnum             int                  not null,
   borrownum            int                  not null,
   department           varchar(30)          null,
   phone                varchar(30)          null,
   constraint PK_READERINFO primary key (account)
)
go

alter table borrowInfo
   add constraint FK_BORROWIN_REFERENCE_READERIN foreign key (account)
      references readerInfo (account)
	  on delete cascade
go

alter table borrowInfo
   add constraint FK_BORROWIN_REFERENCE_BOOKINFO foreign key (ISBN)
      references bookInfo (ISBN)
go

create proc ReaderInfoQuery
@account varchar(30)
as 
begin
	select * from readerInfo where account = @account
end
go

create proc NRBookQuery
@account varchar(30)
as 
begin
	select borrowInfo.ISBN,bname from borrowInfo, bookInfo where account = @account and borrowInfo.ISBN = bookInfo.ISBN and rdate is null
end
go

create unique index bookIndex on bookInfo(ISBN)
go

create proc BookInfoQuery
@ISBN varchar(30),
@bname varchar(30),
@press varchar(30),
@author varchar(30)
as 
begin
	select * from bookInfo where ISBN like '%' + @ISBN + '%' and bname like '%' + @bname + '%' and press like '%' + @press + '%' and author like '%' + @author + '%'
end
go

create view NRInfo
as
	select bookInfo.ISBN,bookInfo.bname,readerInfo.name,readerInfo.account,borrowInfo.bdate,borrowInfo.ddl from bookInfo,readerInfo,borrowInfo
	where bookInfo.ISBN = borrowInfo.ISBN and readerInfo.account = borrowInfo.account and borrowInfo.rdate is null
go

create trigger borrowBook on borrowInfo for insert
as 
begin
	declare @num int
	update bookInfo set avanum = avanum - 1 where ISBN in (select ISBN from inserted)
	set @num = (select avanum from bookInfo where ISBN in (select ISBN from inserted))
	if (@num <= 3)
		update bookInfo set borrow = '²»¿É½è' where ISBN in (select ISBN from inserted)
	update readerInfo set borrownum = borrownum + 1 where account = (select account from inserted)
end
go

create trigger returnBook on borrowInfo for update
as 
begin
	if update(rdate)
	begin
		declare @num int
		update bookInfo set avanum = avanum + 1 where ISBN in (select ISBN from inserted)
		set @num = (select avanum from bookInfo where ISBN in (select ISBN from inserted))
		if (@num > 3)
			update bookInfo set borrow = '¿É½è' where ISBN in (select ISBN from inserted)
		update readerInfo set borrownum = borrownum - 1 where account = (select account from inserted)
	end
end