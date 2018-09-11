
----table 1 product----
create table product(

productID int identity(1,1) primary key,
Product_name varchar(40) 

)

insert into product(Product_name) values('led screen')
insert into product(Product_name) values('tv')
insert into product(Product_name) values('Dekstop Computers')
insert into product(Product_name) values('Camera')
insert into product(Product_name) values('Telephone')
insert into product(Product_name) values('vehicles')
insert into product(Product_name) values('books')
insert into product(Product_name) values('pens')

drop table product



create table suppliers(

SupplierID int identity(1,1) primary key,
Supplier_name varchar(40) 

)

insert into suppliers(Supplier_name) values('Mas Holdings')
insert into suppliers(Supplier_name) values('Hitachi')
insert into suppliers(Supplier_name) values('Samsung')
insert into suppliers(Supplier_name) values('Singhagiri')
insert into suppliers(Supplier_name) values('Sri Lanka Telecom')
insert into suppliers(Supplier_name) values('Gihan Foods')
insert into suppliers(Supplier_name) values('Gunasena Book Shop')
insert into suppliers(Supplier_name) values('Ewis')





----table 2 purchase----





create table purchase(


invoice_no int primary key,
supplier_name varchar(40),
date1 date,
product_name varchar(40),
qty float,
Rate float,
amount float
)
drop table purchase





----table 3 expenditures----

create table expenditures(

expense_no integer identity(1,1) primary key,
name varchar(40),
amount float,
receiver varchar(50),
description1 varchar(50),
dates date
)

insert into expenditures(name,amount,Receiver,description1,dates) values('water bill',1000,'water board','company water bill','2011-11-11')


drop table expenditures
alter table expenditures add Receiver varchar(50)  
alter table expenditures add description_ varchar(50)  
SElect * from expenditures


insert into 




----table 4 sales----
create table sales(

sales_invoiceNo int  primary key,
time_	datetime,
type_ varchar(50),
channelname varchar(50),
location varchar(50),
client_name varchar(50),
costperday float,
duration int,
no_of_spot int,
net_amount float
)

drop table sales

create table channelname(
cid int identity(1,1) primary key,
Name varchar(50)
)

create table location(
lid int identity(1,1) primary key,
Name varchar(50)
)


insert into location(name) values('Unity Plaza')
insert into location(name) values('Liberty Cinema')
insert into location(name) values('Thurstan')
insert into location(name) values('Arcade Jawatta side')
insert into location(name) values('ARcade BMICH side')
insert into location(name) values('Nugegoda')

SELECT Name FROM location







insert into channelname(name)

values('CInema Advertising')

 
drop table sales


----table 5 income----
create table income(

incomeNo integer primary key,
name varchar(40),
amount float,
date1 date,
)


create table client(

clientno int identity(1,1) primary key,
name varchar(50)
)

insert into client(name) values('Asiri Hospital')
insert into client(name) values('sampath Bank')
insert into client(name) values('Elephant house')
insert into client(name) values('Arpico')

insert into client(name) values('Seylan Bank')
insert into client(name) values('Commercial Bank')
insert into client(name) values('Softlogic Finance')
insert into client(name) values('Nippon Paint')
insert into client(name) values('Browns')
insert into client(name) values('Standard Charted')
insert into client(name) values('Singer Mega')
insert into client(name) values('DFCC bank')
insert into client(name) values('Asiri')

create table client(

clientno int identity(1,1) primary key,
name varchar(50)
)
insert into client(name) values('Asiri Hospital')
insert into client(name) values('sampath Bank')
insert into client(name) values('Elephant house')
insert into client(name) values('Arpico')

insert into client(name) values('Seylan Bank')
insert into client(name) values('Commercial Bank')
insert into client(name) values('Softlogic Finance')
insert into client(name) values('Nippon Paint')
insert into client(name) values('Browns')
insert into client(name) values('Standard Charted')
insert into client(name) values('Singer Mega')
insert into client(name) values('DFCC bank')
insert into client(name) values('Asiri')



