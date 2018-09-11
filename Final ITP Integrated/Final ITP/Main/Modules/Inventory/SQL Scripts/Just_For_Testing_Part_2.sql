select * from tbl_user
select * from tbl_orders
select * from tbl_stocks
select * from tbl_ordered_Item_details
select * from tbl_inventory --not needed
select * from tbl_suppliers
select * from tbl_supplier_brands
select * from tbl_items
select * from tbl_warehouse_activities
select * from Vehicle_Request_Details
select * from vehicle_details

INSERT INTO Vehicle_Request_Details VALUES(1,'Lorry',12345,'2017-01-01','09:00:00','Colombo','Malabe')
INSERT INTO Vehicle_Request_Details VALUES(2,'Container',12346,'2017-01-02','09:00:00','Jaffna','Malabe')
INSERT INTO Vehicle_Request_Details VALUES(3,'Tipper',12347,'2017-01-03','09:00:00','Malabe','Jafna')
INSERT INTO Vehicle_Request_Details VALUES(4,'Truck',12348,'2017-01-04','09:00:00','Jaffna','Colombo')
INSERT INTO Vehicle_Request_Details VALUES(5,'Lorry',12349,'2017-01-05','09:00:00','Colombo','Malabe')

INSERT INTO tbl_warehouse_activities VALUES('asssd',1,'Stock','In','date')

insert into tbl_ordered_Item_details values('ORL1','PIS003',440,30800)

INSERT INTO tbl_user VALUES('C0001','Kumara.H','123456','Inventory Manager')
DROP TABLE tbl_warehouse_activities
DROP TABLE Vehicle_Request_Details
insert into tbl_suppliers values('S0001','Sinhagiri')
insert into tbl_suppliers values('S0002','Singer')

insert into tbl_supplier_brands values('S0001','Panasonic')
insert into tbl_supplier_brands values('S0001','Samsung')
insert into tbl_supplier_brands values('S0002','LG')
insert into tbl_supplier_brands values('S0002','Lenovo')

insert into tbl_items(Supplier_ID,Model,Brand,Unit_Price,Category,Type) values ('S0001','ABCX','Panasonic',50,'Indoor Equipment','Screen')
insert into tbl_items(Supplier_ID,Model,Brand,Unit_Price,Category,Type) values ('S0001','ABCC','Panasonic',50,'Indoor Equipment','Screen')
insert into tbl_items(Supplier_ID,Model,Brand,Unit_Price,Category,Type) values ('S0002','BCDX','Lenovo',60,'Outdoor Screens','Screen')
insert into tbl_items(Supplier_ID,Model,Brand,Unit_Price,Category,Type) values ('S0002','CDFA','LG',70,'Indoor Screens','Screen')
insert into tbl_items(Supplier_ID,Model,Brand,Unit_Price,Category,Type) values ('S0001','BABG','Samsung',80,'Indoor Screens','Screen')

insert into vehicle_details VALUES(1,12345,'Lorry','Batta','Demo',2,'Diesel')
insert into vehicle_details VALUES(2,12346,'Container','Renault','Renault',2,'Diesel')
insert into vehicle_details VALUES(3,12347,'Tipper','Mitsubishi','Mitsubhishi',2,'Diesel')
insert into vehicle_details VALUES(4,12348,'Truck','Hyundai','Hyundai',2,'Diesel')
insert into vehicle_details VALUES(5,12349,'Lorry','Toyota','Toyota',2,'Diesel')

SELECT * FROM vehicle_details

SELECT * FROM tbl_warehouse_activities
SELECT * FROM Vehicle_Details
SELECT * FROM Vehicle_Request_Details

insert into Vehicle_Request_Details VALUES(1,'Lorry',12345,'2017-01-01','18:0:00','Colombo','Malabe')

SELECT Stock_ID FROM tbl_stocks

UPDATE tbl_orders SET Full_Arrived = 1 WHERE Order_ID = 'ORLB1'
UPDATE tbl_orders SET Full_Arrived = 1 WHERE Order_ID = 'ORLC1'
UPDATE tbl_orders SET Full_Arrived = 1 WHERE Order_ID = 'ORPA1'
UPDATE tbl_orders SET Full_Arrived = 1 WHERE Order_ID = 'ORSB1'