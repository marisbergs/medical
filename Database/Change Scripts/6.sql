alter table Acts alter column ACS_OBJ_WORKTIME nvarchar(250)
go

UPDATE _SysParameters SET PRM_VALUE = '6' WHERE PRM_NAME LIKE ('VERSION_%_DB')
GO
-- Lūdzu, Юникод 