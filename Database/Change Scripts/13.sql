 alter table ViolatedRules alter column VRL_QUOTE nvarchar(3600)
go
alter table ViolatedRules alter column VRL_POINT nvarchar(20)
go
alter table ViolationResponsibleRules alter column VRR_QUOTE nvarchar(3600)
go
alter table ViolationResponsibleRules alter column VRR_POINT nvarchar(20)
go
alter table _SysParameters add
  PRM_DATE_VALUE datetime
go
exec sp_addextendedproperty N'MS_Description', N'Parametra datuma vērtība', N'user', N'dbo', N'table', N'_SysParameters', N'column', N'PRM_DATE_VALUE'
GO
alter table _SysParameters alter column PRM_VALUE nvarchar(500) null 
GO
UPDATE _SysParameters SET PRM_VALUE = '13' WHERE PRM_NAME LIKE ('VERSION_%_DB')
GO


-- Lūdzu, Юникод 