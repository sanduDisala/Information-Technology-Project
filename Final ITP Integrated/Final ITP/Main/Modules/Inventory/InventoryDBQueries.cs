using System;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace Main.Modules.Inventory
{
    class DBQueries
    {
        DBConnect Getter = new DBConnect();

        public string checkSupplierID(string supplierName, string origin)
        {
            DataSet verifiedSupplierDetails = Getter.GetFromDB("SELECT Supplier_ID FROM tbl_suppliers WHERE Name = '" + supplierName + "' AND Origin = '" + origin + "'");
            string verifiedSupplierID = null;

            if ((verifiedSupplierDetails == null) || (verifiedSupplierDetails.Tables[0].Rows.Count == 0))
            {
                verifiedSupplierDetails = null;
            }
            else
            {
                verifiedSupplierID = verifiedSupplierDetails.Tables[0].Rows[0][0].ToString();
            }

            return verifiedSupplierID;
        }

        public string checkItemID(string description)
        {
            DataSet verifiedItemDetails = Getter.GetFromDB("SELECT Item_ID FROM tbl_items WHERE Item_Description = '" + description + "'");
            string verifiedItemID = null;

            if (verifiedItemDetails.Tables[0].Rows.Count == 0)
            {
                verifiedItemID = null;
            }
            else
            {
                verifiedItemID = verifiedItemDetails.Tables[0].Rows[0][0].ToString();
            }
            return verifiedItemID;
        }

        //public string checkIncompleteOrderID(string itemID, /*string supplierID,*/string orderedDate, string orderedTime)
        //{
        //    MessageBox.Show(itemID + " " + /*supplierID + " " +*/ orderedDate + " " + orderedTime, "checkIncompleteOrderID");
        //    DataSet incompleteOrderDetails = Getter.GetFromDB("SELECT Order_ID FROM tbl_orders WHERE (Item_ID = '" + itemID /*+ "AND Supplier_ID = " + supplierID*/ + "' AND Full_Arrived = 0 AND Ordered_Date = '" + orderedDate + " " + orderedTime + "')");
        //    string incompleteOrderID = null;

        //    if (incompleteOrderDetails.Tables[0].Rows.Count == 0)
        //    {
        //        incompleteOrderID = null;
        //    }
        //    else
        //    {
        //        incompleteOrderID = incompleteOrderDetails.Tables[0].Rows[0][0].ToString();
        //    }
        //    return incompleteOrderID;
        //}

        //public string checkCompleteOrderID(string itemID/*, string supplierID, string arrivedDate, string arrivedTime*/, string orderedDate, string orderedTime)
        //{
        //    DataSet completedOrderIDDetails = Getter.GetFromDB("SELECT Order_ID FROM tbl_orders WHERE Item_ID = '" + itemID /*+ " AND Supplier_ID = " + supplierID */+ "' AND Full_Arrived = 1 AND Ordered_Date = '" + orderedDate + " " + orderedTime + "'");
        //    //DataSet completedOrderIDDetails = Getter.GetFromDB("SELECT Order_ID FROM tbl_orders WHERE Stock_ID = " + stockID + " AND Supplier_ID = " + supplierID + " AND Ordered_Date = '" + orderedDate + " " + orderedTime + "' AND Arrived_Date = '" + arrivedDate + " " + arrivedTime + "'");
        //    string completedOrderID;
        //    if (completedOrderIDDetails.Tables[0].Rows.Count == 0)
        //    {
        //        completedOrderID = null;
        //    }
        //    else
        //    {
        //        completedOrderID = completedOrderIDDetails.Tables[0].Rows[0][0].ToString(); ;
        //    }
        //    //MessageBox.Show(completedOrderID, "COmpleted order id");
        //    return completedOrderID;
        //}

        //public DataSet getIncompleteOrders() {
        //    DataSet IncompleteOrders = Getter.GetFromDB("SELECT tbl_orders.Order_ID,tbl_items.Model,tbl_items.Brand,tbl_suppliers.Name,tbl_orders.Quantity,tbl_orders.Ordered_Date,tbl_orders.Arrived_Date,tbl_orders.Unit_Price,tbl_orders.Full_Arrived FROM tbl_items,tbl_suppliers,tbl_orders WHERE tbl_items.Stock_ID = tbl_orders.Stock_ID AND tbl_suppliers.Supplier_ID = tbl_orders.Supplier_ID AND tbl_orders.Full_Arrived = 0");// ("SELECT * FROM tbl_orders WHERE Full_Arrived = 0");
        //    return IncompleteOrders;
        //}

        //public DataSet getOrderDetails(string brand,string dealer,string category,string type) {
        //    DataSet orderDetails = Getter.GetFromDB("SELECT * FROM tbl_orders");
        //    return orderDetails;

        //}

        public DataSet getAvailableOrderItemDetails(string brand, string dealer, string type, string category)
        {
            string whereClause = null;
            DataSet data = null;

            if (brand != null)
            {
                whereClause = whereClause + " AND i.Brand = '" + brand + "'";
            }

            if (dealer != null)
            {
                string dealerID = checkDealerID(dealer);
                whereClause = whereClause + " AND i.Supplier_ID = '" + dealerID + "'";
            }

            if (category != null)
            {
                whereClause = whereClause + " AND i.Category = '" + category + "'";
            }

            if (type != null)
            {
                whereClause = whereClause + " AND i.Type = '" + type + "'";
            }

            data = Getter.GetFromDB("SELECT i.Model,i.Brand,i.Category,i.Type,i.Unit_Price FROM tbl_items as i,tbl_supplier_details as s WHERE s.Supplier_ID = i.Supplier_ID " + whereClause);
            //            data = Getter.GetFromDB("SELECT i.Model,i.Brand,i.Category,i.Type,i.Unit_Price FROM tbl_items as i,tbl_supplier_brands as s WHERE s.Supplier_ID = i.Supplier_ID AND s.Brand = i.Brand" + whereClause);
            return data;
        }

        public DataSet getOrderDetails(string brand, string dealer, string type, string category)
        {
            DataSet data = null;
            string whereClause = null;

            if (brand != null)
            {
                whereClause = "WHERE Brand = '" + brand + "'";
            }
            else
            {
                DataSet Brand = null;
                if (dealer != null)
                {
                    string supplierID = Getter.GetFromDB("SELECT Supplier_ID FROM tbl_suppliers WHERE Supplier_Name = '" + dealer + "'").Tables[0].Rows[0][0].ToString();
                    Brand = Getter.GetFromDB("SELECT DISTINCT Brand FROM tbl_supplier_brands WHERE Supplier_ID = '" + supplierID + "'");

                    for (int i = 0; i < Brand.Tables[0].Rows.Count; i++)
                    {
                        brand = brand + "'" + Brand.Tables[0].Rows[i][0].ToString() + "',";
                    }

                    whereClause = "WHERE Brand IN (" + brand.Substring(0, brand.Length - 1) + ")";
                    MessageBox.Show(whereClause, "whereclause");
                }
                else
                {
                    if (category != null)
                    {
                        if (type != null)
                        {
                            Brand = Getter.GetFromDB("SELECT DISTINCT Brand FROM tbl_items WHERE Category = '" + category + "' AND Type = '" + type + "'");
                        }
                        else
                        {
                            Brand = Getter.GetFromDB("SELECT DISTINCT Brand FROM tbl_items WHERE Category = '" + category + "'");
                        }
                    }
                    else
                    {
                        if (type != null)
                        {
                            Brand = Getter.GetFromDB("SELECT DISTINCT Brand FROM tbl_items WHERE Type = '" + type + "'");
                        }
                    }

                    if (type != null || category != null)
                    {
                        for (int i = 0; i < Brand.Tables[0].Rows.Count; i++)
                        {
                            brand = brand + "'" + Brand.Tables[0].Rows[i][0].ToString() + "',";
                        }
                        whereClause = "WHERE Brand IN (" + brand.Substring(0, brand.Length - 1) + ")";
                        MessageBox.Show(whereClause, "whereclause");
                    }
                }
            }

            data = Getter.GetFromDB("SELECT Order_ID,Brand,Ordered_Date FROM tbl_orders " + whereClause);
            return data;
        }

        public DataSet getOrderIDList(string model, int isAvailable)
        {
            DataSet orderIDList;
            if ((isAvailable >= 0) && (isAvailable < 2))
            {
                orderIDList = Getter.GetFromDB("SELECT DISTINCT Order_ID FROM tbl_ordered_Item_details WHERE Model = '" + model + "' AND Available = " + isAvailable);
            }
            else
            {
                orderIDList = Getter.GetFromDB("SELECT DISTINCT Order_ID FROM tbl_ordered_Item_details WHERE Model = '" + model + "'");
            }
            //Getter.GetFromDB("SELECT Order_ID FROM tbl_orders WHERE Item_ID = '" + itemID + "'");
            return orderIDList;
        }

        public DataSet getStockIDList()
        {
            DataSet stockIDList = new DBConnect().GetFromDB("SELECT Stock_ID FROM tbl_stocks");
            return stockIDList;
        }

        public DataSet getVehicleTypeList()
        {
            DataSet vehicleType = Getter.GetFromDB("SELECT DISTINCT VehicleType FROM Vehicle_Details");
            return vehicleType;
        }

        public DataSet getVehicleArrivalList()
        {
            DataSet arrivalList = Getter.GetFromDB("SELECT DISTINCT PlaceOfArrival FROM Vehicle_Request_Details");
            return arrivalList;
        }

        public DataSet getVehicleDepartureList()
        {
            DataSet departureList = Getter.GetFromDB("SELECT DISTINCT PlaceOfDepature FROM Vehicle_Request_Details");
            return departureList;
        }

        public DataSet getVehicleRequestDateList()
        {
            DataSet requestDateList = Getter.GetFromDB("SELECT DISTINCT RequestDate FROM Vehicle_Request_Details");
            return requestDateList;
        }

        public DataSet getWarehouseActivities()
        {
            DataSet WarehouseData = Getter.GetFromDB("SELECT * FROM tbl_warehouse_activities");
            return WarehouseData;
        }

        public DataSet getModelList(string orderID)
        {
            DataSet model = Getter.GetFromDB("SELECT DISTINCT Model FROM tbl_ordered_Item_details WHERE Order_ID = '" + orderID + "'");
            return model;
        }

        public DataSet getOrderAlertStockDetails()
        {
            DataSet reorderAlertDetails = Getter.GetFromDB("SELECT i.Model,i.Threshold_Value,s.Quantity,i.Reordering_Amount FROM tbl_items i,tbl_stocks s WHERE i.Model = s.Model AND s.Quantity < i.Threshold_Value");
            return reorderAlertDetails;
        }

        //public DataSet getOrderAlertOrderDetails(DataSet suspiciousModels) {
        //    DataSet reorderingDetails = null;
            
        //    for(int i=0;i<suspiciousModels.Tables[0].Rows.Count;i++){
        //        int unavailableAmount = getAvailableOrUnavailableItemAmount(suspiciousModels.Tables[0].Rows[i].ToString(), 0, null);
        //        int thresholdValue = Convert.ToInt32(Getter.GetFromDB("SELECT Threshold_Value FROM tbl_items WHERE Model = '" + suspiciousModels.Tables[0].Rows[i].ToString() + "'"));

        //        if (thresholdValue > unavailableAmount) {
        //            DataRow row = reorderingDetails.Tables[0].NewRow();
        //            row["Model"] = suspiciousModels.Tables[0].Rows[i].ToString();
        //            row["Reorder Amount"] = (thresholdValue - unavailableAmount).ToString();
        //            reorderingDetails.Tables[0].Rows.Add(row);
        //        }
        //    }
        //    return reorderingDetails;
        //}

        public DataSet getModelCountDetails(string orderID)
        {
            DataSet model = getModelList(orderID);
            //MessageBox.Show(model.Tables[0].Rows.Count.ToString(),"count");

            DataSet modelCountDetails = new DataSet();
            DataTable modelCountDataTable = new DataTable("ModelCountTable");
            modelCountDataTable.Columns.Add(new DataColumn("Model", typeof(string)));
            modelCountDataTable.Columns.Add(new DataColumn("Count", typeof(string)));

            for (int i = 0; i < model.Tables[0].Rows.Count; i++)
            {
                DataRow dr = modelCountDataTable.NewRow();
                dr[0] = model.Tables[0].Rows[i][0];
                string modelCount = Getter.GetFromDB("SELECT COUNT(*) FROM tbl_ordered_Item_details WHERE Model = '" + model.Tables[0].Rows[i][0].ToString() + "' AND Order_ID = '" + orderID + "'").Tables[0].Rows[0][0].ToString();
                dr[1] = modelCount;
                modelCountDataTable.Rows.Add(dr);
            }

            //MessageBox.Show(modelCountDataTable.Rows.Count.ToString(), "Datatablerowcount");
            modelCountDetails.Tables.Add(modelCountDataTable);
            //MessageBox.Show(modelCountDetails.Tables[0].Rows.Count.ToString(), "modelcountdetailsrowcount");
            return modelCountDetails;
        }

        public DataSet getArrivedStockDetails(string brand, string dealer, string type, string category, DataSet orderID, string model, int available, string fullArrived)
        {
            DataSet ArrivedStockDetails = null;
            string searchWhere = null, availableClause = null, orderClause = null, modelClause = null, groupByOrderClause = null;
            if (brand != null)
            {
                searchWhere = searchWhere + " AND i.Brand = '" + brand + "'";
            }

            if (dealer != null)
            {
                string dealerID = checkDealerID(dealer);
                searchWhere = searchWhere + " AND i.Supplier_ID = '" + dealerID + "'";
            }

            if (category != null)
            {
                searchWhere = searchWhere + " AND i.Category = '" + category + "'";
            }

            if (type != null)
            {
                searchWhere = searchWhere + " AND i.Type = '" + type + "'";
            }
            
            if (orderID != null)
            {
                for (int i = 0; i < orderID.Tables[0].Rows.Count; i++)
                {
                    orderClause = orderClause + "'" + orderID.Tables[0].Rows[i][0].ToString() + "',";
                }
                MessageBox.Show(orderClause, "IDList");
                orderClause = "AND oi.Order_ID IN(" + orderClause.Substring(0, (orderClause.Length - 1)) + ")";
                groupByOrderClause = "o.Order_ID,";
                MessageBox.Show(orderClause, "IDList");

                //AND oi.Order_ID IN(" + IDList + ")
            }

            if (model != null)
            {
                modelClause = "AND oi.Model = '" + model + "'";
            }

            if ((available >= 0) && (available < 2))
            {
                availableClause = "AND oi.Available = " + available;
            }
            string sql = "SELECT oi.Model,i.Brand,i.Category,i.Type,COUNT(Item_ID) AS 'Count' FROM tbl_ordered_Item_details oi,tbl_orders o,tbl_items i WHERE o.Order_ID = oi.Order_ID " + availableClause + " AND o.Full_Arrived = " + fullArrived + " " + searchWhere + " AND i.Model = oi.Model " + orderClause + modelClause + " GROUP BY oi.Model,i.Brand,i.Category,i.Type,oi.Available,o.Full_Arrived HAVING COUNT(Item_ID) > 0";
            MessageBox.Show(sql);
            ArrivedStockDetails = Getter.GetFromDB("SELECT oi.Model,i.Brand,i.Category,i.Type,COUNT(Item_ID) AS 'Count' FROM tbl_ordered_Item_details oi,tbl_orders o,tbl_items i WHERE o.Order_ID = oi.Order_ID " + availableClause + " AND o.Full_Arrived = " + fullArrived + " " + searchWhere + " AND i.Model = oi.Model " + orderClause + modelClause + " GROUP BY " + groupByOrderClause + "oi.Model,i.Brand,i.Category,i.Type,oi.Available,o.Full_Arrived HAVING COUNT(Item_ID) > 0");
            return ArrivedStockDetails;
        }
        /// <summary>
        /// //////////
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="dealer"></param>
        /// <param name="category"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        //public DataSet checkBrand(string brand, string dealer, string category, string type) {
        //    DataSet Brand = null;
        //    string whereClause = "WHERE ",dealerID = null;
        //    int count = 0;

        //    if (brand != null) {
        //        whereClause = whereClause + "Brand = '" + brand + "'";
        //        count++;
        //    }
        //    else{
        //        if (dealer != null)
        //        {
        //            dealerID = new DBConnect().GetFromDB("SELECT Supplier_ID FROM tbl_suppliers WHERE Supplier_Name = '" + dealer + "'").Tables[0].Rows[0][0].ToString();
        //            string itemBrand = new DBConnect().GetFromDB("SELECT Brand FROM tbl_supplier_brands WHERE Supplier_ID = '" + dealerID + "'").Tables[0].Rows[0][0].ToString();
        //            whereClause = whereClause + "Brand = '" + itemBrand + "'";
        //        }
        //        else {
        //            DataSet dealerIDList;
        //            if (category != null) {
        //                dealerIDList = new DBConnect().GetFromDB("SELECT Supplier_ID FROM tbl_items WHERE Category = '" + category + "'");

        //                for(int i=0;i<dealerIDList.Tables[0].Rows.Count;i++){                        
        //                  //  whereClause = whereClause                        
        //                }

        //            }
        //        }
        //    }
        //    return Brand;
        //}

        /// <summary>
        /// //////////////////
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="dealer"></param>
        /// <param name="category"></param>
        /// <param name="type"></param>
        /// <returns></returns>

        public DataSet checkModel(string brand, string dealer, string category, string type)
        {
            int count = 0;
            string whereClause = "WHERE ";
            DataSet model;

            if (brand != null)
            {
                whereClause = whereClause + "Brand = '" + brand + "'";
                count++;
            }

            if (dealer != null)
            {
                string dealerID = checkDealerID(dealer);
                if (count > 0)
                {
                    whereClause = whereClause + " AND Supplier_ID = '" + dealerID + "'";
                }
                else
                {
                    whereClause = whereClause + "Supplier_ID = '" + dealerID + "'";
                }
                count++;
            }

            if (category != null)
            {
                if (count > 0)
                {
                    whereClause = whereClause + " AND Category = '" + category + "'";
                }
                else
                {
                    whereClause = whereClause + "Category = '" + category + "'";
                }
                count++;
            }

            if (type != null)
            {
                if (count > 0)
                {
                    whereClause = whereClause + " AND Type = '" + type + "'";
                }
                else
                {
                    whereClause = whereClause + "Type = '" + type + "'";
                }
                count++;
            }

            MessageBox.Show(whereClause, "whereclausemodel");
            if (whereClause == "WHERE ")
            {
                model = new DBConnect().GetFromDB("SELECT Model FROM tbl_items");
            }
            else
            {
                MessageBox.Show("SELECT Model FROM tbl_items " + whereClause, "ModelSQL");
                model = new DBConnect().GetFromDB("SELECT Model FROM tbl_items " + whereClause);
            }

            return model;
        }

        public string checkDealerID(string dealer)
        {
            string DealerID = Getter.GetFromDB("SELECT Supplier_ID from tbl_suppliers WHERE Supplier_Name = '" + dealer + "'").Tables[0].Rows[0][0].ToString();
            return DealerID;
        }

        public DataSet getStockDetails(string brand, string dealer, string type, string category)
        {

            MessageBox.Show(brand + dealer + type + category, "parameters");

            string whereClause = null;
            DataSet StockDetails = null;
            DataSet model = null;
            if (brand == null)
            {
                if (dealer == null)
                {
                    if (type == null)
                    {
                        if (category == null)
                        {
                            model = null;
                        }
                        else
                        {
                            model = checkModel(brand, dealer, category, type);
                        }
                    }
                    else
                    {
                        model = checkModel(brand, dealer, category, type);
                    }
                }
                else
                {
                    model = checkModel(brand, dealer, category, type);
                }
            }
            else
            {
                model = checkModel(brand, dealer, category, type);
            }


            if (model == null)
            {
                StockDetails = Getter.GetFromDB("SELECT tbl_stocks.Stock_ID,tbl_stocks.Model,tbl_items.Brand,tbl_stocks.Quantity FROM tbl_stocks,tbl_items WHERE tbl_stocks.Model = tbl_items.Model");
                //Getter.GetFromDB("SELECT tbl_items.Item_Description,tbl_suppliers.Name,tbl_stocks.Remaining_Quantity FROM tbl_stocks,tbl_suppliers,tbl_items WHERE tbl_stocks.Item_ID = tbl_items.Item_ID AND tbl_items.Supplier_ID = tbl_suppliers.Supplier_ID");// ("SELECT tbl_items.Item_Description,tbl_suppliers.Name,tbl_stocks.Remaining_Quantity FROM tbl_stocks,tbl_suppliers,tbl_items WHERE tbl_stocks.Item_ID = tbl_items.Item_ID AND tbl_stocks.Supplier_ID = tbl_suppliers.Supplier_ID");            
            }
            else
            {
                MessageBox.Show(model.Tables[0].Rows.Count.ToString(), "model");
                //MessageBox.Show(model.Tables[0].Rows.Count.ToString() + " " + String.Join(" AND ",mode

                for (int i = 0; i < model.Tables[0].Rows.Count; i++)
                {
                    whereClause = whereClause + "'" + model.Tables[0].Rows[i][0].ToString() + "',";///*" AND " +*/ String.Join(" AND ", model.Tables[0].Rows[i][0].ToString());                    
                }

                MessageBox.Show(whereClause, "whereClause");

                StockDetails = Getter.GetFromDB("SELECT tbl_stocks.Stock_ID,tbl_stocks.Model,tbl_items.Brand,tbl_stocks.Quantity FROM tbl_stocks,tbl_items WHERE tbl_stocks.Model = tbl_items.Model AND tbl_stocks.Model IN (" + whereClause.Substring(0, whereClause.Length - 1) + ")");
                MessageBox.Show("SELECT tbl_stocks.Stock_ID,tbl_stocks.Model,tbl_items.Brand,tbl_stocks.Quantity FROM tbl_stocks,tbl_items WHERE tbl_stocks.Model = tbl_items.Model AND tbl_stocks.Model IN (" + whereClause.Substring(0, whereClause.Length - 1) + ")", "getstockdetailssql");
            }
            return StockDetails;
        }

        public DataSet getWarehouseRequestDetails(string vehicleType, string arrival, string departure, string requestDate)
        {
            string whereClause = null;

            if (vehicleType != null)
            {
                whereClause = whereClause + "WHERE Type = '" + vehicleType + "'";
            }

            if (arrival != null)
            {
                if (whereClause == null)
                {
                    whereClause = whereClause + "WHERE PlaceOfArrival = '" + arrival + "'";
                }
                else
                {
                    whereClause = whereClause + " AND PlaceOfArrival = '" + arrival + "'";
                }
            }

            if (departure != null)
            {
                if (whereClause == null)
                {
                    whereClause = whereClause + "WHERE PlaceOfDepature = '" + departure + "'";
                }
                else
                {
                    whereClause = whereClause + " AND PlaceOfDepature = '" + departure + "'";
                }
            }

            if (requestDate != null)
            {
                if (whereClause == null)
                {
                    whereClause = whereClause + "WHERE RequestDate = '" + requestDate + "'";
                }
                else
                {
                    whereClause = whereClause + " AND RequestDate = '" + requestDate + "'";
                }
            }

            MessageBox.Show("SELECT RequestNo AS 'Request No',Type AS 'Vehicle Type',RegistrationNo AS 'Registration No',RequestDate AS 'Request Date',RequestTime AS 'Request Time',PlaceOfArrival AS 'Arrival',PlaceOfDepature AS 'Departure' FROM Vehicle_Request_Details " + whereClause, "SQL");

            DataSet WarehehouseRequestDetails = Getter.GetFromDB("SELECT RequestNo AS 'Request No',Type AS 'Vehicle Type',RegistrationNo AS 'Registration No',RequestDate AS 'Request Date',RequestTime AS 'Request Time',PlaceOfArrival AS 'Arrival',PlaceOfDepature AS 'Departure' FROM Vehicle_Request_Details " + whereClause);
            return WarehehouseRequestDetails;
        }
        public DataSet getVehicleDetails()
        {
            DataSet VehicleDetails = Getter.GetFromDB("SELECT * FROM vehicle_details");
            return VehicleDetails;
        }

        //public DataSet getOrderDetails() {
        //    DataSet orderDetails = Getter.GetFromDB("SELECT tbl_orders.Order_ID,tbl_items.Item_Description,tbl_orders.Quantity,tbl_suppliers.Name,tbl_orders.Ordered_Date,tbl_orders.Arrived_Date,tbl_orders.Full_Arrived FROM tbl_orders,tbl_items,tbl_suppliers WHERE tbl_items.Item_ID = tbl_orders.Item_ID AND tbl_items.Supplier_ID = tbl_suppliers.Supplier_ID");
        //    return orderDetails;
        //}

        //public DataSet getAllUserDetails()
        //{
        //    DataSet allUserDetails = Getter.GetFromDB("SELECT * FROM tbl_user");
        //    return allUserDetails;
        //}

        //public DataSet getUserDetails(string username, string password)
        //{
        //    DataSet userID = Getter.GetFromDB("SELECT User_ID,Type FROM tbl_user WHERE Username = '" + username + "' AND Password = '" + password + "'");
        //    return userID;
        //}

        public string generateOrderID(string brand, string model)
        {
            DataSet data;
            data = Getter.GetFromDB("SELECT COUNT(*) FROM tbl_orders");
            string OrderCount = (Convert.ToInt32(data.Tables[0].Rows[0][0].ToString()) + 1).ToString();

            //data = Getter.GetFromDB("SELECT Supplier_ID FROM tbl_supplier_brands WHERE Brand = '" + brand + "'");// ("SELECT Supplier_ID FROM tbl_suppliers WHERE Supplier_Name = '" + supplierName + "'");
            //string SupplierID = data.Tables[0].Rows[0][0].ToString();

            //data = Getter.GetFromDB("SELECT Item_ID FROM tbl_items WHERE Dealer_ID = '" + SupplierID + "' AND Model = '" + model + "'");
            //string ItemID = data.Tables[0].Rows[0][0].ToString();

            string OrderID = "OR" + brand.Substring(0, 1) + model.Substring(0, 1) + OrderCount;//SupplierID.Substring(0,1) + SupplierID.Substring(SupplierID.Length - 1,1) + /*ItemID.Substring(1,1) + */OrderCount;
            return OrderID;
        }

        public /*string*/ int generateActivityNo/*ID*/()
        {
            int/*string*/ count = Convert.ToInt32(Getter.GetFromDB("SELECT COUNT(*) FROM tbl_warehouse_activities").Tables[0].Rows[0][0].ToString());
            //string activityID = "ACC" + count;
            return count;// activityID;
        }

        //public int getOrderQuantity(string itemID, string supplierID)
        //{
        //    DataSet OrderStockQuantity = Getter.GetFromDB("SELECT SUM(Quantity) FROM tbl_orders WHERE Item_ID = '" + itemID + "'");// AND Supplier_ID = " + supplierID);
        //    int orderStockQuantity = 0;
        //    if (OrderStockQuantity != null)
        //    {
        //        orderStockQuantity = Convert.ToInt32(OrderStockQuantity.Tables[0].Rows[0][0]);
        //    }
        //    return orderStockQuantity;
        //}

        //private int getCurrentOrderModelQuantity(string orderID,string model) { 
        //    DataSet CurrentQuantity = 
        //}

        //public int getOrderQuantity(string orderID)
        //{
        //    DataSet OrderStockQuantity = Getter.GetFromDB("SELECT Quantity FROM tbl_orders WHERE Order_ID = '" + orderID + "'");
        //    int orderStockQuantity = 0;
        //    if (OrderStockQuantity != null)
        //    {
        //        orderStockQuantity = Convert.ToInt32(OrderStockQuantity.Tables[0].Rows[0][0]);
        //    }
        //    return orderStockQuantity;
        //}

        //public int getOrderCount(string orderID)
        //{
        //    DataSet OrderCount = Getter.GetFromDB("SELECT COUNT(*) FROM tbl_orders WHERE Order_ID = " + orderID);
        //    int orderCount = 0;
        //    if (OrderCount != null)
        //    {
        //        orderCount = Convert.ToInt32(OrderCount.Tables[0].Rows[0][0]);
        //    }
        //    return orderCount;
        //}

        //public int getStockQuantity(string stockID)
        //{
        //    DataSet StockQuantity = Getter.GetFromDB("SELECT Remaining_Quantity FROM tbl_stocks WHERE Stock_ID = '" + stockID + "'");
        //    int stockQuantity = 0;
        //    if (StockQuantity != null)
        //    {
        //        stockQuantity = Convert.ToInt32(StockQuantity.Tables[0].Rows[0][0]);
        //    }
        //    return stockQuantity;
        //}

        public string generateStockID(string item_category, string model)
        {
            string[] tokens = item_category.Split(' ');
            string StockID = "ST" + model.Substring(0, 1) + model.Substring(2, 2);

            foreach (string letter in tokens)
            {
                StockID = StockID + letter.Substring(0, 1).ToUpper();
            }

            return StockID;
        }

        //public string getItemCategory(string model)
        //{
        //    string itemCategory = Getter.GetFromDB("SELECT Category FROM tbl_items WHERE Model = '" + model + "'").Tables[0].Rows[0][0].ToString();
        //    return itemCategory;
        //}

        public DataSet getBrandList()
        {
            DataSet brandList = Getter.GetFromDB("SELECT DISTINCT Brand FROM tbl_items");
            return brandList;
        }

        public DataSet getDealerList()
        {
            DataSet dealersList = Getter.GetFromDB("SELECT Supplier_Name FROM tbl_suppliers");
            return dealersList;
        }

        public DataSet getItemTypeList()
        {
            DataSet itemList = Getter.GetFromDB("SELECT DISTINCT Type FROM tbl_items");
            return itemList;
        }

        public DataSet getItemCategoryList()
        {
            DataSet categoryList = Getter.GetFromDB("SELECT DISTINCT Category FROM tbl_items");
            return categoryList;
        }

        public DataSet getVehicleArrivalDepartureAndType(string vehicleID)
        {
            DataSet vehicleDetails = Getter.GetFromDB("SELECT Type,PlaceOfArrival,PlaceOfDepature FROM Vehicle_Request_Details WHERE RegistrationNo = '" + vehicleID + "'");
            return vehicleDetails;
        }

        public DataSet getStockChartData()
        {
            DataSet stockChartData = Getter.GetFromDB("SELECT i.Type,SUM(s.Quantity) AS 'Amount' FROM tbl_items i,tbl_stocks s WHERE i.Model = s.Model GROUP BY i.Type HAVING SUM(s.Quantity) > 0");
            return stockChartData;
        }

        public DataSet getOrderChartData()
        {
            DataSet orderChartData = Getter.GetFromDB("SELECT CONVERT(DATE,o.Ordered_Date) AS 'Ordered Date',COUNT(oi.Order_ID) 'Amount' FROM tbl_ordered_Item_details oi,tbl_orders o WHERE oi.Order_ID = o.Order_ID AND (DATEPART(DAY,GETDATE()) - 6) <= DATEPART(DAY,o.Ordered_Date) AND DATEPART(DAY,o.Ordered_Date) <= (DATEPART(DAY,GETDATE())) GROUP BY o.Ordered_Date HAVING COUNT(oi.Order_ID) > 0");
            return orderChartData;
        }

        public DataSet getWarehouseChartData()
        {
            DataSet warehouseChartData = Getter.GetFromDB("SELECT Operation_Date,COUNT(*) AS 'Amount' FROM tbl_warehouse_activities GROUP BY Operation_Date HAVING COUNT(*) > 0");
            return warehouseChartData;
        }

        //public void setStockQuantity(string stockID, int quantity)
        //{
        //    Getter.SendToDB("UPDATE tbl_stocks SET Remaining_Quantity = " + quantity + " WHERE Stock_ID = '" + stockID + "'");
        //}

        //public void setOrderQuantity(string orderID, int quantity)
        //{
        //    Getter.SendToDB("Update tbl_orders SET Quantity = " + quantity + " WHERE Order_Id = '" + orderID + "'");
        //}

        //public DataSet searchOrderDetails(string supplierName, string description, string origin)
        //{
        //    string supplierID = checkSupplierID(supplierName, origin);
        //    string itemID = checkItemID(description);
        //    DataSet OrderDetails = null;
        //    if (itemID != null)
        //    {
        //        if (supplierID != null)
        //        {  //SELECT Order_ID,Name,Item_Description,Ordered_Date,Quantity,Unit_Price,Full_Arrived FROM tbl_orders,tbl_items,tbl_suppliers WHERE tbl_items.Item_ID = tbl_orders.Item_ID AND tbl_suppliers.Supplier_ID = tbl_orders.Supplier_ID AND Order_ID = 1
        //            OrderDetails = Getter.GetFromDB("SELECT Order_ID,Name,Item_Description,Ordered_Date,Quantity,Unit_Price,Full_Arrived FROM tbl_orders,tbl_items,tbl_suppliers WHERE tbl_items.Item_ID = tbl_orders.Item_ID AND tbl_suppliers.Supplier_ID = tbl_orders.Supplier_ID AND Item_ID = " + itemID + "AND Supplier_ID = " + supplierID);
        //        }
        //        else
        //        {
        //            OrderDetails = Getter.GetFromDB("SELECT Order_ID,Name,Item_Description,Ordered_Date,Quantity,Unit_Price,Full_Arrived FROM tbl_orders,tbl_items,tbl_suppliers WHERE tbl_items.Item_ID = tbl_orders.Item_ID AND tbl_suppliers.Supplier_ID = tbl_orders.Supplier_ID AND Item_ID = " + itemID);
        //        }
        //    }
        //    else
        //    {
        //        if (supplierID != null)
        //        {
        //            OrderDetails = Getter.GetFromDB("SELECT Order_ID,Name,Item_Description,Ordered_Date,Quantity,Unit_Price,Full_Arrived FROM tbl_orders,tbl_items,tbl_suppliers WHERE tbl_items.Item_ID = tbl_orders.Item_ID AND tbl_suppliers.Supplier_ID = tbl_orders.Supplier_ID AND Supplier_ID = " + supplierID);
        //        }
        //        else
        //        {
        //            OrderDetails = null;
        //        }
        //    }
        //    return OrderDetails;
        //}

        //public DataSet searchStockDetails(string description, string supplierName, string origin)
        //{
        //    string supplierID = checkSupplierID(supplierName, origin);
        //    string itemID = checkItemID(description);
        //    DataSet ArrivedStockDetails = null;
        //    if (itemID != null)
        //    {
        //        if (supplierID != null)
        //        {
        //            ArrivedStockDetails = Getter.GetFromDB("SELECT * FROM tbl_stocks WHERE Item_ID = " + itemID + "AND Supplier_ID = " + supplierID);
        //        }
        //        else
        //        {
        //            ArrivedStockDetails = Getter.GetFromDB("SELECT * FROM tbl_stocks WHERE Item_ID = " + itemID);
        //        }
        //    }
        //    else
        //    {
        //        if (supplierID != null)
        //        {
        //            ArrivedStockDetails = Getter.GetFromDB("SELECT * FROM tbl_stocks WHERE Supplier_ID = " + supplierID);
        //        }
        //        else
        //        {
        //            ArrivedStockDetails = null;
        //        }
        //    }
        //    return ArrivedStockDetails;
        //}

        //public int checkOrderStockQuantity(string itemID, string supplierID, int quantity, string orderID)
        //{
        //    int quantityResult;
        //    int OrderStockQuantity;

        //    if (orderID != null)
        //    {
        //        OrderStockQuantity = getOrderQuantity(orderID);
        //    }
        //    else
        //    {
        //        OrderStockQuantity = getOrderQuantity(itemID, supplierID);
        //    }

        //    if (OrderStockQuantity == quantity)
        //    {
        //        quantityResult = 0;
        //    }
        //    else if (OrderStockQuantity < quantity)
        //    {
        //        quantityResult = 1;
        //    }
        //    else
        //    {
        //        quantityResult = -1;
        //    }
        //    return quantityResult;
        //}

        //public int checkStockQuantity(string stockID, int quantity)
        //{
        //    int StockQuantity = getStockQuantity(stockID);
        //    int quantityResult;

        //    if (StockQuantity == quantity)
        //    {
        //        quantityResult = 0;
        //    }
        //    else if (StockQuantity < quantity)
        //    {
        //        quantityResult = 1;
        //    }
        //    else
        //    {
        //        quantityResult = -1;
        //    }
        //    //MessageBox.Show(quantityResult.ToString(), "Quantity");
        //    return quantityResult;
        //}

        public void addAutomaticReorderParametersTest(string model, string threshold_value, string reordering_amount) {
            //DataSet AutomaticReorderParameters = null;

            if (threshold_value == null)
            {
                if (reordering_amount == null)
                {
                    CheckAndSetAutomaticReordering(model, null, null);
                }
                else {
                    CheckAndSetAutomaticReordering(model, null, reordering_amount);
                }
            }
            else {
                if (reordering_amount == null)
                {
                    CheckAndSetAutomaticReordering(model, threshold_value, null);
                }
                else{
                    CheckAndSetAutomaticReordering(model, null, null);
                }
            }
        }

        public void addAutomaticReorderParameters(string itemID, string threshold_value, string reordering_amount)
        {
            DataSet AutomaticReorderParameters = null;

            if (threshold_value == null)
            {
                if (reordering_amount == null)
                {
                    AutomaticReorderParameters = Getter.GetFromDB("SELECT Threshold_Value,Reordering_Amount FROM tbl_items WHERE Item_ID = '" + itemID + "'");

                    if (AutomaticReorderParameters.Tables[0].Rows[0][0].ToString() == "")
                    {
                        if (AutomaticReorderParameters.Tables[0].Rows[0][1].ToString() == "")
                        {
                            CheckAndSetAutomaticReordering(itemID, null, null);
                        }
                        else
                        {
                            CheckAndSetAutomaticReordering(itemID, null, AutomaticReorderParameters.Tables[0].Rows[0][1].ToString());
                        }
                    }
                    else
                    {
                        if (AutomaticReorderParameters.Tables[0].Rows[0][1].ToString() == "")
                        {
                            CheckAndSetAutomaticReordering(itemID, AutomaticReorderParameters.Tables[0].Rows[0][0].ToString(), null);
                        }
                        else
                        {
                            CheckAndSetAutomaticReordering(itemID, AutomaticReorderParameters.Tables[0].Rows[0][0].ToString(), AutomaticReorderParameters.Tables[0].Rows[0][1].ToString());
                        }
                    }
                }
                else
                {
                    AutomaticReorderParameters = Getter.GetFromDB("SELECT Threshold_Value FROM tbl_items WHERE Item_ID = '" + itemID + "'");

                    MessageBox.Show(itemID + " " + AutomaticReorderParameters.Tables[0].Rows[0][0].ToString(), "AutoorderParameters2");

                    if (AutomaticReorderParameters.Tables[0].Rows[0][0] == null)
                    {
                        CheckAndSetAutomaticReordering(itemID, null, reordering_amount);
                    }
                    else
                    {
                        CheckAndSetAutomaticReordering(itemID, AutomaticReorderParameters.Tables[0].Rows[0][0].ToString(), reordering_amount);
                    }
                }
            }
            else
            {
                if (reordering_amount == null)
                {
                    AutomaticReorderParameters = Getter.GetFromDB("SELECT Reordering_Amount FROM tbl_items WHERE Item_ID = '" + itemID + "'");

                    MessageBox.Show(itemID + " " + AutomaticReorderParameters.Tables[0].Rows[0][0].ToString(), "AutoorderParameters3");


                    if (AutomaticReorderParameters.Tables[0].Rows[0][0].ToString() == "")
                    {
                        CheckAndSetAutomaticReordering(itemID, threshold_value, null);
                    }
                    else
                    {
                        CheckAndSetAutomaticReordering(itemID, threshold_value, AutomaticReorderParameters.Tables[0].Rows[0][0].ToString());
                    }
                }
                else
                {
                    CheckAndSetAutomaticReordering(itemID, threshold_value, reordering_amount);
                }
            }
        }

        private int getAvailableOrUnavailableItemAmount(string model, int isAvailable, string orderID)
        {
            int modelCount = 0;
            string orderClause = null;
            if (orderID != null)
            {
                orderClause = " AND Order_ID = '" + orderID + "'";
            }
            else
            {
                orderClause = "";
            }

            if ((isAvailable >= 0) && (isAvailable < 2))
            {
                modelCount = Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM tbl_ordered_Item_details WHERE Model = '" + model + "' AND Available = " + isAvailable + orderClause).Tables[0].Rows[0][0].ToString());
            }
            else
            {
                modelCount = Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM tbl_ordered_Item_details WHERE Model = '" + model + "'" + orderClause).Tables[0].Rows[0][0].ToString());
            }

            return modelCount;
        }

        //private bool getFullArrived(string orderID)
        //{
        //    bool FullArrived = Convert.ToBoolean(Getter.GetFromDB("SELECT Full_Arrived FROM tbl_orders WHERE Order_ID = '" + orderID + "'").Tables[0].Rows[0][0].ToString());
        //    return FullArrived;
        //}

        public void addStockInformation(DataGridView table)
        {            
            for (int a = 0; a < table.Rows.Count; a++)
            {
                int count = Convert.ToInt32((new DBConnect().GetFromDB("SELECT COUNT(*) FROM tbl_stocks WHERE Model = '" + table.Rows[a].Cells[1].Value.ToString() + "'").Tables[0].Rows[0][0].ToString()));
                //int count = Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM tbl_ordered_Item_details WHERE Model = '" + table.Rows[a].Cells[1].Value.ToString() + "' AND Available = 0").Tables[0].Rows[0][0].ToString());
                MessageBox.Show(count.ToString(), "Count");

                if (count != 0)
                {
                    int quantity = Convert.ToInt32(new DBConnect().GetFromDB("SELECT Quantity FROM tbl_stocks WHERE Stock_ID = '" + table.Rows[a].Cells[0].Value.ToString() + "'").Tables[0].Rows[0][0].ToString()) + Convert.ToInt32(table.Rows[a].Cells[4].Value.ToString());
                    new DBConnect().SendToDB("UPDATE tbl_stocks SET Quantity = " + quantity.ToString() + " WHERE Stock_ID = '" + table.Rows[a].Cells[0].Value.ToString() + "'");
                }
                //else if (count < Convert.ToInt32(table.Rows[a].Cells[4].Value.ToString())) {
                //    MessageBox.Show("Ordered Amount Is Lesser Than The Amount You Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // do this validation inside if condition
                //    return;
                //}
                else
                {
                    new DBConnect().SendToDB("INSERT INTO tbl_stocks VALUES('" + table.Rows[a].Cells[0].Value.ToString() + "','" + table.Rows[a].Cells[1].Value.ToString() + "'," + table.Rows[a].Cells[4].Value.ToString() + ")");
                }

                DataSet OrderID = getOrderIDList(table.Rows[a].Cells[1].Value.ToString(), 0);
                DataSet AddingStockDetails = getArrivedStockDetails(null, null, null, null, OrderID, table.Rows[a].Cells[1].Value.ToString(), 0, "0");//0); //added 0 to last
                int ItemCount = Convert.ToInt32(table.Rows[a].Cells[4].Value.ToString());
                MessageBox.Show(AddingStockDetails.Tables[0].Rows.Count.ToString(), "OrderID");

                string ModelPrefix = table.Rows[a].Cells[2].Value.ToString().Substring(0, 1) + table.Rows[a].Cells[1].Value.ToString().Substring(0, 2) + table.Rows[a].Cells[1].Value.ToString().Substring(table.Rows[a].Cells[1].Value.ToString().Length - 1, 1);
                int NotAvailableAmount = getAvailableOrUnavailableItemAmount(table.Rows[a].Cells[1].Value.ToString(), 0, null);
                int TotalAmount = getAvailableOrUnavailableItemAmount(table.Rows[a].Cells[1].Value.ToString(), 2, null);

                MessageBox.Show(NotAvailableAmount.ToString() + " " + TotalAmount.ToString());
                for (int c = TotalAmount - NotAvailableAmount; c < (TotalAmount - NotAvailableAmount) + ItemCount; c++)
                {
                    MessageBox.Show(ModelPrefix + (c + 1));
                    new DBConnect().SendToDB("UPDATE tbl_ordered_Item_details SET Available = 1 WHERE Item_ID = '" + ModelPrefix + (c + 1) + "'");
                }

                MessageBox.Show(AddingStockDetails.Tables[0].Rows.Count.ToString(), "AddingStock");
                for (int i = 0; i < AddingStockDetails.Tables[0].Rows.Count; i++)
                {
                    int OrderCount = Convert.ToInt32(AddingStockDetails.Tables[0].Rows[i][4].ToString());
                    MessageBox.Show(OrderCount.ToString() + " " + ItemCount.ToString(), "OrderCount ItemCount");
                    if (ItemCount > OrderCount)
                    {
                        new DBConnect().SendToDB("UPDATE tbl_orders SET Full_Arrived = 1 WHERE Order_ID = '" + OrderID.Tables[0].Rows[i][0].ToString() + "'");
                    }

                    ItemCount -= OrderCount;
                }
            }
        }

        public void addWarehhouseActivities(DataGridView table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string count = new DBConnect().GetFromDB("SELECT COUNT(*) FROM Vehicle_Request_Details").Tables[0].Rows[0][0].ToString();
                string requestNo = Getter.GetFromDB("SELECT * FROM Vehicle_Request_Details WHERE RegistrationNo = " + table.Rows[i].Cells[3].Value.ToString()).Tables[0].Rows[0][0].ToString();
                MessageBox.Show(table.Rows[i].Cells[0].Value.ToString() + " " + requestNo + " " + table.Rows[i].Cells[3].Value.ToString() + " " + table.Rows[i].Cells[1].Value.ToString() + " " + table.Rows[i].Cells[6].Value.ToString() + " " + table.Rows[i].Cells[7].Value.ToString());
                new DBConnect().SendToDB("INSERT INTO tbl_warehouse_activities VALUES('" + table.Rows[i].Cells[0].Value.ToString() + "'," + requestNo + ",'" + table.Rows[i].Cells[3].Value.ToString() + "','" + table.Rows[i].Cells[1].Value.ToString() + "','" + table.Rows[i].Cells[6].Value.ToString() + "'," + "'" + table.Rows[i].Cells[7].Value.ToString() + "','" + table.Rows[i].Cells[8].Value.ToString() + "')");
            }
        }
        public void removeWarehosuActivities(DataGridView table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                new DBConnect().SendToDB("DELETE FROM tbl_warehouse_activities WHERE Activity_ID = '" + table.Rows[i].Cells[0].Value.ToString() + "'");
            }
        }


        //public Boolean addStockInformation(string description, string supplierName, int quantity,string origin,string threshold_value,string reordering_amount)
        //{
        //    string ErrorMessage = null;
        //    bool isCompleted = false;
        //    string supplierID = new DBQueries().checkSupplierID(supplierName, origin);
        //    MessageBox.Show(supplierID,"Supplier ID");
        //    string itemID = new DBQueries().checkItemID(description);
        //    MessageBox.Show(itemID,"Item ID");
        //    string stockID = null;
        //    DataSet orderIDList = null;

        //    if (supplierID == null)
        //    {
        //        if (itemID == null)
        //        {
        //            ErrorMessage = "No Item And Supplier Information Found For Given Data." + Environment.NewLine + "So Incomplete Order Information Search Failed" + Environment.NewLine + "Please Check Whether Description,Supplier Name And Origin Are Correct.";
        //        }
        //        else {
        //            ErrorMessage = "No Supplier Information Found For Given Supplier Data" + Environment.NewLine + "So Incomplete Order Information Search Failed" + Environment.NewLine + "Please Check Whether Supplier Name And Origin Are Correct.";
        //        }              
        //    }
        //    else {
        //        if (itemID == null)
        //        {
        //            ErrorMessage = "No Item Information Found For Given Item Data" + Environment.NewLine + "So Incomplete Order Information Search Failed" + Environment.NewLine + "Please Check Whether Description Is Correct.";
        //        }
        //        else {                    
        //            orderIDList = getOrderIDList(itemID, supplierID);

        //            if (orderIDList.Tables[0].Rows.Count != 0)
        //            {
        //                int orderQuantity = getOrderQuantity(itemID, supplierID);
        //                MessageBox.Show(orderQuantity.ToString());
        //                if (orderQuantity < quantity)
        //                {
        //                    ErrorMessage = "Stock Amount Larger Than Order Amount.Most Probably Some Amount Of This Item Might Added To The Stocks Before Or Exceeds The Order Amount";
        //                    isCompleted = false;
        //                }
        //                else
        //                {
        //                    stockID = checkStockID(itemID, supplierID);
        //                    MessageBox.Show(stockID, "stockID");
        //                    if (stockID == null)
        //                    {
        //                        string category = getItemCategory(itemID);
        //                        stockID = generateStockID(itemID);//,category);//supplierID);
        //                        Getter.SendToDB("INSERT INTO tbl_stocks(Stock_ID,Item_ID,Remaining_Quantity) VALUES ('" + stockID + "','" + itemID + "'," + quantity + ")");// ("INSERT INTO tbl_stocks(Stock_ID,Item_ID,Supplier_ID,Remaining_Quantity) VALUES (" + stockID + "," + itemID + "," + supplierID + "," + quantity + ")");
        //                        for (int i = 0; i < orderIDList.Tables[0].Rows.Count; i++)
        //                        {
        //                            if (quantity >= getOrderQuantity(orderIDList.Tables[0].Rows[i][0].ToString()))
        //                            {
        //                                Getter.SendToDB("UPDATE tbl_orders SET Full_Arrived = 1 WHERE Order_ID = '" + orderIDList.Tables[0].Rows[i][0] + "'");
        //                                quantity = quantity - Convert.ToInt32(getOrderQuantity(orderIDList.Tables[0].Rows[i][0].ToString()));//orderQuantity;
        //                            }
        //                            else
        //                            {
        //                                Getter.SendToDB("UPDATE tbl_orders SET Full_Arrived = 0 WHERE Order_ID = '" + orderIDList.Tables[0].Rows[i][0] + "'");
        //                                break;
        //                            }                                    
        //                        }

        //                        addAutomaticReorderParameters(itemID, threshold_value, reordering_amount);
        //                        //CheckAndSetAutomaticReordering(itemID, threshold_value, reordering_amount);
        //                        isCompleted = true;                                                                          
        //                        MessageBox.Show("Stock Details Saved Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    }
        //                    else
        //                    {
        //                        ErrorMessage = "Stock Details Are Already Available In The Stocks";
        //                        isCompleted = false;
        //                    }
        //                }
        //            }
        //            else {
        //                isCompleted = false;
        //                ErrorMessage = "There Are No Order Information Found For Provided Details.Please Check Your Form Inputs";
        //            }
        //        }
        //    }

        //    if (ErrorMessage != null)
        //    {
        //        MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        isCompleted = false;
        //    }

        //    return isCompleted;           
        //}

        public string generateItemID(string model, string brand)
        {
            // MessageBox.Show(model.Substring(0, 2) + model.Substring(model.Length - 1, 1), "ItemID", MessageBoxButtons.OK);
            int count = Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM tbl_ordered_Item_details WHERE Model = '" + model + "'").Tables[0].Rows[0][0].ToString()) + 1;
            string itemID = brand.Substring(0, 1) + model.Substring(0, 2) + model.Substring(model.Length - 1, 1) + count.ToString();
            MessageBox.Show(itemID, "ItemID", MessageBoxButtons.OK);
            return itemID;
        }

        public void addOrderInformation(DataGridView table)
        {
            ArrayList orderIDList = new ArrayList();
            int index = -1;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (orderIDList.Count != 0)
                {
                    bool isDuplicated = false;
                    for (int a = 0; a < orderIDList.Count; a++)
                    {
                        if (orderIDList[a].ToString() == table.Rows[i].Cells[0].Value.ToString())
                        {
                            MessageBox.Show(orderIDList[a].ToString(), "==");
                            isDuplicated = true;
                            index = a;
                            break;
                        }
                    }

                    if (!isDuplicated)
                    {
                        index++;
                        orderIDList.Add(table.Rows[i].Cells[0].Value);
                        MessageBox.Show(orderIDList[index].ToString(), "!=");
                        //          new DBConnect().SendToDB("INSERT INTO tbl_orders(Order_ID,Ordered_Date) VALUES('" + orderIDList[index].ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')");
                        MessageBox.Show("INSERT INTO tbl_orders(Order_ID,Ordered_Date,Brand) VALUES('" + orderIDList[index].ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + table.Rows[i].Cells[2].Value.ToString() + "')");
                        new DBConnect().SendToDB("INSERT INTO tbl_orders(Order_ID,Ordered_Date,Brand,Ordered_Time) VALUES('" + orderIDList[index].ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd")/* hh:mm:ss")*/ + "','" + table.Rows[i].Cells[2].Value.ToString() + "','" + DateTime.Now.ToLocalTime().ToString() + "')");
                    }
                }
                else
                {
                    orderIDList.Add(table.Rows[i].Cells[0].Value);
                    index++;
                    new DBConnect().SendToDB("INSERT INTO tbl_orders(Order_ID,Ordered_Date,Brand,Ordered_Time) VALUES('" + orderIDList[i].ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd")/* hh:mm:ss")*/ + "','" + table.Rows[i].Cells[2].Value.ToString() + "','" + DateTime.Now.ToLocalTime().ToString() + "')");
                }

                string ItemPrefix = (table.Rows[i].Cells[2].Value.ToString().Substring(0, 1) + table.Rows[i].Cells[1].Value.ToString().Substring(0, 2) + table.Rows[i].Cells[1].Value.ToString().Substring(table.Rows[i].Cells[1].Value.ToString().Length - 1, 1));



                for (int a = 0; a < Convert.ToInt32(table.Rows[i].Cells[5].Value); a++)
                {
                    string ItemNumber = (Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM tbl_ordered_Item_details WHERE Item_ID LIKE '" + ItemPrefix + "%'").Tables[0].Rows[0][0]) + 1).ToString(); //might cause errors please get the dataset separately and get the last value of it
                    MessageBox.Show("INSERT INTO tbl_ordered_Item_details VALUES('" + ItemPrefix + ItemNumber + "','" + table.Rows[i].Cells[0].Value.ToString() + "','" + table.Rows[i].Cells[1].Value.ToString() + "'," + table.Rows[i].Cells[6].Value.ToString() + ")");
                    new DBConnect().SendToDB("INSERT INTO tbl_ordered_Item_details(Item_ID,Order_ID,Model,Price) VALUES('" + ItemPrefix + ItemNumber + "','" + table.Rows[i].Cells[0].Value.ToString() + "','" + table.Rows[i].Cells[1].Value.ToString() + "'," + table.Rows[i].Cells[6].Value.ToString() + ")");
                }

                if (table.Rows[i].Cells[7].Value.ToString() == "Set") {
                    MessageBox.Show(table.Rows[i].Cells[0].Value.ToString() + ": " + table.Rows[i].Cells[7].Value.ToString());
                    CheckAndSetAutomaticReordering(table.Rows[i].Cells[1].Value.ToString(),table.Rows[i].Cells[8].Value.ToString(),table.Rows[i].Cells[9].Value.ToString());
                }
            }
        }

        public void CheckAndSetAutomaticReordering(string model, string threshold_value, string reordering_amount)
        {
            if (threshold_value != null)
            {
                if (reordering_amount != null)
                {
                    MessageBox.Show(threshold_value + " " + reordering_amount, "Option1CheckandSet");
                    Getter.SendToDB("UPDATE tbl_items SET Threshold_Value = " + threshold_value + ",Reordering_Amount = " + reordering_amount + " WHERE Model = '" + model + "'");// ("UPDATE tbl_items SET Threshold_Value = " + threshold_value + ",Reordering_Amount = " + reordering_amount + "WHERE Item_ID = '" + itemID + "'");
                }
                else
                {
                    MessageBox.Show(threshold_value + " " + reordering_amount, "Option2CheckandSet");
                    Getter.SendToDB("UPDATE tbl_items SET Threshold_Value = " + threshold_value + " WHERE Model = 'BCDX'");//("UPDATE tbl_items SET Threshold_Value = " + threshold_value + "WHERE Item_ID = '" + itemID + "'");
                }
            }
            else
            {
                if (reordering_amount != null)
                {
                    MessageBox.Show(threshold_value + " " + reordering_amount, "Option3CheckandSet");
                    Getter.SendToDB("UPDATE tbl_items SET Reordering_Amount = " + reordering_amount + " WHERE Model = '" + model + "'");// ("UPDATE tbl_items SET Reordering_Amount = " + reordering_amount + "WHERE Item_ID = '" + itemID + "'");
                }
                else
                {
                    MessageBox.Show(threshold_value + " " + reordering_amount, "Option4CheckandSet");
                    Getter.SendToDB("UPDATE tbl_items SET Threshold_Value = NULL,Reordering_Amount = NULL WHERE Model = '" + model + "'");
                }
            }
        }

        public void removeOrderInformation(DataGridView table)
        {
            ArrayList OrderIDList = new ArrayList();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                bool isDuplicated = false;
                if (OrderIDList.Count != 0)
                {
                    for (int a = 0; a < OrderIDList.Count; a++)
                    {
                        if (OrderIDList[a].ToString() == table.Rows[i].Cells[0].Value.ToString())
                        {
                            isDuplicated = true;
                            break;
                        }
                    }

                    if (!isDuplicated)
                    {
                        OrderIDList.Add(table.Rows[i].Cells[0].Value);
                    }
                }
                else
                {
                    OrderIDList.Add(table.Rows[i].Cells[0].Value);
                }
            }

            for (int b = 0; b < table.Rows.Count; b++)
            {
                for (int c = 0; c < OrderIDList.Count; c++)
                {
                    if (table.Rows[b].Cells[0].Value.ToString() == OrderIDList[c].ToString())
                    {
                        new DBConnect().SendToDB("DELETE FROM tbl_ordered_Item_details WHERE Order_ID = '" + OrderIDList[c].ToString() + "'");
                    }
                }
            }

            for (int d = 0; d < OrderIDList.Count; d++)
            {
                new DBConnect().SendToDB("DELETE FROM tbl_orders WHERE Order_ID = '" + OrderIDList[d].ToString() + "'");
            }
        }

        public void changeOrderInformation(DataGridView table, string orderID)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int modelCount = Convert.ToInt32(Getter.GetFromDB("SELECT COUNT(*) FROM tbl_ordered_Item_details WHERE Model = '" + table.Rows[i].Cells[0].Value.ToString() + "' AND Order_ID = '" + orderID + "'").Tables[0].Rows[0][0].ToString());
                MessageBox.Show(modelCount.ToString(), "modelCount");
                //MessageBox.Show("SELECT COUNT(*) FROM tbl_ordered_Item_details WHERE Model = '" + table.Rows[i].Cells[0].Value.ToString() + "' AND Order_ID = '" + orderID + "'").Tables[0].Rows[0][0].ToString(),"modelCount");

                DataSet itemDetails = Getter.GetFromDB("SELECT Brand,Unit_Price FROM tbl_items WHERE Model = '" + table.Rows[i].Cells[0].Value.ToString() + "'"); //has an error i think
                MessageBox.Show(itemDetails.Tables[0].Rows.Count.ToString(), "itemDetailsCount");

                MessageBox.Show(table.Rows[i].Cells[1].Value.ToString() + " " + modelCount.ToString() + (Convert.ToInt32(table.Rows[i].Cells[1].Value.ToString()) - modelCount).ToString(), "changeOrder");

                if (Convert.ToInt32(table.Rows[i].Cells[1].Value.ToString()) - modelCount > 0)
                {
                    for (int a = 0; a < (Convert.ToInt32(table.Rows[i].Cells[1].Value.ToString()) - modelCount); a++)
                    {
                        string itemID = generateItemID(table.Rows[i].Cells[0].Value.ToString(), itemDetails.Tables[0].Rows[0][0].ToString());
                                                                                                               /// 
                        MessageBox.Show(itemID, "itemID");                                                                                       /// 

                        string price = itemDetails.Tables[0].Rows[0][1].ToString();

                        MessageBox.Show("INSERT INTO tbl_ordered_Item_details VALUES('" + itemID + "','" + orderID + "','" + table.Rows[i].Cells[0].Value.ToString() + "','" + price + "')", "changeOrderItem");
                        Getter.SendToDB("INSERT INTO tbl_ordered_Item_details(Item_ID,Order_ID,Model,Price) VALUES('" + itemID + "','" + orderID + "','" + table.Rows[i].Cells[0].Value.ToString() + "','" + price + "')");

                    }
                }

                if (Convert.ToInt32(table.Rows[i].Cells[1].Value.ToString()) - modelCount < 0) {
                    MessageBox.Show("SELECT * FROM tbl_ordered_Item_details WHERE Order_ID = '" + orderID + "' AND Model = '" + table.Rows[i].Cells[0].Value.ToString() + "'", "changeInitialSQL");
                    DataSet orderItemDetails = Getter.GetFromDB("SELECT * FROM tbl_ordered_Item_details WHERE Order_ID = '" + orderID + "' AND Model = '" + table.Rows[i].Cells[0].Value.ToString() + "'");
                    MessageBox.Show(orderItemDetails.Tables[0].Rows.Count.ToString(), "OrderItemDetailsCOunt");
                    MessageBox.Show(table.Rows[i].Cells[1].Value.ToString(),"TableOrderItemDetailsCount");

                    for (int a = 0; a < (orderItemDetails.Tables[0].Rows.Count - Convert.ToInt32(table.Rows[i].Cells[1].Value.ToString())); a++) {
                        string itemID = orderItemDetails.Tables[0].Rows[(orderItemDetails.Tables[0].Rows.Count - 1) - a][0].ToString();
                        MessageBox.Show("Remove " + itemID);
                        MessageBox.Show("DELETE FROM tbl_ordered_Item_details WHERE Item_ID = '" + itemID + "'", "DeleteItemSQL");
                        Getter.SendToDB("DELETE FROM tbl_ordered_Item_details WHERE Item_ID = '" + itemID + "'");
                    }
                }
                ////else if (Convert.ToInt32(table.Rows[i].Cells[1].Value.ToString()) - modelCount == 0) { }
                //if (Convert.ToInt32(table.Rows[i].Cells[1].Value.ToString()) - modelCount < 0)
                //{
                //    string prefix = table.Rows[i].Cells[0].Value.ToString();
                //    int ID = Convert.ToInt32(Getter.GetFromDB("SELECT COUNT(*) FROM tbl_ordered_Item_details WHERE Model = '" + table.Rows[i].Cells[0].Value.ToString() + "'").ToString()) - modelCount + 1;
                    
                //    for (int a = modelCount; a > Convert.ToInt32(table.Rows[i].Cells[1].Value.ToString()); a--)
                //    {
                //        string lastItemID = itemDetails.Tables[0].Rows[0][0].ToString().Substring(0, 1) + prefix.Substring(0, 2) + prefix.Substring(prefix.Length - 1, 1) + ID.ToString();//a.ToString();
                        
                //        MessageBox.Show(lastItemID, "LastItemID");
                //        MessageBox.Show("DELETE FROM tbl_ordered_Item_details WHERE Item_ID = '" + lastItemID + "'","DeleteOrderItem");
                //        Getter.SendToDB("DELETE FROM tbl_ordered_Item_details WHERE Item_ID = '" + lastItemID + "'");
                //    }
                //}
            }
        }

        public void removeStockInformation(DataGridView table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                //string accNo = new DBConnect().GetFromDB("SELECT Activity_ID FROM tbl_warehouse_activities WHERE Stock_ID = '" + table.Rows[i].Cells[0].Value.ToString() + "'").Tables[0].Rows[0][0].ToString();
                //new DBConnect().SendToDB("DELETE FROM tbl_warehouse_activities WHERE Activity_ID = '" + accNo + "'");
                int AvailableAmount = getAvailableOrUnavailableItemAmount(table.Rows[i].Cells[1].Value.ToString(), 1, null);
                DataSet OrderIDList = getOrderIDList(table.Rows[i].Cells[1].Value.ToString(), 2);
                MessageBox.Show(OrderIDList.Tables[0].Rows.Count.ToString());

                for (int a = AvailableAmount; a > 0; a--)
                {
                    Getter.SendToDB("UPDATE tbl_ordered_Item_details SET Available = 0 WHERE Model = '" + table.Rows[i].Cells[1].Value.ToString() + "'");
                }

                for (int b = 0; b < OrderIDList.Tables[0].Rows.Count; b++)
                {
                    Getter.SendToDB("UPDATE tbl_orders SET Full_Arrived = 0 WHERE Order_ID = '" + OrderIDList.Tables[0].Rows[b][0].ToString() + "'");
                }
                Getter.SendToDB("DELETE FROM tbl_stocks WHERE Stock_ID = '" + table.Rows[i].Cells[0].Value.ToString() + "'");
            }
        }

        //public string checkStockID(string itemID, string supplierID)
        //{
        //    DataSet StockID = Getter.GetFromDB("SELECT Stock_ID FROM tbl_stocks WHERE Item_ID = '" + itemID + "'");
        //    string stockID;
        //    if (StockID.Tables[0].Rows.Count == 0)
        //    {
        //        stockID = null;
        //    }
        //    else
        //    {
        //        stockID = StockID.Tables[0].Rows[0][0].ToString();
        //    }
        //    return stockID;
        //}

        public void changeStockInformation(DataGridView table)
        {
            //bool completed = false;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int quantity = Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM tbl_ordered_Item_details WHERE Model = '" + table.Rows[i].Cells[1].Value.ToString() + "'").Tables[0].Rows[0][0].ToString());

                if (quantity < Convert.ToInt32(table.Rows[i].Cells[3].Value.ToString()))
                {
                    MessageBox.Show("Ordered Quantity Is Smaller Than Entered Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //completed = false;
                    break;
                }
                else
                {
                    int AvailableAmount = getAvailableOrUnavailableItemAmount(table.Rows[i].Cells[1].Value.ToString(), 1, null);

                     
                    string ItemIDPrefix = table.Rows[i].Cells[2].Value.ToString().Substring(0, 1) + table.Rows[i].Cells[1].Value.ToString().Substring(0, 2) + table.Rows[i].Cells[1].Value.ToString().Substring(3, 1);
                    int OrderIndex = 0;
                    DataSet AvailableItemDetails = null;

                    MessageBox.Show("AvailableAmount : " + AvailableAmount.ToString() + "ItemPrefix : " + ItemIDPrefix + "OrderIndex : " + OrderIndex.ToString(), "quantity lt Convert.ToInt32(table.Rows[i].Cells[3].Value)" + Convert.ToString(quantity < Convert.ToInt32(table.Rows[i].Cells[3].Value)));

                    while (AvailableAmount > Convert.ToInt32(table.Rows[i].Cells[3].Value.ToString()))
                    {
                        DataSet AvailableOrderID = getOrderIDList(table.Rows[i].Cells[1].Value.ToString(), 1);

                        OrderIndex = AvailableOrderID.Tables[0].Rows.Count - (i + 1);
                        MessageBox.Show(OrderIndex.ToString(), "OrderIndex");

                        int TotalCurrentOrderAmount = getAvailableOrUnavailableItemAmount(table.Rows[i].Cells[1].Value.ToString(), 1, AvailableOrderID.Tables[0].Rows[OrderIndex/*i*/][0].ToString());
                        MessageBox.Show(TotalCurrentOrderAmount.ToString());

                        if (AvailableItemDetails == null)
                        {
                            AvailableItemDetails = getArrivedStockDetails(null, null, null, null, AvailableOrderID, table.Rows[i].Cells[1].Value.ToString(), 1, "0");

                            ////////////////////testing purpose
                            if (AvailableItemDetails != null)
                            {
                                MessageBox.Show(AvailableItemDetails.Tables[0].Rows[i][4].ToString(), "OrderAvailableItemCountPartial"); //shows the item count of an order
                            }

                        }

                        if (AvailableItemDetails.Tables[0].Rows.Count == 0)
                        {
                            AvailableItemDetails = getArrivedStockDetails(null, null, null, null, AvailableOrderID, table.Rows[i].Cells[1].Value.ToString(), 1, "1");
                            ///////////////testing purpose
                            MessageBox.Show(AvailableItemDetails.Tables[0].Rows[i][4].ToString(), "OrderAvailableItemCountFull"); //shows the item count of an order
                        }

                        for (int a = 0; a < Convert.ToInt32(AvailableItemDetails.Tables[0].Rows[i][4].ToString()); a++)
                        {

                            if ((AvailableAmount - a) == Convert.ToInt32(table.Rows[i].Cells[3].Value.ToString()))
                            {
                                Getter.SendToDB("UPDATE tbl_orders SET Full_Arrived = 0 WHERE Order_ID = '" + AvailableOrderID.Tables[0].Rows[OrderIndex/*i*/][0].ToString() + "'");
                                MessageBox.Show("UPDATE tbl_orders SET Full_Arrived = 0 WHERE Order_ID = '" + AvailableOrderID.Tables[0].Rows[OrderIndex/*i*/][0].ToString() + "'", "OrderChange");
                                return;// true;

                                //break;
                            }

                            string ItemID = ItemIDPrefix + (AvailableAmount - a);
                            MessageBox.Show(ItemID);

                            int OrderIDDatasetIndex = AvailableOrderID.Tables[0].Rows.Count - (i + 1);
                            Getter.SendToDB("UPDATE tbl_ordered_Item_details SET Available = 0 WHERE Item_ID = '" + ItemID + "' AND Order_ID = '" + AvailableOrderID.Tables[0].Rows[OrderIDDatasetIndex][0].ToString() + "'");
                            MessageBox.Show("UPDATE tbl_ordered_Item_details SET Available = 0 WHERE Item_ID = '" + ItemID + "' AND Order_ID = '" + AvailableOrderID.Tables[0].Rows[OrderIDDatasetIndex][0].ToString() + "'", "ItemchangeSQL");
                        }

                        OrderIndex--;

                        AvailableAmount -= TotalCurrentOrderAmount;
                        MessageBox.Show(AvailableAmount.ToString(), "AvailableAmount");

                        AvailableItemDetails.Clear();                        
                    }



                    /*else*/
                    while (AvailableAmount < Convert.ToInt32(table.Rows[i].Cells[3].Value.ToString())) //not work
                    {
                        DataSet AvailableOrderID = getOrderIDList(table.Rows[i].Cells[1].Value.ToString(), 0);
                        MessageBox.Show(AvailableOrderID.Tables[0].Rows.Count.ToString(),"AvailableOrderIDs");

                        int TotalUnavailableCurrentOrderAmount = getAvailableOrUnavailableItemAmount(table.Rows[i].Cells[1].Value.ToString(), 0, null);
                        MessageBox.Show(TotalUnavailableCurrentOrderAmount.ToString(), "TotalUnavailableCurrentOrderAmount");
                        
                        int count = AvailableAmount + 1;
                        MessageBox.Show(count.ToString(),"Count");

                        for (int a = count; a <= Convert.ToInt32(table.Rows[i].Cells[3].Value.ToString()); a++) {

                            MessageBox.Show("UPDATE tbl_ordered_Item_details SET Available = 1 WHERE Item_ID = '" + ItemIDPrefix + a.ToString() + "'", "ItemSqlChange"); ;
                            Getter.SendToDB("UPDATE tbl_ordered_Item_details SET Available = 1 WHERE Item_ID = '" + ItemIDPrefix + a.ToString() + "'");
                            count++;

                            if (a == Convert.ToInt32(table.Rows[i].Cells[3].Value.ToString())) {
                                Getter.SendToDB("UPDATE tbl_orders SET Full_Arrived = 1 WHERE Order_ID = '" + AvailableOrderID.Tables[0].Rows[i][0].ToString() + "'");
                                MessageBox.Show("UPDATE tbl_orders SET Full_Arrived = 1 WHERE Order_ID = '" + AvailableOrderID.Tables[0].Rows[i][0].ToString() + "'");
                                return;// true;
                            }
                        }                      

                        //if(count == 
                        //break;

                        //for (int a = AvailableAmount; a < Convert.ToInt32(table.Rows[i].Cells[3].Value.ToString()); a++)
                        //{
                        //    string ItemID = ItemIDPrefix + (a + 1).ToString();
                        //    MessageBox.Show(ItemID);
                        //    Getter.SendToDB("UPDATE tbl_ordered_Item_details SET Available = 0 WHERE Item_ID = '" + ItemID + "' AND Order_ID = '" + AvailableOrderID.Tables[0].Rows[a - AvailableAmount][0].ToString() + "'");
                        //    //Getter.SendToDB("UPDATE tbl_ordered_Item_details SET Available = 1 WHERE Model = '" + table.Rows[a-1].Cells[1].Value.ToString() + "'");
                        //}
                    }
                    //new DBConnect().SendToDB("UPDATE tbl_stocks SET Quantity = " + table.Rows[i].Cells[3].Value.ToString() + " WHERE Stock_ID = '" + table.Rows[i].Cells[0].Value.ToString() + "'");
               //     completed = true;
                }
            }
          //  return completed;
        }

        //public Boolean changeStockInformation(string description,string supplierName,int quantity,/*string arrivedDate, string arrivedTime ,string orderedDate,string orderedTime,*/ string origin,string threshold_value,string reordering_amount) {
        //    bool isCompleted = false;
        //    string itemID = new DBQueries().checkItemID(description);
        //    MessageBox.Show(itemID, "itemid");
        //    string supplierID = new DBQueries().checkSupplierID(supplierName,origin);
        //    MessageBox.Show(supplierID, "supplierid");

        //    string errorMessage = null;
        //    if (supplierID == null)
        //    {
        //        if (itemID == null)
        //        {
        //            errorMessage = "No Item And Supplier Information Found For Given Data." + Environment.NewLine + "Please Check Whether Description,Supplier Name And Origin Are Correct.";
        //            isCompleted = false;
        //        }
        //        else
        //        {
        //            errorMessage = "No Supplier Information Found For Given Data." + Environment.NewLine + "Please Check Supplier Name And Origin Are Correct.";
        //            isCompleted = false;
        //        }
        //    }
        //    else
        //    {
        //        if (itemID == null)
        //        {
        //            errorMessage = "No Item Information Found For Given Data." + Environment.NewLine + "Please Check Whether Description Is Correct.";
        //            isCompleted = false;
        //        }
        //        else
        //        {
        //            string stockID = checkStockID(itemID, supplierID);
        //            int orderAmount = getOrderQuantity(itemID, supplierID);

        //            if (quantity <= orderAmount)
        //            {
        //                setStockQuantity(stockID, quantity);
        //                DataSet OrderIDList = getOrderIDList(itemID, supplierID);

        //                MessageBox.Show(itemID + " " + supplierID + " " + OrderIDList.Tables[0].Rows.Count.ToString(), "changeStockInformation");

        //                if (OrderIDList.Tables[0].Rows.Count != 0)
        //                {
        //                    for (int i = 0; i < OrderIDList.Tables[0].Rows.Count; i++)
        //                    {
        //                        string orderID = OrderIDList.Tables[0].Rows[i][0].ToString();
        //                        MessageBox.Show(orderID, "orderID change");
        //                        if (quantity >= getOrderQuantity(orderID))
        //                        {
        //                            Getter.SendToDB("UPDATE tbl_orders SET Full_Arrived = 1 WHERE Order_ID = '" + orderID + "'");
        //                        }
        //                        else {
        //                            Getter.SendToDB("UPDATE tbl_orders SET Full_Arrived = 0 WHERE Order_ID = '" + orderID + "'");
        //                        }
        //                        quantity = quantity - getOrderQuantity(orderID);
        //                    }
        //                    addAutomaticReorderParameters(itemID, threshold_value, reordering_amount);
        //                    //if (threshold_value != null)
        //                    //{
        //                    //    if (reordering_amount != null)
        //                    //    {
        //                    //        CheckAndSetAutomaticReordering(itemID, threshold_value, reordering_amount);
        //                    //    }
        //                    //    else
        //                    //    {
        //                    //        CheckAndSetAutomaticReordering(itemID, threshold_value, null);
        //                    //    }
        //                    //}
        //                    //else {
        //                    //    if (reordering_amount != null) {
        //                    //        CheckAndSetAutomaticReordering(itemID, null, reordering_amount);
        //                    //    }
        //                    //}

        //                    MessageBox.Show("Stock Details Changed Successfully","Operation Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
        //                    isCompleted = true;
        //                }
        //                else
        //                {
        //                    errorMessage = "No Order Information Found For Provided Details";
        //                    isCompleted = false;
        //                }
        //            }
        //            else { 
        //                errorMessage = "Entered Quantity Exceeds The Ordered Quantity."; 
        //            }
        //        }
        //    }

        //    if (errorMessage != null)
        //    {
        //        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }            
        //    return isCompleted;
        //}
    }
}
