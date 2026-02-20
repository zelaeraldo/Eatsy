INSERT INTO dbo.Customers(Id, FullName, PhoneNumber, Address) VALUES
(1, 'john doe', '06839250528', 'selite'),
(2, 'joe mama', '06839262828', 'bllok'),
(3, 'the rock', '45374754256', 'liqen'),
(4, 'silv vista', '06839250528', 'kombinat'),
(5, 'dush rima', '46246363678', 'tufine');

INSERT INTO dbo.Restaurants(Id, Name, Address, Description) VALUES
(1, 'Burger Heaven', 'ISH-PARK', 'Specialist ne gatime zgare'),
(2,'Sushi World', '21', 'Specialist ne hamburger'),
(3, 'Pasta Paradise', 'selite', 'Picat me te mira'),
(4, 'KFC', 'TEG', 'MENU E GJITHANESHME');

INSERT INTO dbo.CartItems (Id, CartId,ProductId,  Quantity, UnitPrice) VALUES
(1,1,1,1, 3.99),
(2,2,2,3, 7.99),
(3,3,3,4, 5.99);

INSERT INTO dbo.Carts(Id,CustomerId ) VALUES
(1,1),
(2,4),
(3,6);

INSERT INTO dbo.DeliveryDrivers(Id, FullName, VehicleDetails, PhoneNumber) values
(1, 'bes pum', 'abc', '428936529'),
(2, 'er ze', 'dht4', '56932465834'),
(3, 'ger ces', 'jf4', '4826295692');

INSERT INTO dbo.OrderDetails(Id, OrderId, ProductId, Quantity, UnitPrice) values
(1,1,1, 2, 3.00 ),
(2,2,2,4, 4.00),
(3,3,3,2, 6.00);

Insert into dbo.Orders(Id,CustomerId, DeliveryDriverId, OrderDate, TotalAmount, Status) values
(1,1,1, 20-02-2003, 20, delivered),
(2,2,2, 3-03-2003, 13, pending),
(3,3,3, 9-12-1234, 40, cancelled);

insert into dbo.Payments(Id, OrderId, PaymentDate, PaymentMethod, Amount, IsSuccessful) values
(1,1, 1-1-1, card, 20, yes),
(2,2, 2-2-2, cash, 40, yes),
(3,3, 3-3-3, paypal, 23, no);

insert into dbo.Products(Id, RestaurantId, Name, Price) values
(1,1, burger, 10),
(2,2, pizza, 15),
(3,3, supe, 20);

insert into dbo.Reviews( Id, CustomerId, ProductId, ReviewDate, Rating, Comment) values
(1,1,1, 2-2-2, 5, 'ushqim dhe sherbim shum i mir'),
(2,2,2, 3-3-3, 1, 'ushqim skamdaloz dhe vones dergimi');
