create database MindboxTest
go
use MindBoxTest
go
create table Products(
Id int primary key identity(1,1),
Name nvarchar(max))

create table Categories(
Id int primary key identity(1,1),
Name nvarchar(max))

create table ProductsCategories(
Id int primary key identity(1,1),
ProductId int,
CategoryId int,
foreign key (ProductId) references Products(Id),
foreign key (CategoryId) references Categories(Id),
)
go

Insert into Products(Name)
Values
('���� N1'),
('���� N2'),
('���� N3'),
('���� N4'),
('��������� �������� N1'),
('��������� �������� N2'),
('��������� �������� N3'),
('��������� �������� N4'),
('�������� ����� N1')

insert into Categories(Name)
Values
('��������'),
('�������'),
('����')

insert into ProductsCategories(ProductId, CategoryId)
values
(1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,1),
(7,1),
(8,1),
(1,2),
(2,2),
(3,2),
(4,2),
(5,3),
(6,3),
(7,3),
(8,3)

go