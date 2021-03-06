alter table Activities add
  ACT_CREATOR_ID uniqueidentifier NULL
  constraint FK_ACT_CREATOR_ID
  references Users(USR_ID)
go

exec sp_addextendedproperty N'MS_Description', N'Lietotāja ID, kurš izveidojis aktivitāti', N'user', N'dbo', N'table', N'Activities', N'column', N'ACT_CREATOR_ID'
GO

UPDATE _SysParameters SET PRM_VALUE = '8' WHERE PRM_NAME LIKE ('VERSION_%_DB')
GO
-- Lūdzu, Юникод   