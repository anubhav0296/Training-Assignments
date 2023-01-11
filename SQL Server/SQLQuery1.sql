select * from Customer

select * from Orders

Create table Product 
( 
Id int,
ProductName nvarchar(50),
UnitPrice decimal(12,2),
Package nvarchar(30),
IsDiscontinued bit,
primary key(Id)
);

select * from Product

Create table OrderItem
( Id int primary key,
OrderId int foreign key references Orders(Id),
ProductId int foreign key references Product(Id),
UnitPrice decimal(12,2),
Quantity int );

select * from OrderItem


