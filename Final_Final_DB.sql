USE [ITP_Final]
GO
/****** Object:  Table [dbo].[Vehicle_Request_Details]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehicle_Request_Details](
	[RequestNo] [int] NOT NULL,
	[Type] [varchar](70) NULL,
	[RegistrationNo] [int] NULL,
	[RequestDate] [date] NULL,
	[RequestTime] [time](7) NULL,
	[PlaceOfArrival] [varchar](70) NULL,
	[PlaceOfDepature] [varchar](70) NULL,
 CONSTRAINT [pk26] PRIMARY KEY CLUSTERED 
(
	[RequestNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vehicle_Details]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehicle_Details](
	[VehicleNo] [int] NOT NULL,
	[RegistrationNo] [int] NULL,
	[VehicleType] [varchar](70) NULL,
	[ModelName] [varchar](70) NULL,
	[BrandName] [varchar](70) NULL,
	[SeatCapacity] [int] NULL,
	[FuelType] [varchar](70) NULL,
 CONSTRAINT [c1] PRIMARY KEY CLUSTERED 
(
	[VehicleNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_suppliers]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_suppliers](
	[Supplier_ID] [varchar](10) NOT NULL,
	[Supplier_Name] [varchar](50) NOT NULL,
 CONSTRAINT [tbl_supplier_dealers_pk] PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_supplier_details]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_supplier_details](
	[Supplier_ID] [int] IDENTITY(1,1) NOT NULL,
	[Supplier_Name] [varchar](40) NOT NULL,
	[Country] [varchar](10) NOT NULL,
	[Country_Code] [int] NOT NULL,
	[Phone_Number] [varchar](15) NOT NULL,
	[Email_Address] [varchar](30) NOT NULL,
	[Bank_Name] [varchar](30) NOT NULL,
	[Account_Number] [int] NOT NULL,
 CONSTRAINT [tbl_supplier_details_pk] PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_orders]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_orders](
	[Order_ID] [varchar](10) NOT NULL,
	[Full_Arrived] [bit] NOT NULL,
	[Brand] [varchar](50) NOT NULL,
	[Ordered_Date] [date] NOT NULL,
	[Ordered_Time] [time](7) NULL,
 CONSTRAINT [tbl_order_pk] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Return_Compo]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Return_Compo](
	[hire_id] [varchar](50) NOT NULL,
	[event_name] [varchar](50) NOT NULL,
	[hired_compo] [varchar](50) NOT NULL,
	[count] [varchar](50) NOT NULL,
	[lost] [varchar](50) NOT NULL,
	[lcharge] [real] NULL,
	[damage] [varchar](50) NOT NULL,
	[dcharge] [real] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Assing_Staff]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Assing_Staff](
	[emp_id] [varchar](50) NOT NULL,
	[event_name] [varchar](max) NOT NULL,
	[emp_name] [varchar](max) NOT NULL,
	[designation] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Assing_Staff] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Project]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Project](
	[ProjectID] [varchar](25) NOT NULL,
	[Title] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
	[ClientCompany] [varchar](20) NULL,
	[ClientID] [varchar](20) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[Duration] [int] NULL,
	[NumberOfSubtasks] [int] NULL,
	[ProjectColor] [int] NULL,
 CONSTRAINT [Project_const] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Payment](
	[hired_id] [varchar](50) NOT NULL,
	[event_name] [varchar](max) NOT NULL,
	[deposit] [int] NULL,
	[hired_compo_charges] [int] NOT NULL,
	[extra_charge] [int] NULL,
	[Transpotation] [int] NOT NULL,
	[Customer_name] [varchar](50) NOT NULL,
	[date] [date] NOT NULL,
	[Total_amount] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[customer]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customer](
	[Company_Name] [varchar](20) NOT NULL,
	[Fname] [varchar](20) NOT NULL,
	[Lname] [varchar](20) NOT NULL,
	[Address1] [varchar](50) NOT NULL,
	[Address2] [varchar](50) NOT NULL,
	[Contact_Number] [int] NOT NULL,
	[DOB] [date] NOT NULL,
	[category] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [c_pk1] PRIMARY KEY CLUSTERED 
(
	[Contact_Number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Calendar]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Calendar](
	[id] [char](20) NOT NULL,
	[month] [int] NULL,
	[sunday] [varchar](50) NULL,
	[saturday] [varchar](50) NULL,
	[public_holiday] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Booking_Details]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Booking_Details](
	[booking_id] [varchar](50) NOT NULL,
	[event_name] [varchar](100) NOT NULL,
	[event_id] [varchar](50) NULL,
	[cus_name] [varchar](100) NOT NULL,
	[count] [int] NOT NULL,
	[date] [date] NOT NULL,
	[amount] [float] NOT NULL,
 CONSTRAINT [PK_Booking_Details_1] PRIMARY KEY CLUSTERED 
(
	[booking_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Insurance_Details]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Insurance_Details](
	[InsuranceNo] [int] NOT NULL,
	[InsuranceCompanyName] [varchar](70) NULL,
	[InsuranceType] [varchar](70) NULL,
	[RegistrationNo] [int] NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
 CONSTRAINT [pk25] PRIMARY KEY CLUSTERED 
(
	[InsuranceNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hired_Compo_Details]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hired_Compo_Details](
	[hire_id] [varchar](50) NOT NULL,
	[event_name] [varchar](255) NOT NULL,
	[hired_compo] [varchar](50) NOT NULL,
	[price] [varchar](50) NOT NULL,
	[count] [varchar](50) NOT NULL,
	[date] [date] NOT NULL,
	[no_of_date] [int] NOT NULL,
	[phone] [int] NOT NULL,
	[cus_name] [varchar](255) NOT NULL,
	[venu] [varchar](50) NOT NULL,
	[soft_cost] [varchar](50) NOT NULL,
	[reg_cus] [varchar](10) NOT NULL,
	[deposit] [varchar](50) NULL,
	[status] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fuel_Details]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fuel_Details](
	[ReceiptNo] [int] NOT NULL,
	[FuelType] [varchar](70) NULL,
	[RegistrationNo] [int] NULL,
	[FuelStation] [varchar](70) NULL,
	[Date] [date] NULL,
	[Time] [time](7) NULL,
	[MeterReading] [varchar](70) NULL,
	[Efficiency] [varchar](70) NULL,
	[Amount] [int] NULL,
 CONSTRAINT [pk27] PRIMARY KEY CLUSTERED 
(
	[ReceiptNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[External_Travel_Agencies]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[External_Travel_Agencies](
	[ContractorCode] [int] NOT NULL,
	[Type] [varchar](70) NULL,
	[OwnerName] [varchar](70) NULL,
	[ContactNo] [int] NULL,
	[AgreementDate] [date] NULL,
	[AgreementExpiryDate] [date] NULL,
 CONSTRAINT [c5] PRIMARY KEY CLUSTERED 
(
	[ContractorCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Event_Details]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Event_Details](
	[event_id] [varchar](50) NOT NULL,
	[event_name] [varchar](500) NOT NULL,
	[category] [varchar](50) NOT NULL,
	[type] [varchar](50) NOT NULL,
	[venu] [varchar](100) NOT NULL,
	[date] [date] NOT NULL,
	[time] [datetime] NOT NULL,
	[spon_type] [varchar](50) NOT NULL,
	[T_price] [int] NULL,
	[img] [image] NULL,
 CONSTRAINT [PK_Event_Details] PRIMARY KEY CLUSTERED 
(
	[event_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[employee_details]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employee_details](
	[emp_code] [char](5) NOT NULL,
	[name_initials] [varchar](70) NOT NULL,
	[full_name] [varchar](70) NOT NULL,
	[sex] [varchar](45) NOT NULL,
	[dob] [date] NOT NULL,
	[nic] [char](10) NOT NULL,
	[nationality] [varchar](45) NULL,
	[bank_name] [varchar](30) NOT NULL,
	[b_branch] [varchar](30) NOT NULL,
	[acc_no] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[acc_no] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[emp_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nic] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_payment]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_payment](
	[Invoice_No] [varchar](10) NOT NULL,
	[Order_ID] [varchar](10) NOT NULL,
	[Supplier_Name] [varchar](50) NOT NULL,
	[Country] [varchar](10) NOT NULL,
	[Payment_Method] [varchar](10) NOT NULL,
	[Payment_Date] [datetime] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Total_Amount] [float] NOT NULL,
 CONSTRAINT [tbl_payment_pk] PRIMARY KEY CLUSTERED 
(
	[Invoice_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[salary_and_tax_details]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[salary_and_tax_details](
	[emp_code] [char](5) NOT NULL,
	[basic_salary] [real] NOT NULL,
	[epfAmt] [real] NULL,
	[tot_epf] [real] NULL,
	[etfAmt] [real] NULL,
	[paye_percentage] [real] NULL,
	[paye_amt] [real] NULL,
	[ot_amt] [real] NULL,
	[bonus] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[employee_contacts]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employee_contacts](
	[emp_code] [char](5) NOT NULL,
	[residance_add] [varchar](50) NOT NULL,
	[temp_address] [varchar](50) NULL,
	[residance_tpno] [char](10) NOT NULL,
	[mobile_no] [char](10) NOT NULL,
	[personal_email] [varchar](50) NOT NULL,
	[office_email] [varchar](50) NOT NULL,
	[contact_person] [varchar](50) NULL,
	[relationship] [varchar](20) NULL,
	[tp_contactPerson] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_code] ASC,
	[mobile_no] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer_order]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer_order](
	[Bill_No] [varchar](10) NOT NULL,
	[Contact_Number] [int] NOT NULL,
	[Return_Date] [datetime] NULL,
	[Transport_Facilities] [char](3) NULL,
	[Delivery_Address] [varchar](50) NULL,
 CONSTRAINT [co_pk1] PRIMARY KEY CLUSTERED 
(
	[Bill_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[experiances]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[experiances](
	[emp_code] [char](5) NOT NULL,
	[exp_id] [char](20) NOT NULL,
	[org_name] [varchar](50) NULL,
	[department] [varchar](20) NULL,
	[position] [varchar](20) NULL,
	[from_date] [date] NULL,
	[to_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_code] ASC,
	[exp_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[exp_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[attendance]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[attendance](
	[emp_code] [char](5) NOT NULL,
	[AID] [varchar](30) NOT NULL,
	[in_time] [datetime] NULL,
	[out_time] [datetime] NULL,
	[ot_hrs] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_code] ASC,
	[AID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[qualifications]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[qualifications](
	[emp_code] [char](5) NOT NULL,
	[qual_id] [char](20) NOT NULL,
	[edu_qual] [varchar](70) NULL,
	[prof_qual] [varchar](70) NULL,
	[other_qual] [varchar](70) NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_code] ASC,
	[qual_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[qual_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProjectObjectives]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProjectObjectives](
	[ProjectID] [varchar](25) NOT NULL,
	[Objectives] [varchar](500) NULL,
	[Stratergies] [varchar](500) NULL,
 CONSTRAINT [obj_1] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProjectBudget]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[ProjectBudget](
	[ProjectID] [varchar](25) NOT NULL,
	[Staffing] [float] NULL,
	[Material] [float] NULL,
	[Tax] [float] NULL,
	[Total] [float] NULL,
 CONSTRAINT [project_budget1_const1] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Project_Progress]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Project_Progress](
	[ProjectID] [varchar](25) NOT NULL,
	[Percentage] [float] NULL,
 CONSTRAINT [ProjectProgress_const1] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[leaves_taken]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[leaves_taken](
	[emp_code] [char](5) NOT NULL,
	[leave_id] [char](10) NOT NULL,
	[leave_type] [varchar](50) NOT NULL,
	[from_date] [date] NULL,
	[to_date] [date] NULL,
	[no_of_days] [int] NULL,
	[half_days] [int] NULL,
	[date] [date] NULL,
	[pay] [char](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_code] ASC,
	[leave_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[leaves_left]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[leaves_left](
	[emp_code] [char](5) NOT NULL,
	[annual] [int] NULL,
	[casual] [int] NULL,
	[sick] [int] NULL,
	[half_days] [real] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_items]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_items](
	[Model] [varchar](50) NOT NULL,
	[Brand] [varchar](40) NOT NULL,
	[Coustomer_Category] [varchar](50) NOT NULL,
	[Supplier_ID] [int] NOT NULL,
	[Country] [varchar](10) NOT NULL,
	[Good_Recipient] [varchar](20) NOT NULL,
	[Threshold_Value] [int] NULL,
	[Reordering_Amount] [int] NULL,
	[Unit_Price] [int] NULL,
	[Category] [varchar](50) NULL,
	[Type] [varchar](20) NULL,
 CONSTRAINT [tbl_items_pk] PRIMARY KEY CLUSTERED 
(
	[Model] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subtask]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subtask](
	[SubtaskID] [varchar](25) NOT NULL,
	[ProjectID] [varchar](25) NULL,
	[SubtaskName] [varchar](50) NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[Duration] [int] NULL,
 CONSTRAINT [subtask_const1] PRIMARY KEY CLUSTERED 
(
	[SubtaskID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[office_detail]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[office_detail](
	[emp_code] [char](5) NOT NULL,
	[department] [varchar](45) NOT NULL,
	[designation] [varchar](45) NOT NULL,
	[active] [varchar](5) NOT NULL,
	[probation_date] [date] NOT NULL,
	[resignation_date] [date] NULL,
	[confirm_date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_supplier_brands]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_supplier_brands](
	[Supplier_ID] [varchar](10) NOT NULL,
	[Brand] [varchar](50) NOT NULL,
 CONSTRAINT [tbl_supplier_pk] PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC,
	[Brand] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_stocks]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_stocks](
	[Stock_ID] [varchar](10) NOT NULL,
	[Model] [varchar](50) NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [tbl_stock_pk] PRIMARY KEY CLUSTERED 
(
	[Stock_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ordered_Item_details]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ordered_Item_details](
	[Item_ID] [varchar](10) NOT NULL,
	[Order_ID] [varchar](10) NULL,
	[Model] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Available] [bit] NOT NULL,
 CONSTRAINT [tbl_ordered_Item_details_pk] PRIMARY KEY CLUSTERED 
(
	[Item_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Receipt](
	[contact_number] [int] NOT NULL,
	[bill_no] [varchar](10) NOT NULL,
	[img] [image] NULL,
 CONSTRAINT [rec_pk1] PRIMARY KEY CLUSTERED 
(
	[contact_number] ASC,
	[bill_no] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Material]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Material](
	[AllocatedID] [varchar](25) NOT NULL,
	[ProjectID] [varchar](25) NULL,
	[SubtaskID] [varchar](25) NULL,
	[Type] [varchar](50) NULL,
	[Description] [varchar](25) NULL,
	[ItemID] [varchar](10) NULL,
	[Amount] [float] NULL,
 CONSTRAINT [Material_const1] PRIMARY KEY CLUSTERED 
(
	[AllocatedID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Staff](
	[JobID] [varchar](25) NOT NULL,
	[ProjectID] [varchar](25) NULL,
	[SubtaskID] [varchar](25) NULL,
	[EmployeeID] [varchar](50) NULL,
	[Designation] [varchar](35) NULL,
	[Role] [varchar](25) NULL,
	[Charges] [float] NULL,
 CONSTRAINT [staff_const1] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Selected_Items]    Script Date: 11/23/2017 00:01:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Selected_Items](
	[Bill_No] [varchar](10) NOT NULL,
	[Item_No] [varchar](50) NOT NULL,
	[Contact_Number] [int] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [si_pk1] PRIMARY KEY CLUSTERED 
(
	[Bill_No] ASC,
	[Item_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Advance_Bill]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Advance_Bill](
	[Bill_No] [varchar](10) NOT NULL,
	[Item_No] [varchar](50) NOT NULL,
	[Quantity] [int] NULL,
	[Unit_Price] [float] NULL,
	[Total_Amount] [float] NULL,
 CONSTRAINT [ab_pk1] PRIMARY KEY CLUSTERED 
(
	[Bill_No] ASC,
	[Item_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pay_Advance]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pay_Advance](
	[Payment_Id] [varchar](10) NOT NULL,
	[Bill_No] [varchar](10) NULL,
	[Advance] [float] NULL,
	[Total_Amount] [float] NULL,
	[pay_Date] [datetime] NULL,
 CONSTRAINT [pa_pk1] PRIMARY KEY CLUSTERED 
(
	[Payment_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pay]    Script Date: 11/23/2017 00:01:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pay](
	[Payment_Id] [varchar](10) NOT NULL,
	[Bill_No] [varchar](10) NULL,
	[Advance] [float] NULL,
	[Full_payment] [float] NULL,
	[Total_Amount] [float] NULL,
	[pay_Date] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__attendanc__in_ti__5BE2A6F2]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[attendance] ADD  DEFAULT (NULL) FOR [in_time]
GO
/****** Object:  Default [DF__attendanc__out_t__5CD6CB2B]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[attendance] ADD  DEFAULT (NULL) FOR [out_time]
GO
/****** Object:  Default [DF__employee___conta__5DCAEF64]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[employee_contacts] ADD  DEFAULT (NULL) FOR [contact_person]
GO
/****** Object:  Default [DF__employee___relat__5EBF139D]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[employee_contacts] ADD  DEFAULT (NULL) FOR [relationship]
GO
/****** Object:  Default [DF__employee___tp_co__5FB337D6]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[employee_contacts] ADD  DEFAULT (NULL) FOR [tp_contactPerson]
GO
/****** Object:  Default [DF__experianc__org_n__60A75C0F]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[experiances] ADD  DEFAULT (NULL) FOR [org_name]
GO
/****** Object:  Default [DF__experianc__depar__619B8048]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[experiances] ADD  DEFAULT (NULL) FOR [department]
GO
/****** Object:  Default [DF__experianc__posit__628FA481]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[experiances] ADD  DEFAULT (NULL) FOR [position]
GO
/****** Object:  Default [DF__leaves_ta__from___6383C8BA]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[leaves_taken] ADD  DEFAULT (NULL) FOR [from_date]
GO
/****** Object:  Default [DF__leaves_ta__to_da__6477ECF3]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[leaves_taken] ADD  DEFAULT (NULL) FOR [to_date]
GO
/****** Object:  Default [DF__leaves_ta__no_of__656C112C]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[leaves_taken] ADD  DEFAULT (NULL) FOR [no_of_days]
GO
/****** Object:  Default [DF__leaves_tak__date__66603565]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[leaves_taken] ADD  DEFAULT (NULL) FOR [date]
GO
/****** Object:  Default [DF__qualifica__edu_q__6754599E]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[qualifications] ADD  DEFAULT (NULL) FOR [edu_qual]
GO
/****** Object:  Default [DF__qualifica__prof___68487DD7]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[qualifications] ADD  DEFAULT (NULL) FOR [prof_qual]
GO
/****** Object:  Default [DF__qualifica__other__693CA210]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[qualifications] ADD  DEFAULT (NULL) FOR [other_qual]
GO
/****** Object:  Default [DF__salary_an__epfAm__6A30C649]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[salary_and_tax_details] ADD  DEFAULT (NULL) FOR [epfAmt]
GO
/****** Object:  Default [DF__salary_an__etfAm__6B24EA82]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[salary_and_tax_details] ADD  DEFAULT (NULL) FOR [etfAmt]
GO
/****** Object:  Default [DF__tbl_order__Avail__6C190EBB]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[tbl_ordered_Item_details] ADD  DEFAULT ((0)) FOR [Available]
GO
/****** Object:  Default [DF__tbl_order__Full___6D0D32F4]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[tbl_orders] ADD  DEFAULT ((0)) FOR [Full_Arrived]
GO
/****** Object:  Check [CK__Customer___Trans__03F0984C]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[Customer_order]  WITH CHECK ADD CHECK  (([transport_Facilities]='no' OR [transport_Facilities]='yes'))
GO
/****** Object:  ForeignKey [ab_fk1]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[Advance_Bill]  WITH CHECK ADD  CONSTRAINT [ab_fk1] FOREIGN KEY([Bill_No])
REFERENCES [dbo].[Customer_order] ([Bill_No])
GO
ALTER TABLE [dbo].[Advance_Bill] CHECK CONSTRAINT [ab_fk1]
GO
/****** Object:  ForeignKey [ab_fk2]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[Advance_Bill]  WITH CHECK ADD  CONSTRAINT [ab_fk2] FOREIGN KEY([Item_No])
REFERENCES [dbo].[tbl_items] ([Model])
GO
ALTER TABLE [dbo].[Advance_Bill] CHECK CONSTRAINT [ab_fk2]
GO
/****** Object:  ForeignKey [fk8]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[attendance]  WITH CHECK ADD  CONSTRAINT [fk8] FOREIGN KEY([emp_code])
REFERENCES [dbo].[employee_details] ([emp_code])
GO
ALTER TABLE [dbo].[attendance] CHECK CONSTRAINT [fk8]
GO
/****** Object:  ForeignKey [co_fk1]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[Customer_order]  WITH CHECK ADD  CONSTRAINT [co_fk1] FOREIGN KEY([Contact_Number])
REFERENCES [dbo].[customer] ([Contact_Number])
GO
ALTER TABLE [dbo].[Customer_order] CHECK CONSTRAINT [co_fk1]
GO
/****** Object:  ForeignKey [fk1]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[employee_contacts]  WITH CHECK ADD  CONSTRAINT [fk1] FOREIGN KEY([emp_code])
REFERENCES [dbo].[employee_details] ([emp_code])
GO
ALTER TABLE [dbo].[employee_contacts] CHECK CONSTRAINT [fk1]
GO
/****** Object:  ForeignKey [fk3]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[experiances]  WITH CHECK ADD  CONSTRAINT [fk3] FOREIGN KEY([emp_code])
REFERENCES [dbo].[employee_details] ([emp_code])
GO
ALTER TABLE [dbo].[experiances] CHECK CONSTRAINT [fk3]
GO
/****** Object:  ForeignKey [fk11]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[leaves_left]  WITH CHECK ADD  CONSTRAINT [fk11] FOREIGN KEY([emp_code])
REFERENCES [dbo].[employee_details] ([emp_code])
GO
ALTER TABLE [dbo].[leaves_left] CHECK CONSTRAINT [fk11]
GO
/****** Object:  ForeignKey [fk10]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[leaves_taken]  WITH CHECK ADD  CONSTRAINT [fk10] FOREIGN KEY([emp_code])
REFERENCES [dbo].[employee_details] ([emp_code])
GO
ALTER TABLE [dbo].[leaves_taken] CHECK CONSTRAINT [fk10]
GO
/****** Object:  ForeignKey [Material_const2]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [Material_const2] FOREIGN KEY([SubtaskID])
REFERENCES [dbo].[Subtask] ([SubtaskID])
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [Material_const2]
GO
/****** Object:  ForeignKey [fk4]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[office_detail]  WITH CHECK ADD  CONSTRAINT [fk4] FOREIGN KEY([emp_code])
REFERENCES [dbo].[employee_details] ([emp_code])
GO
ALTER TABLE [dbo].[office_detail] CHECK CONSTRAINT [fk4]
GO
/****** Object:  ForeignKey [pay_fk1]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[Pay]  WITH CHECK ADD  CONSTRAINT [pay_fk1] FOREIGN KEY([Payment_Id])
REFERENCES [dbo].[Pay_Advance] ([Payment_Id])
GO
ALTER TABLE [dbo].[Pay] CHECK CONSTRAINT [pay_fk1]
GO
/****** Object:  ForeignKey [pay_fk2]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[Pay]  WITH CHECK ADD  CONSTRAINT [pay_fk2] FOREIGN KEY([Bill_No])
REFERENCES [dbo].[Customer_order] ([Bill_No])
GO
ALTER TABLE [dbo].[Pay] CHECK CONSTRAINT [pay_fk2]
GO
/****** Object:  ForeignKey [pa_fk1]    Script Date: 11/23/2017 00:01:32 ******/
ALTER TABLE [dbo].[Pay_Advance]  WITH CHECK ADD  CONSTRAINT [pa_fk1] FOREIGN KEY([Bill_No])
REFERENCES [dbo].[Customer_order] ([Bill_No])
GO
ALTER TABLE [dbo].[Pay_Advance] CHECK CONSTRAINT [pa_fk1]
GO
/****** Object:  ForeignKey [Project_Progress_const2]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[Project_Progress]  WITH CHECK ADD  CONSTRAINT [Project_Progress_const2] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Project] ([ProjectID])
GO
ALTER TABLE [dbo].[Project_Progress] CHECK CONSTRAINT [Project_Progress_const2]
GO
/****** Object:  ForeignKey [projectbudget2_const22]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[ProjectBudget]  WITH CHECK ADD  CONSTRAINT [projectbudget2_const22] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Project] ([ProjectID])
GO
ALTER TABLE [dbo].[ProjectBudget] CHECK CONSTRAINT [projectbudget2_const22]
GO
/****** Object:  ForeignKey [obj_2]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[ProjectObjectives]  WITH CHECK ADD  CONSTRAINT [obj_2] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Project] ([ProjectID])
GO
ALTER TABLE [dbo].[ProjectObjectives] CHECK CONSTRAINT [obj_2]
GO
/****** Object:  ForeignKey [fk2]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[qualifications]  WITH CHECK ADD  CONSTRAINT [fk2] FOREIGN KEY([emp_code])
REFERENCES [dbo].[employee_details] ([emp_code])
GO
ALTER TABLE [dbo].[qualifications] CHECK CONSTRAINT [fk2]
GO
/****** Object:  ForeignKey [rec_fk1]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [rec_fk1] FOREIGN KEY([contact_number])
REFERENCES [dbo].[customer] ([Contact_Number])
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [rec_fk1]
GO
/****** Object:  ForeignKey [rec_fk2]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [rec_fk2] FOREIGN KEY([bill_no])
REFERENCES [dbo].[Customer_order] ([Bill_No])
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [rec_fk2]
GO
/****** Object:  ForeignKey [fk5]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[salary_and_tax_details]  WITH CHECK ADD  CONSTRAINT [fk5] FOREIGN KEY([emp_code])
REFERENCES [dbo].[employee_details] ([emp_code])
GO
ALTER TABLE [dbo].[salary_and_tax_details] CHECK CONSTRAINT [fk5]
GO
/****** Object:  ForeignKey [si_fk1]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[Selected_Items]  WITH CHECK ADD  CONSTRAINT [si_fk1] FOREIGN KEY([Item_No])
REFERENCES [dbo].[tbl_items] ([Model])
GO
ALTER TABLE [dbo].[Selected_Items] CHECK CONSTRAINT [si_fk1]
GO
/****** Object:  ForeignKey [si_fk2]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[Selected_Items]  WITH CHECK ADD  CONSTRAINT [si_fk2] FOREIGN KEY([Bill_No])
REFERENCES [dbo].[Customer_order] ([Bill_No])
GO
ALTER TABLE [dbo].[Selected_Items] CHECK CONSTRAINT [si_fk2]
GO
/****** Object:  ForeignKey [si_fk3]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[Selected_Items]  WITH CHECK ADD  CONSTRAINT [si_fk3] FOREIGN KEY([Contact_Number])
REFERENCES [dbo].[customer] ([Contact_Number])
GO
ALTER TABLE [dbo].[Selected_Items] CHECK CONSTRAINT [si_fk3]
GO
/****** Object:  ForeignKey [staff_const2]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [staff_const2] FOREIGN KEY([SubtaskID])
REFERENCES [dbo].[Subtask] ([SubtaskID])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [staff_const2]
GO
/****** Object:  ForeignKey [subtask_const2]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[Subtask]  WITH CHECK ADD  CONSTRAINT [subtask_const2] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Project] ([ProjectID])
GO
ALTER TABLE [dbo].[Subtask] CHECK CONSTRAINT [subtask_const2]
GO
/****** Object:  ForeignKey [tbl_items_fk_1]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[tbl_items]  WITH CHECK ADD  CONSTRAINT [tbl_items_fk_1] FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[tbl_supplier_details] ([Supplier_ID])
GO
ALTER TABLE [dbo].[tbl_items] CHECK CONSTRAINT [tbl_items_fk_1]
GO
/****** Object:  ForeignKey [tbl_ordered_Item_details_fk1]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[tbl_ordered_Item_details]  WITH CHECK ADD  CONSTRAINT [tbl_ordered_Item_details_fk1] FOREIGN KEY([Model])
REFERENCES [dbo].[tbl_items] ([Model])
GO
ALTER TABLE [dbo].[tbl_ordered_Item_details] CHECK CONSTRAINT [tbl_ordered_Item_details_fk1]
GO
/****** Object:  ForeignKey [tbl_ordered_Item_details_fk2]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[tbl_ordered_Item_details]  WITH CHECK ADD  CONSTRAINT [tbl_ordered_Item_details_fk2] FOREIGN KEY([Order_ID])
REFERENCES [dbo].[tbl_orders] ([Order_ID])
GO
ALTER TABLE [dbo].[tbl_ordered_Item_details] CHECK CONSTRAINT [tbl_ordered_Item_details_fk2]
GO
/****** Object:  ForeignKey [tbl_payment_fk_1]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[tbl_payment]  WITH CHECK ADD  CONSTRAINT [tbl_payment_fk_1] FOREIGN KEY([Order_ID])
REFERENCES [dbo].[tbl_orders] ([Order_ID])
GO
ALTER TABLE [dbo].[tbl_payment] CHECK CONSTRAINT [tbl_payment_fk_1]
GO
/****** Object:  ForeignKey [tbl_stock_fk_2]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[tbl_stocks]  WITH CHECK ADD  CONSTRAINT [tbl_stock_fk_2] FOREIGN KEY([Model])
REFERENCES [dbo].[tbl_items] ([Model])
GO
ALTER TABLE [dbo].[tbl_stocks] CHECK CONSTRAINT [tbl_stock_fk_2]
GO
/****** Object:  ForeignKey [tbl_supplier_fk]    Script Date: 11/23/2017 00:01:33 ******/
ALTER TABLE [dbo].[tbl_supplier_brands]  WITH CHECK ADD  CONSTRAINT [tbl_supplier_fk] FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[tbl_suppliers] ([Supplier_ID])
GO
ALTER TABLE [dbo].[tbl_supplier_brands] CHECK CONSTRAINT [tbl_supplier_fk]
GO
