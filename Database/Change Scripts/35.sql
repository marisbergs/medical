alter table NoticePenalties add 
	NOP_OFFENCE_DATE DateTime
Go
exec sp_addextendedproperty N'MS_Description', N'P�rk�puma izdar��anas datums', N'user', N'dbo', N'table', N'NoticePenalties', N'column', N'NOP_OFFENCE_DATE'
GO
alter table NoticePenalties add 
	NOP_LITIGATE bit default 0
Go
exec sp_addextendedproperty N'MS_Description', N'L�mums apstr�d�ts', N'user', N'dbo', N'table', N'NoticePenalties', N'column', N'NOP_LITIGATE'
GO
alter table NoticePenalties add 
	NOP_LITIGATION_DATE DateTime
Go
exec sp_addextendedproperty N'MS_Description', N'L�muma apstr�d��anas datums', N'user', N'dbo', N'table', N'NoticePenalties', N'column', N'NOP_LITIGATION_DATE'
GO
alter table NoticePenalties add 
	NOP_DOCUMENTATION_STOPPED bit default 0
Go
exec sp_addextendedproperty N'MS_Description', N'Lietved�ba izbeigta', N'user', N'dbo', N'table', N'NoticePenalties', N'column', N'NOP_DOCUMENTATION_STOPPED'
GO
alter table NoticePenalties add 
	NOP_DOCUMENTATION_STOPPED_TEXT nvarchar(1000)
Go
exec sp_addextendedproperty N'MS_Description', N'Lietved�ba izbeigta (koment�rs)', N'user', N'dbo', N'table', N'NoticePenalties', N'column', N'NOP_DOCUMENTATION_STOPPED_TEXT'
GO
alter table NoticePenalties add 
	NOP_GENDER TinyInt
Go
exec sp_addextendedproperty N'MS_Description', N'Dzimums', N'user', N'dbo', N'table', N'NoticePenalties', N'column', N'NOP_GENDER'
GO
UPDATE _SysParameters SET PRM_VALUE = '35' WHERE PRM_NAME LIKE ('VERSION_%_DB')     