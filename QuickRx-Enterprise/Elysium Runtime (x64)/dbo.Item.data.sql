INSERT INTO [dbo].[Item] ([Description], [ItemNotDiscountable], [ItemId], [ItemLookupCode], [Department], [Category], [Price], [Cost], [Quantity], [ExtendedDescription], [Inactive], [DateCreated], [ItemType], [SalesTax]) VALUES (N'Ticket', 0, 1, N'Ticket', N'CarPark', N'Ticket', CAST(2.5000 AS Decimal(19, 4)), CAST(2.5000 AS Decimal(19, 4)), 0, N'Ticket', 0, N'2012-01-01 00:00:00', N'Ticket',CAST(.15000 AS Decimal(19, 4)))
INSERT INTO [dbo].[Item] ([Description], [ItemNotDiscountable], [ItemId], [ItemLookupCode], [Department], [Category], [Price], [Cost], [Quantity], [ExtendedDescription], [Inactive], [DateCreated], [ItemType], [SalesTax]) VALUES (N'Golly Mix Drink', 0, 2, N'123', N'Groceries', N'Snacks', CAST(1.0000 AS Decimal(19, 4)), CAST(0.5000 AS Decimal(19, 4)), 100, N'Golly Mix Drink Nestle', 0, N'2012-01-01 00:00:00', N'Stock', CAST(.07000 AS Decimal(19, 4)))
