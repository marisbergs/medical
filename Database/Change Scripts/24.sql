ALTER TABLE MandatoryFormDetails ADD
	MFD_DOC_TYPE NVARCHAR(250) NULL
GO
exec sp_addextendedproperty N'MS_Description', N'Konfiskâcija', N'user', N'dbo', N'table', N'MandatoryFormDetails', N'column', N'MFD_DOC_TYPE'
GO
ALTER TABLE MandatoryFormDetails ADD
	MFD_FROM_WH bit NULL default 0
GO
exec sp_addextendedproperty N'MS_Description', N'Konfiskâcija', N'user', N'dbo', N'table', N'MandatoryFormDetails', N'column', N'MFD_FROM_WH'
GO
ALTER TABLE MandatoryFormDetails ALTER COLUMN MFD_DOC_TYPE_ID uniqueidentifier NULL
GO
UPDATE _SysParameters SET PRM_VALUE = '24' WHERE PRM_NAME LIKE ('VERSION_%_DB')     