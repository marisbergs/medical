ALTER TABLE InvitationDocuments ADD
	IND_DOCUMENT_TYPE varchar(100) NULL
GO
exec sp_addextendedproperty N'MS_Description', N'Dokumenta veids', N'user', N'dbo', N'table', N'InvitationDocuments', N'column', N'IND_DOCUMENT_TYPE'
GO
UPDATE _SysParameters SET PRM_VALUE = '29' WHERE PRM_NAME LIKE ('VERSION_%_DB')      