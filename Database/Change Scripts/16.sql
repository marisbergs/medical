UPDATE SrsNumbers SET SRS_COMMENT = NULL, SRS_REQUISITES_TEXT = NULL, SRS_REASONS_TEXT = NULL
GO
ALTER TABLE SrsNumbers ALTER column SRS_COMMENT nvarchar(800) NULL
GO
ALTER TABLE SrsNumbers ALTER column SRS_REQUISITES_TEXT nvarchar(800) NULL
GO
ALTER TABLE SrsNumbers ALTER column SRS_REASONS_TEXT nvarchar(800) NULL
GO
ALTER TABLE Users ADD
  USR_ORGANIZATION_MANUAL_ID uniqueidentifier NULL 
    constraint FK_USR_ORGANIZATION_MANUAL_ID references Organizations(ORG_ID)
GO
exec sp_addextendedproperty N'MS_Description', N'Darbavieta manuâli (Organization)', N'user', N'dbo', N'table', N'Users', N'column', N'USR_ORGANIZATION_MANUAL_ID'
GO
ALTER TABLE Users ADD
  USR_POSITION_ORGANIZATION nvarchar(250) NULL 
GO
exec sp_addextendedproperty N'MS_Description', N'Struktûrvienîbas nosaukums darbinieka pilnajam amata nosaukumam', N'user', N'dbo', N'table', N'Users', N'column', N'USR_POSITION_ORGANIZATION'
GO

UPDATE _SysParameters SET PRM_VALUE = '16' WHERE PRM_NAME LIKE ('VERSION_%_DB') 