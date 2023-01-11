select * from Customer

select * from Orders

select * from Product

select * from OrderItem

Insert into Customer values (101, 'Anubhav','Srivastava', 'Mumbai', 'India', 12345);
Insert into Customer values (102, 'Rajdeep','Sardesai', 'Mumbai', 'India', 12389);
Insert into Customer values (107, 'Aniket','Dhanait', 'Mumbai', 'India', 12367);
Insert into Customer values (109, 'Prinshu','Singh', 'Videsh', 'Germany', 12980);


Insert into Orders values (12, 2022-01-01, 144, 101, 2000);
Insert into Orders values (13, 2022-01-10, 144, 102, 6000);
Insert into Orders values (14, 2022-01-15, 144, 107, 3000);

Update Orders
set OrderDate = 2022-01-01
where Id = 12;

Update Orders
set OrderDate = 2022-01-10
where Id = 13;

Update Orders
set OrderDate = 2022-01-15
where Id = 14;


Insert into Product values (21, 'Packet1', 90, 'KC', 'False');
Insert into Product values (22, 'Packet2', 94, 'KB', 'False');
Insert into Product values (23, 'Packet3', 98, 'KD', 'True');


Insert into OrderItem values (81, 12, 21, 90, 4);
Insert into OrderItem values (82, 13, 22, 94, 6);
Insert into OrderItem values (83, 14, 23, 98, 9);

Alter table Customer
alter column Firstname
nvarchar(40) not null;

Alter table Orders
alter column OrderDate
datetime not null;

drop index IndexCustomerName on Customer;

drop index IndexOrderOrderDate on Orders;

Select Country from Customer where (FirstName like 'A%' or Firstname like 'I%');

Select * from Customer where FirstName like '__i%';

select * from Customer

select * from Orders

select * from Product

select * from OrderItem

Select * from Customer where Country = 'Germany';

Select CONCAT(FirstName,' ', LastName) as fullname from Customer;

Alter table Customer add FaxNumber int;

Update Customer
set "FaxNumber" = 590
where FirstName = 'Anubhav';

Select * from Customer where FaxNumber is Not Null;

Select * from Customer where FirstName like '_U%';

Select * from OrderItem where UnitPrice  between 10 and 20;



