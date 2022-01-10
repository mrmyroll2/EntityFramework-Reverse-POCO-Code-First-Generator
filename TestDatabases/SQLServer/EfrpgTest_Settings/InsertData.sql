USE [EfrpgTest_Settings]
GO
SET IDENTITY_INSERT [MultiContext].[Context] ON 

INSERT [MultiContext].[Context] ([Id], [Name], [Description], [BaseSchema], [TemplatePath], [Namespace], [Filename]) VALUES (11, N'EnumerationDbContext', N'This module is used to extract the enumerations', N'dbo', NULL, NULL, NULL)
INSERT [MultiContext].[Context] ([Id], [Name], [Description], [BaseSchema], [TemplatePath], [Namespace], [Filename]) VALUES (12, N'AppleDbContext', N'Testing apples', NULL, NULL, NULL, NULL)
INSERT [MultiContext].[Context] ([Id], [Name], [Description], [BaseSchema], [TemplatePath], [Namespace], [Filename]) VALUES (13, N'BananaDbContext', N'Testing bananas', N'dbo', NULL, NULL, NULL)
INSERT [MultiContext].[Context] ([Id], [Name], [Description], [BaseSchema], [TemplatePath], [Namespace], [Filename]) VALUES (14, N'CherryDbContext', N'Testing cherries', N'dbo', NULL, N'Cherry', N'CherryDatabaseContext')
INSERT [MultiContext].[Context] ([Id], [Name], [Description], [BaseSchema], [TemplatePath], [Namespace], [Filename]) VALUES (15, N'DamsonDbContext', N'Testing Damson plums', NULL, N'C:\S\Source (open source)\EntityFramework Reverse POCO Code Generator\Tester.Integration.EfCore3\File based templates\Templates.EFCore3', N'Plum', NULL)
SET IDENTITY_INSERT [MultiContext].[Context] OFF
SET IDENTITY_INSERT [MultiContext].[Enumeration] ON 

INSERT [MultiContext].[Enumeration] ([Id], [Name], [Table], [NameField], [ValueField], [ContextId]) VALUES (1, N'DaysOfWeek', N'EnumTest.DaysOfWeek', N'TypeName', N'TypeId', 11)
INSERT [MultiContext].[Enumeration] ([Id], [Name], [Table], [NameField], [ValueField], [ContextId]) VALUES (2, N'CarOptions', N'EnumsWithStringAsValue', N'enum_name', N'value', 11)
SET IDENTITY_INSERT [MultiContext].[Enumeration] OFF
SET IDENTITY_INSERT [MultiContext].[Table] ON 

INSERT [MultiContext].[Table] ([Id], [Name], [Description], [PluralName], [DbName], [ContextId], [Attributes], [DbSetModifier]) VALUES (18, N'Boo', NULL, NULL, N'Stafford.Boo', 12, N'[CustomSecurity(SecurityEnum.Readonly)]', NULL)
INSERT [MultiContext].[Table] ([Id], [Name], [Description], [PluralName], [DbName], [ContextId], [Attributes], [DbSetModifier]) VALUES (19, N'Foo', NULL, NULL, N'Stafford.Foo', 12, NULL, NULL)
INSERT [MultiContext].[Table] ([Id], [Name], [Description], [PluralName], [DbName], [ContextId], [Attributes], [DbSetModifier]) VALUES (20, N'ComputedColumns', NULL, NULL, N'Stafford.ComputedColumns', 13, NULL, NULL)
INSERT [MultiContext].[Table] ([Id], [Name], [Description], [PluralName], [DbName], [ContextId], [Attributes], [DbSetModifier]) VALUES (21, N'ColumnNames', NULL, NULL, NULL, 14, NULL, NULL)
INSERT [MultiContext].[Table] ([Id], [Name], [Description], [PluralName], [DbName], [ContextId], [Attributes], [DbSetModifier]) VALUES (22, N'NoPrimaryKeys', NULL, NULL, NULL, 15, NULL, NULL)
INSERT [MultiContext].[Table] ([Id], [Name], [Description], [PluralName], [DbName], [ContextId], [Attributes], [DbSetModifier]) VALUES (23, N'Parent', NULL, NULL, N'[Synonyms].[Parent]', 15, NULL, NULL)
SET IDENTITY_INSERT [MultiContext].[Table] OFF
SET IDENTITY_INSERT [MultiContext].[ForeignKey] ON 

INSERT [MultiContext].[ForeignKey] ([Id], [ContextId], [ConstraintName], [ParentName], [ChildName], [PkSchema], [PkTableName], [PkColumn], [FkSchema], [FkTableName], [FkColumn], [Ordinal], [CascadeOnDelete], [IsNotEnforced], [HasUniqueConstraint]) VALUES (1, 15, N'CustomNameForForeignKey', N'ParentFkName', N'ChildFkName', N'dbo', N'NoPrimaryKeys', N'Description', N'Synonyms', N'Parent', N'ParentName', 1, 0, 0, 0)
SET IDENTITY_INSERT [MultiContext].[ForeignKey] OFF
SET IDENTITY_INSERT [MultiContext].[Column] ON 

INSERT [MultiContext].[Column] ([Id], [Name], [DbName], [IsPrimaryKey], [OverrideModifier], [EnumType], [TableId], [Attributes], [Test], [DummyInt], [date_of_birth], [PropertyType], [IsNullable]) VALUES (1, N'id', NULL, NULL, 0, NULL, 18, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [MultiContext].[Column] ([Id], [Name], [DbName], [IsPrimaryKey], [OverrideModifier], [EnumType], [TableId], [Attributes], [Test], [DummyInt], [date_of_birth], [PropertyType], [IsNullable]) VALUES (2, N'Name', NULL, NULL, 0, NULL, 18, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [MultiContext].[Column] ([Id], [Name], [DbName], [IsPrimaryKey], [OverrideModifier], [EnumType], [TableId], [Attributes], [Test], [DummyInt], [date_of_birth], [PropertyType], [IsNullable]) VALUES (3, N'id', NULL, NULL, 0, NULL, 19, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [MultiContext].[Column] ([Id], [Name], [DbName], [IsPrimaryKey], [OverrideModifier], [EnumType], [TableId], [Attributes], [Test], [DummyInt], [date_of_birth], [PropertyType], [IsNullable]) VALUES (4, N'id', NULL, NULL, 0, NULL, 20, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [MultiContext].[Column] ([Id], [Name], [DbName], [IsPrimaryKey], [OverrideModifier], [EnumType], [TableId], [Attributes], [Test], [DummyInt], [date_of_birth], [PropertyType], [IsNullable]) VALUES (5, N'MyColumn', NULL, NULL, 0, NULL, 20, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [MultiContext].[Column] ([Id], [Name], [DbName], [IsPrimaryKey], [OverrideModifier], [EnumType], [TableId], [Attributes], [Test], [DummyInt], [date_of_birth], [PropertyType], [IsNullable]) VALUES (6, N'Dollar', N'$', NULL, 0, NULL, 21, N'[ExampleForTesting("abc")]~[CustomRequired]', N'Hello', 1234, CAST(N'2019-06-20T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [MultiContext].[Column] ([Id], [Name], [DbName], [IsPrimaryKey], [OverrideModifier], [EnumType], [TableId], [Attributes], [Test], [DummyInt], [date_of_birth], [PropertyType], [IsNullable]) VALUES (7, N'Pound', N'[£]', NULL, 0, NULL, 21, N'[ExampleForTesting("def")]~[CustomSecurity(SecurityEnum.Readonly)]', N'World', 5678, CAST(N'2019-06-21T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [MultiContext].[Column] ([Id], [Name], [DbName], [IsPrimaryKey], [OverrideModifier], [EnumType], [TableId], [Attributes], [Test], [DummyInt], [date_of_birth], [PropertyType], [IsNullable]) VALUES (8, N'StaticField', N'static', NULL, 0, NULL, 21, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [MultiContext].[Column] ([Id], [Name], [DbName], [IsPrimaryKey], [OverrideModifier], [EnumType], [TableId], [Attributes], [Test], [DummyInt], [date_of_birth], [PropertyType], [IsNullable]) VALUES (9, N'Day', N'readonly', NULL, 0, NULL, 21, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [MultiContext].[Column] ([Id], [Name], [DbName], [IsPrimaryKey], [OverrideModifier], [EnumType], [TableId], [Attributes], [Test], [DummyInt], [date_of_birth], [PropertyType], [IsNullable]) VALUES (10, N'Description', NULL, 1, 0, NULL, 22, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [MultiContext].[Column] ([Id], [Name], [DbName], [IsPrimaryKey], [OverrideModifier], [EnumType], [TableId], [Attributes], [Test], [DummyInt], [date_of_birth], [PropertyType], [IsNullable]) VALUES (11, N'ParentId', NULL, NULL, 0, NULL, 23, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [MultiContext].[Column] ([Id], [Name], [DbName], [IsPrimaryKey], [OverrideModifier], [EnumType], [TableId], [Attributes], [Test], [DummyInt], [date_of_birth], [PropertyType], [IsNullable]) VALUES (12, N'ParentName', N'ParentName', NULL, 0, NULL, 23, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [MultiContext].[Column] OFF
