

-- CUSTOMER TABLE
CREATE TABLE Customer
(
	CustomerID INT PRIMARY KEY IDENTITY(1,1),
	UserName VARCHAR(25) NOT NULL,
	FirstName VARCHAR(20) NOT NULL,
	LastName VARCHAR(20) NOT NULL,
	EmailAddress VARCHAR(50) NOT NULL,
	Password VARCHAR(10),
	PhoneNumber BIGINT,
	DateOfBirth DATE
)

-- Shortlist table
CREATE TABLE ShortList (
	ShortListID INT PRIMARY KEY IDENTITY(1,1),
	CustomerId INT FOREIGN KEY REFERENCES Customer(CustomerID)
)

-- SHOTLISTED(FAVOURITE PRODUCTS)
CREATE TABLE ShortListItems (
	ListID INT PRIMARY KEY IDENTITY(1,1),
	ShortListId INT FOREIGN KEY REFERENCES ShortList(ShortListID),
	ProductId INT FOREIGN KEY REFERENCES Product(ProductID)
)

-- Customer Addresses table
CREATE TABLE CustomerAddresses
(
	AddressID INT PRIMARY KEY IDENTITY(1,1),
	CustomerId INT FOREIGN KEY REFERENCES Customer(CustomerID) NOT NULL,
	CustomerName VARCHAR(25) NOT NULL,
	AddressLine VARCHAR(MAX) NOT NULL,
	Pincode INT CHECK(LEN(Pincode) = 6) NOT NULL,
	Landmark VARCHAR(30),
	City VARCHAR(20) NOT NULL,
	State VARCHAR(20) NOT NULL,
	MobileNumber BIGINT NOT NULL,
	AddressType INT FOREIGN KEY REFERENCES Attribute(AttributeID)
)

-- Category table
CREATE TABLE Category (
	CategoryID INT PRIMARY KEY IDENTITY(1,1),
	CategoryName VARCHAR(30) NOT NULL,
	ParentCategory INT FOREIGN KEY REFERENCES Category(CategoryID),
	Description VARCHAR(100)
)

--BRAND TABLE
CREATE TABLE Brand (
	BrandID INT PRIMARY KEY IDENTITY(1,1),
	BrandName VARCHAR(20) NOT NULL,
	Description VARCHAR(200)
)

--PRODUCT TABLE
CREATE TABLE Product
(
	ProductID INT PRIMARY KEY IDENTITY(1,1),
	ProductName VARCHAR(255) NOT NULL,
	ProductPrice MONEY NOT NULL,
	Description VARCHAR(MAX),
	Availability VARCHAR(20) CHECK(Availability = 'InStock' or Availability = 'OutOfStock'),
	Quantity INT NOT NULL,
	Highlights VARCHAR(MAX),
	OtherSpecifications VARCHAR(MAX),
	BrandID INT FOREIGN KEY REFERENCES Brand(BrandID),
	ProductCategoryID INT FOREIGN KEY REFERENCES Category(CategoryID)
)


--PRODUCT IMAGE TABLE
CREATE TABLE ProductImages(
	ProductImageID INT PRIMARY KEY IDENTITY(1,1),
	ImageUrl NVARCHAR(MAX),
	ProductId INT FOREIGN KEY REFERENCES Product(ProductID)
)

--Master Table
CREATE TABLE MasterTable (
	AttributeTypeID INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(15) -- Size, Color, OrderStatus, PaymentStatus, PaymentType
)

-- TypeAttributes table
CREATE TABLE Attribute (
	AttributeID INT PRIMARY KEY IDENTITY(1,1),
	TypeID INT FOREIGN KEY REFERENCES MasterTable(AttributeTypeID),
	AttributesValue VARCHAR(15)
)

--PRODUCTATTRIBUTE TABLE
CREATE TABLE ProductAttributes (
	ProductAttributeID INT PRIMARY KEY,
	ProductId INT FOREIGN KEY REFERENCES Product(ProductID),
	SizeID INT FOREIGN KEY REFERENCES Attribute(AttributeID),
	ColorID INT FOREIGN KEY REFERENCES Attribute(AttributeID),
)

--Cart table
CREATE TABLE Cart
(
	CartID INT PRIMARY KEY IDENTITY(1,1),
	CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID),
	SubTotal BIGINT
)

-- Cart item table
CREATE TABLE CartItem (
	CartItemID INT PRIMARY KEY IDENTITY(1,1),
	CartId INT FOREIGN KEY REFERENCES  Cart(CartID),
	ProductId INT FOREIGN KEY REFERENCES  Product(ProductID),
	Quantity INT,
	SubTotal INT
)

-- PAYMENT TABLE
CREATE TABLE Payment
(
	PaymentID INT PRIMARY KEY IDENTITY(1,1),
	PaymentType INT FOREIGN KEY REFERENCES Attribute(AttributeID),
	PaymentDate DATE,
	PaymentStatus INT FOREIGN KEY REFERENCES Attribute(AttributeID),
	Amount MONEY
)

-- ORDERS
CREATE TABLE Orders
(
	OrderID INT PRIMARY KEY IDENTITY(1,1),
	CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID),
	Total INT,
	OrderStatus INT FOREIGN KEY REFERENCES Attribute(AttributeID),
	PaymentId INT FOREIGN KEY REFERENCES Payment(PaymenTID)
)

-- OrderItem table
CREATE TABLE OrderItems (
	OrderItemID INT PRIMARY KEY, 
	OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
	ProductId INT FOREIGN KEY REFERENCES Product(ProductID),
	Quantity INT
)
