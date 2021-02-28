SET IDENTITY_INSERT [dbo].[Client] ON
INSERT INTO [dbo].[Client] ([Id], [Name], [Email], [Vetran]) VALUES (1, N'Peter Clark', N'peter@gmail.com', 1)
INSERT INTO [dbo].[Client] ([Id], [Name], [Email], [Vetran]) VALUES (2, N'Kevin Harrison ', N'kevin@gmail.com', 0)
SET IDENTITY_INSERT [dbo].[Client] OFF
SET IDENTITY_INSERT [dbo].[Project] ON
INSERT INTO [dbo].[Project] ([Id], [ProjectTitle], [Details], [Budget], [ClientId]) VALUES (1, N'Remote Monitoring System Web app', N'A Web app to monitor and control, homes remotely', CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT INTO [dbo].[Project] ([Id], [ProjectTitle], [Details], [Budget], [ClientId]) VALUES (2, N'Online Delivery Web app', N'A Web app for a goods delivery company', CAST(2000.00 AS Decimal(18, 2)), 2)
SET IDENTITY_INSERT [dbo].[Project] OFF
SET IDENTITY_INSERT [dbo].[Developer] ON
INSERT INTO [dbo].[Developer] ([Id], [Name], [Experience]) VALUES (1, N'Johnathan Hays', 10)
INSERT INTO [dbo].[Developer] ([Id], [Name], [Experience]) VALUES (2, N'Will Thompson', 12)
SET IDENTITY_INSERT [dbo].[Developer] OFF
SET IDENTITY_INSERT [dbo].[Bid] ON
INSERT INTO [dbo].[Bid] ([Id], [BidValue], [ProjectId], [DeveloperId]) VALUES (1, CAST(2500.00 AS Decimal(18, 2)), 1, 1)
INSERT INTO [dbo].[Bid] ([Id], [BidValue], [ProjectId], [DeveloperId]) VALUES (2, CAST(2000.00 AS Decimal(18, 2)), 1, 2)
INSERT INTO [dbo].[Bid] ([Id], [BidValue], [ProjectId], [DeveloperId]) VALUES (3, CAST(1500.00 AS Decimal(18, 2)), 2, 1)
SET IDENTITY_INSERT [dbo].[Bid] OFF
