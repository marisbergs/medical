alter table CMCases add 
	CMC_TAXPAYER_ADDRESS_ID int
Go
exec sp_addextendedproperty N'MS_Description', N'NM adreses ID', N'user', N'dbo', N'table', N'CMCases', N'column', N'CMC_TAXPAYER_ADDRESS_ID'
GO
alter table CMCases add 
	CMC_OBJECT_ADDRESS_ID int
Go
exec sp_addextendedproperty N'MS_Description', N'Pârbaudâmâ objekta adreses ID', N'user', N'dbo', N'table', N'CMCases', N'column', N'CMC_OBJECT_ADDRESS_ID'
GO
UPDATE _SysParameters SET PRM_VALUE = '39' WHERE PRM_NAME LIKE ('VERSION_%_DB')  