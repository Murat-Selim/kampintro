﻿--Select
--ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

Select * from Products where categoryId=1 or categoryId=3

Select * from Products where categoryId=1 and UnitPrice>=10

select * from Products where categoryId=1 order by UnitPrice desc --ascending --descending

Select count(*) Adet from Products where categoryId=1

Select categoryID,count(*) from Products  where UnitPrice>20
group by CategoryID having count(*)<10

select products.ProductID, products.ProductName, products.UnitPrice, Categories.CategoryName
from products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

