Create table InfoAboutStatedRisks (
IAI_ID uniqueidentifier NOT NULL constraint PK_InfoAboutStatedRisks primary key clustered,
IAI_DOC_ID uniqueidentifier NOT NULL
  constraint FK_IAI_DOC_ID references InfoAboutStated(IAS_ID),
IAI_TYPE tinyint not null,
IAI_RISK_ID uniqueidentifier not null
  constraint FK_IAI_RISK_ID references Classifiers(CLS_ID),
IAI_RISK_AUTHOR_ID uniqueidentifier not null
  constraint FK_IAI_RISK_AUTHOR_ID references Users(USR_ID),
IAI_RESULT varchar(500),
IAI_RESULT_AUTHOR_ID uniqueidentifier
  constraint FK_IAI_RESULT_AUTHOR_ID references Users(USR_ID),
[IAI__DELETE_TIME] [datetime] NULL ,
[IAI__UPDATE_TIME] [datetime] NOT NULL CONSTRAINT [DF_InfoAboutStatedRisks_IAI__UPDATE_TIME] DEFAULT (getdate()),
[IAI__LOCK_VERSION] [int] NOT NULL CONSTRAINT [DF_InfoAboutStatedRisks_IAI__LOCK_VERSION] DEFAULT (1),
[IAI__VERSION] [int] NOT NULL CONSTRAINT [DF_InfoAboutStatedRisks_IAI__VERSION] DEFAULT (0),
[IAI__SOURCE] [uniqueidentifier] NULL
)
GO

exec sp_addextendedproperty N'MS_Description', N'Informācija par pārbaudē konstatēto, sadaļa Riski', N'user', N'dbo', N'table', N'InfoAboutStatedRisks'
GO

exec sp_addextendedproperty N'MS_Description', N'Ieraksta sistēmas identifikators', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Dokumenta ID (InfoAboutStated)', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI_DOC_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Pazīme', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI_TYPE'
GO
exec sp_addextendedproperty N'MS_Description', N'Riska ID', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI_RISK_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Risku ievadījušā lietotāja ID', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI_RISK_AUTHOR_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Rezultāts', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI_RESULT'
GO
exec sp_addextendedproperty N'MS_Description', N'Rezultātu pievienojušā lietotāja ID', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI_RESULT_AUTHOR_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta loģiskās izdzēšanas laiks', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI__DELETE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Pēdējo izmaiņu veikšanas laiks', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI__UPDATE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Optimistiskās bloķēšanas skaitītājs', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI__LOCK_VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta aktuālā versija', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI__VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta izmaiņu versijas numurs', N'user', N'dbo', N'table', N'InfoAboutStatedRisks', N'column', N'IAI__SOURCE'
GO

create index IX_InfoAboutStatedRisks_IAI_DOC_ID on InfoAboutStatedRisks(IAI_DOC_ID)
go
create index IX_InfoAboutStatedRisks_IAI_RISK_ID on InfoAboutStatedRisks(IAI_RISK_ID)
go
create index IX_InfoAboutStatedRisks_IAI_RISK_AUTHOR_ID on InfoAboutStatedRisks(IAI_RISK_AUTHOR_ID)
go
create index IX_InfoAboutStatedRisks_IAI_RESULT_AUTHOR_ID on InfoAboutStatedRisks(IAI_RESULT_AUTHOR_ID)
go


UPDATE _SysParameters SET PRM_VALUE = '3' WHERE PRM_NAME LIKE ('VERSION_%_DB')
GO