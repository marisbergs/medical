ALTER TABLE CMCases ADD
	CMC_PLANNED_REASON_ID uniqueidentifier NULL
	constraint FK_CMC_PLANNED_REASON_ID references Classifiers(CLS_ID)
GO
exec sp_addextendedproperty N'MS_Description', N'Plânotas KP lietas iemesls PtiReason(Classifiers)', N'user', N'dbo', N'table', N'CMCases', N'column', N'CMC_PLANNED_REASON_ID'
GO
ALTER TABLE Classifiers ADD
	CLS_NTEXT_ID uniqueidentifier NULL
GO
exec sp_addextendedproperty N'MS_Description', N'Tekstuâlie lauki (TextContent)', N'user', N'dbo', N'table', N'Classifiers', N'column', N'CLS_NTEXT_ID'
GO
UPDATE Classifiers SET CLS_TEXT=NULL WHERE LEN(CLS_TEXT)>2000
Go
ALTER TABLE Classifiers ALTER COLUMN CLS_TEXT NVARCHAR(2000) NULL
GO
ALTER TABLE Classifiers ADD
	CLS_COMMENTS NVARCHAR(1000) NULL
GO
exec sp_addextendedproperty N'MS_Description', N'Komentâri', N'user', N'dbo', N'table', N'Classifiers', N'column', N'CLS_COMMENTS'
GO
ALTER TABLE ClassifierTypes ADD
	CLT_COMMENT_PROMPT nvarchar(50) NULL
GO
exec sp_addextendedproperty N'MS_Description', N'Vai ir nepiecieðami komentâri', N'user', N'dbo', N'table', N'ClassifierTypes', N'column', N'CLT_COMMENT_PROMPT'
GO
UPDATE _SysParameters SET PRM_VALUE = '26' WHERE PRM_NAME LIKE ('VERSION_%_DB')     