alter table Quality add
  QLT_ACTIVITY_CREATED bit not null constraint DF_QLT_ACTIVITY_CREATED default(0)
go

exec sp_addextendedproperty N'MS_Description', N'Pazīme, ja izveidota aktvitāte par iepazīšanos ar novērtējumu', N'user', N'dbo', N'table', N'Quality', N'column', N'QLT_ACTIVITY_CREATED'
GO

UPDATE _SysParameters SET PRM_VALUE = '9' WHERE PRM_NAME LIKE ('VERSION_%_DB')
GO
-- Lūdzu, Юникод