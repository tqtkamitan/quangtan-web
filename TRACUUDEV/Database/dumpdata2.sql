use [QuangTanWeb]
GO

SET IDENTITY_INSERT [dbo].[PostType] ON 

INSERT [dbo].[PostType] ([Id], [PostTypeName], [Alias], [Logo], [Order], [IsDeleted], [CreatedDate], [UpdatedDate]) VALUES (1, N'Danh m?c 1', N'Danh-muc-1', NULL, 1, 0, CAST(N'2022-07-29T21:47:40.347' AS DateTime), NULL)
INSERT [dbo].[PostType] ([Id], [PostTypeName], [Alias], [Logo], [Order], [IsDeleted], [CreatedDate], [UpdatedDate]) VALUES (2, N'Danh m?c 2', N'Danh-muc-2', NULL, 2, 0, CAST(N'2022-07-29T21:47:47.200' AS DateTime), NULL)
INSERT [dbo].[PostType] ([Id], [PostTypeName], [Alias], [Logo], [Order], [IsDeleted], [CreatedDate], [UpdatedDate]) VALUES (3, N'Danh m?c 3', N'Danh-muc-3', NULL, 3, 0, CAST(N'2022-07-29T21:47:55.427' AS DateTime), NULL)
INSERT [dbo].[PostType] ([Id], [PostTypeName], [Alias], [Logo], [Order], [IsDeleted], [CreatedDate], [UpdatedDate]) VALUES (4, N'Danh m?c 4', N'Danh-muc-4', NULL, 4, 0, CAST(N'2022-07-29T21:48:00.883' AS DateTime), NULL)
INSERT [dbo].[PostType] ([Id], [PostTypeName], [Alias], [Logo], [Order], [IsDeleted], [CreatedDate], [UpdatedDate]) VALUES (5, N'Danh m?c 5', N'Danh-muc-5', NULL, 5, 0, CAST(N'2022-07-29T21:48:06.700' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[PostType] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [UserName], [Password]) VALUES (1, N'admin', N'123')
SET IDENTITY_INSERT [dbo].[User] OFF
GO