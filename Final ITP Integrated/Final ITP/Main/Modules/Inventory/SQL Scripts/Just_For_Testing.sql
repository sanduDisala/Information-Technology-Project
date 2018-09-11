use Inventory_Management
go


insert into tbl_user values('INV001','Kumara.H','123456','Inventory Manager')
SELECT User_ID,Type FROM tbl_user WHERE Username = 'Kumara.H' AND Password = '123456'
select * from tbl_user
select * from tbl_orders
select * from tbl_stocks
select * from tbl_suppliers
select * from tbl_items
select * from tbl_warehouse_activities

SELECT Order_ID,Name,Item_Description,Ordered_Date,Quantity,Unit_Price,Full_Arrived FROM tbl_orders,tbl_items,tbl_suppliers WHERE tbl_items.Item_ID = tbl_orders.Item_ID AND tbl_suppliers.Supplier_ID = tbl_orders.Supplier_ID AND Order_ID = 1

update tbl_stocks set Remaining_Quantity = 500 where Stock_ID = 1

SELECT Stock_ID FROM tbl_stocks WHERE Item_ID = 1 AND Supplier_ID = 2

delete from tbl_stocks where Stock_ID = 1
SELECT SUM(Quantity) FROM tbl_orders WHERE Item_ID = 2 AND Supplier_ID = 1
DELETE FROM tbl_orders WHERE Order_ID = 1
UPDATE tbl_stocks SET Remaining_Quantity = 400 WHERE Stock_ID = 1
update tbl_orders set Full_Arrived = 0 where Order_ID = 3
select Order_ID from inserted
SELECT Supplier_ID FROM tbl_suppliers WHERE Name = 'LG' AND Origin = 'Japan'
SELECT Order_ID FROM tbl_orders WHERE (Item_ID = 2 AND Supplier_ID = 1 AND Full_Arrived = 0 AND Ordered_Date = '2017-08-25 01:42:00.000')
SELECT Stock_ID FROM tbl_stocks WHERE Item_ID = 2 AND Supplier_ID = 1 AND Remaining_Quantity = 50
UPDATE tbl_orders SET Quantity = 40,Full_Arrived = 0,Arrived_Date = '2017-08-23 09:32:00.000',Stock_ID = 1,,Supplier_ID = 2 WHERE Order_ID = 1 
UPDATE tbl_stocks SET Supplier_ID = 1,Remaining_Quantity = 20 WHERE Stock_ID = 1
UPDATE tbl_orders SET Quantity = 50,Arrived_Date = NULL,Full_Arrived = 0 WHERE Order_ID = 1
SELECT tbl_orders.Order_ID,tbl_items.Item_Description,tbl_orders.Quantity,tbl_suppliers.Name,tbl_orders.Ordered_Date,tbl_orders.Arrived_Date,tbl_orders.Unit_Price,tbl_orders.Full_Arrived FROM tbl_orders,tbl_items,tbl_suppliers WHERE tbl_items.Stock_ID = tbl_orders.Stock_ID AND tbl_suppliers.Supplier_ID = tbl_orders.Supplier_ID

UPDATE tbl_stocks SET Remaining_Quantity = 10 WHERE Stock_ID = 1
UPDATE tbl_orders SET Quantity = 40,Arrived_Date = NULL,Full_Arrived = 0 WHERE Order_ID = 1
DELETE FROM tbl_stocks WHERE Stock_ID = 1
SELECT tbl_orders.Order_ID,tbl_items.Item_Description,tbl_suppliers.Name,tbl_orders.Quantity,tbl_orders.Ordered_Date,tbl_orders.Arrived_Date,tbl_orders.Unit_Price,tbl_orders.Origin,tbl_orders.Full_Arrived FROM tbl_items,tbl_suppliers,tbl_orders WHERE tbl_items.Stock_ID = tbl_orders.Stock_ID AND tbl_suppliers.Supplier_ID = tbl_orders.Supplier_ID AND tbl_orders.Full_Arrived = 0
SELECT Stock_ID FROM tbl_items

DELETE FROM tbl_orders WHERE Order_ID = 1
SELECT * FROM tbl_orders
INSERT INTO tbl_orders(Order_ID,Stock_ID,Quantity,Supplier_ID,Ordered_Date,Unit_Price) VALUES(2,2,30,2,'2017-08-06 09:35:00.000',50)
--SELECT Order_ID FROM tbl_orders WHERE Stock_ID = 1 AND Supplier_ID = 1 AND Ordered_Date = '" + orderedDate + " " + orderedTime + "' AND Arrived_Date = '" + arrivedDate + " " + arrivedTime + "')
SELECT Order_ID FROM tbl_orders WHERE Stock_ID = 1 AND Supplier_ID = 1 AND Ordered_Date = '2017-08-06 21:35:00.000' AND Arrived_Date = '2017-08-19 02:45:00.000'
INSERT INTO tbl_stocks VALUES(1,1,30)

delete from tbl_stocks where Stock_ID=  1
UPDATE tbl_orders SET Arrived_Date = NULL WHERE Order_ID = 1 AND Ordered_Date LIKE '2017-08-06 9:35:'
UPDATE  tbl_orders SET Arrived_Status = 0 WHERE Order_ID = 1 
DELETE FROM tbl_stocks WHERE Stock_ID = 1
SELECT Order_ID,Stock_ID,Supplier_ID,Ordered_Date,Quantity,Unit_Price FROM tbl_orders

SELECT tbl_items.Item_Description,tbl_suppliers.Name,tbl_stocks.Remaining_Quantity FROM tbl_stocks,tbl_suppliers,tbl_items WHERE tbl_stocks.Stock_ID = tbl_items.Stock_ID AND tbl_stocks.Supplier_ID = tbl_suppliers.Supplier_ID


SELECT Order_ID FROM tbl_orders WHERE Stock_ID = 1 AND Supplier_ID = 1 AND Ordered_Date = '2017-08-06 21:35:00.000' AND Arrived_Date = '2017-08-19 01:31:00.000'
SELECT tbl_orders.Order_ID,tbl_items.Item_Description,tbl_suppliers.Name,tbl_orders.Quantity,tbl_orders.Ordered_Date,tbl_orders.Unit_Price FROM tbl_items,tbl_suppliers,tbl_orders WHERE tbl_orders.Stock_ID = tbl_items.Stock_ID AND tbl_suppliers.Supplier_ID = tbl_orders.Supplier_ID AND tbl_orders.Arrived_Date IS NOT NULL

SELECT * FROM tbl_orders WHERE Stock_ID = 1 AND Supplier_ID = 1 AND Ordered_Date = '2017-08-06 21:35:00.000' AND Arrived_Date IS NULL

SELECT * FROM tbl_orders WHERE Stock_ID = 1 AND Supplier_ID = 1 AND Ordered_Date = '2017-08-06 21:35:00.000' AND Arrived_Date = '2017-08-11 10:00:00.000'
SELECT COUNT(*) FROM tbl_suppliers WHERE Name = 'K10'
SELECT COUNT(*) FROM tbl_orders WHERE Order_ID = 3
SELECT Stock_ID FROM tbl_items WHERE Item_Description = 'Phone'

SELECT Supplier_ID FROM tbl_suppliers WHERE Name = 'k10'
SELECT Stock_ID FROM tbl_items WHERE Item_Description = 'Camera'

SELECT Name FROM tbl_supplier
SELECT Name FROM tbl_supplier

insert into tbl_suppliers values('S0001','Panasonic','Japan')
insert into tbl_suppliers values('S0002','LG','Malayasia')

insert into tbl_items values (1,'Camera')
insert into tbl_items values (2,'Screens')

insert into tbl_orders(Order_ID,Stock_ID,Quantity,Supplier_ID,Ordered_Date,Unit_Price) values (1,1,30,1,'06-Aug-17 9:35 PM',40)
delete from tbl_stocks where Stock_ID = 1

SELECT Order_ID FROM tbl_orders WHERE (Ordered_Date = '06-August-17 9:35 PM' AND Stock_ID = 1 AND Supplier_ID = 1 AND Arrived_Date IS NULL)
UPDATE tbl_orders SET Arrived_Date = '10-Aug-17 9:35 PM' WHERE Order_ID = 1

INSERT INTO tbl_stocks(Stock_ID,Supplier_ID,Remaining_Quantity) VALUES (1,1,20)
INSERT INTO tbl_stocks(Stock_ID,Order_ID,Supplier_ID,Ordered_Date,Total_Quantity,Remaining_Quantity,Unit_Price) VALUES (2,2,2,'06-Aug-17 9:35 AM',30,20,20)

SELECT * FROM tbl_stocks
WHERE Stock_ID = 1 AND Supplier_ID = 1 AND Ordered_Date = '2017-08-06 09:35:00.000' AND Arrived_Date IS NULL 

SELECT Stock_ID FROM tbl_items
WHERE Item_Description = 'Camera'

SELECT * FROM tbl_stock
WHERE Supplier_ID = ( SELECT Supplier_ID FROM tbl_supplier WHERE Name = 'Panasonic')

SELECT * FROM tbl_stock
WHERE Order_ID = ( SELECT Order_ID FROM tbl_order WHERE Ordered_Date = '2017-08-06 21:35:00.000') 

SELECT TOP 0 * FROM tbl_stock
SELECT * FROM tbl_stock
WHERE Order_ID IN (SELECT Order_ID FROM tbl_order WHERE Description = 'Camera')

--SELECT Ordered_Date FROM tbl_order WHERE    
delete from tbl_supplier where Supplier_ID = 1
delete from tbl_stock where Stock_ID = 1