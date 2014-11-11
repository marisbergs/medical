UPDATE  Acts set ACS_OBJ_WORKTIME=null
GO
ALTER TABLE [dbo].[Acts] DROP COLUMN [ACS_TP_TOLD]
GO
ALTER TABLE [dbo].[Acts] DROP COLUMN [ACS_END_NOTES]
GO
ALTER TABLE [dbo].[Acts] DROP COLUMN [ACS_TP_ADDITION]
GO
ALTER TABLE Acts ADD
  ACS_TP_TOLD_ID uniqueidentifier NULL 
    constraint FK_ACS_TP_TOLD_ID references TextContent(TXT_ID)
GO
ALTER TABLE Acts ADD
  ACS_END_NOTES_ID uniqueidentifier NULL 
    constraint FK_ACS_END_NOTES_ID references TextContent(TXT_ID)
GO
ALTER TABLE Acts ADD
  ACS_TP_ADDITION_ID uniqueidentifier NULL 
    constraint FK_ACS_TP_ADDITION_ID references TextContent(TXT_ID)
GO
alter table Acts alter column ACS_OBJ_WORKTIME nvarchar(250)
GO
exec sp_addextendedproperty N'MS_Description', N'Pierakstîts teksts no NM teiktâ (TextContent)', N'user', N'dbo', N'table', N'Acts', N'column', N'ACS_TP_TOLD_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Nobeiguma piezîmes (TextContent)', N'user', N'dbo', N'table', N'Acts', N'column', N'ACS_END_NOTES_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'NM piezîmju teksts pielikumâ (TextContent)', N'user', N'dbo', N'table', N'Acts', N'column', N'ACS_TP_ADDITION_ID'
GO
update Classifiers set CLS_NAME='Tematiskâ pârbaude' where cls_id='007703FB-EA93-445D-81F7-6022A6647437' and CLS_TYPE_ID='CMtype'
GO
UPDATE _SysParameters SET PRM_VALUE = '14' WHERE PRM_NAME LIKE ('VERSION_%_DB')