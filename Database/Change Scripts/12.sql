
alter table AuditNotifications add
  AAN_USE_FOR_SENT bit
go
exec sp_addextendedproperty N'MS_Description', N'Pazīme vai izmantot epasta sūtīšanai', N'user', N'dbo', N'table', N'AuditNotifications', N'column', N'AAN_USE_FOR_SENT'
GO
Delete from classifiers where cls_name in ('qwe', 'test5')
GO
UPDATE _SysParameters SET PRM_VALUE = '12' WHERE PRM_NAME LIKE ('VERSION_%_DB')
GO
-- Lūdzu, Юникод