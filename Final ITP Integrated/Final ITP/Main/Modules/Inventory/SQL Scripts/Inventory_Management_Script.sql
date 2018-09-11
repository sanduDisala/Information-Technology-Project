--USE Inventory_Management
--GO

CREATE TABLE tbl_suppliers(
  Supplier_ID		VARCHAR(10),
  Supplier_Name		VARCHAR(50) NOT NULL,
--  Dealer		VARCHAR(50) NOT NULL,  
  CONSTRAINT tbl_supplier_dealers_pk PRIMARY KEY(Supplier_ID)
);

CREATE TABLE tbl_supplier_brands(  
  Supplier_ID		VARCHAR(10),
  Brand			VARCHAR(50),
  
  CONSTRAINT tbl_supplier_pk PRIMARY KEY(Supplier_ID,Brand),
  CONSTRAINT tbl_supplier_fk FOREIGN KEY(Supplier_ID) REFERENCES tbl_suppliers	
);

CREATE TABLE tbl_items(
--	Item_ID				VARCHAR(10),
	Model				VARCHAR(50) NOT NULL,
	Supplier_ID			VARCHAR(10) NOT NULL,
	Brand				VARCHAR(50) NOT NULL,
    Unit_Price			INT NOT NULL,
	Threshold_Value		INT,
	Reordering_Amount	INT,
	Category			VARCHAR(50) NOT NULL,
	Type				VARCHAR(50) NOT NULL,
	
	CONSTRAINT tbl_items_pk PRIMARY KEY(Model),
	CONSTRAINT tbl_items_fk1 FOREIGN KEY(Supplier_ID) REFERENCES tbl_suppliers
);

/*CREATE TABLE tbl_inventory(
  Model				VARCHAR(50),
  Available_Quantity	INT,
  
  CONSTRAINT tbl_inventory_pk PRIMARY KEY(Model),
  CONSTRAINT tbl_inventory_fk FOREIGN KEY(Model) REFERENCES tbl_items
);*/

CREATE TABLE tbl_orders(
  Order_ID		VARCHAR(10),
  --Item_ID		VARCHAR(10) NOT NULL,
  --Quantity		INT NOT NULL,
  --Supplier_ID	VARCHAR(10) NOT NULL,
  --Origin		VARCHAR(50) NOT NULL,
  Ordered_Date	DATETIME NOT NULL,
--  Arrived_Date	DATETIME,
  Brand			VARCHAR(50) NOT NULL,
  --Unit_Price	INT NOT NULL,
  Full_Arrived	BIT NOT NULL DEFAULT(0),
  CONSTRAINT tbl_order_pk PRIMARY KEY(Order_ID),
  --CONSTRAINT tbl_order_fk_1 FOREIGN KEY(Item_ID) REFERENCES tbl_items,
  --CONSTRAINT tbl_order_fk_2 FOREIGN KEY(Supplier_ID) REFERENCES tbl_suppliers
);

CREATE TABLE tbl_ordered_Item_details(
  Item_ID		VARCHAR(10) NOT NULL,
  Order_ID		VARCHAR(10),
  Model			VARCHAR(50) NOT NULL,
  --Quantity		INT NOT NULL,
  Price			FLOAT NOT NULL,
  Available		BIT NOT NULL DEFAULT(0),
  
  CONSTRAINT tbl_ordered_Item_details_pk PRIMARY KEY(Item_ID),
  CONSTRAINT tbl_ordered_Item_details_fk1 FOREIGN KEY(Model) REFERENCES tbl_items,
  CONSTRAINT tbl_ordered_Item_details_fk2 FOREIGN KEY(Order_ID) REFERENCES tbl_orders
);

CREATE TABLE tbl_stocks (
  Stock_ID			VARCHAR(10),
  Model				VARCHAR(50) NOT NULL,
  Quantity			INT,
  --Supplier_ID		VARCHAR(10) NOT NULL,
  --Remaining_Quantity INT NOT NULL,  
  
  CONSTRAINT tbl_stock_pk PRIMARY KEY(Stock_ID),--,Model),
  --CONSTRAINT tbl_stock_fk_1 FOREIGN KEY(Supplier_ID) REFERENCES tbl_suppliers,
  CONSTRAINT tbl_stock_fk_2 FOREIGN KEY(Model) REFERENCES tbl_items
);

CREATE TABLE tbl_warehouse_activities(
  Activity_ID		VARCHAR(10),
  Request_No		INT NOT NULL,--VARCHAR(10) NOT NULL,
--  Supplier_ID		VARCHAR(10) NOT NULL,
  Vehicle_No		INT NOT NULL,
  Stock_ID			VARCHAR(10) NOT NULL,
  Operation			VARCHAR(3) NOT NULL,
  Operation_Date	DATETIME NOT NULL,
  
  CONSTRAINT tbl_warehouse_activities_pk PRIMARY KEY(Activity_ID),
  CONSTRAINT tbl_warehouse_activities_fk_1 FOREIGN KEY(Stock_ID) REFERENCES tbl_stocks,
  CONSTRAINT tbl_warehouse_activities_fk_2 FOREIGN KEY(Vehicle_No) REFERENCES Vehicle_Details,
  --CONSTRAINT tbl_warehouse_activities_fk_2 FOREIGN KEY(Supplier_ID) REFERENCES tbl_suppliers
  CONSTRAINT tbl_warehouse_activities_fk_3 FOREIGN KEY(Request_No) REFERENCES Vehicle_Request_Details
);

CREATE TABLE tbl_user(
  User_ID			VARCHAR(10),
  Username			VARCHAR(20),
  Password			VARCHAR(20),
  Type				VARCHAR(50),
  
  CONSTRAINT tbl_user_pk PRIMARY KEY(User_ID)	
); 

drop table tbl_warehouse_activities
drop table Vehicle_Request_Details
drop table tbl_stocks
drop table tbl_ordered_Item_details
drop table tbl_orders
--drop table tbl_inventory
drop table tbl_items
drop table tbl_supplier_brands
drop table tbl_suppliers