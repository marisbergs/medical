Create table Personalizations(
PRS_ID uniqueidentifier NOT NULL constraint PK_Personalizations primary key clustered,
PRS_USER_ID uniqueidentifier NOT NULL,
PRS_FORM NVARCHAR(250) NULL,
PRS_TABLE NVARCHAR(250) NULL,
PRS_VIEW NVARCHAR(250) NULL,
PRS_CONTENT NTEXT NULL,
[PRS__DELETE_TIME] [datetime] NULL ,
[PRS__UPDATE_TIME] [datetime] NOT NULL CONSTRAINT [DF_Personalizations_PRS__UPDATE_TIME] DEFAULT (getdate()),
[PRS__LOCK_VERSION] [int] NOT NULL CONSTRAINT [DF_Personalizations_PRS__LOCK_VERSION] DEFAULT (1),
[PRS__VERSION] [int] NOT NULL CONSTRAINT [DF_Personalizations_PRS__VERSION] DEFAULT (0),
[PRS__SOURCE] [uniqueidentifier] NULL
)
GO

exec sp_addextendedproperty N'MS_Description', N'Lietotâju tabulu personalizâcija', N'user', N'dbo', N'table', N'Personalizations'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta sistçmas identifikators', N'user', N'dbo', N'table', N'Personalizations', N'column', N'PRS_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Lietotâja ID', N'user', N'dbo', N'table', N'Personalizations', N'column', N'PRS_USER_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Formas nosaukums', N'user', N'dbo', N'table', N'Personalizations', N'column', N'PRS_FORM'
GO
exec sp_addextendedproperty N'MS_Description', N'Tabulas nosaukums', N'user', N'dbo', N'table', N'Personalizations', N'column', N'PRS_TABLE'
GO
exec sp_addextendedproperty N'MS_Description', N'Skata nosaukums', N'user', N'dbo', N'table', N'Personalizations', N'column', N'PRS_VIEW'
GO
exec sp_addextendedproperty N'MS_Description', N'Izkârtojuma XML fails', N'user', N'dbo', N'table', N'Personalizations', N'column', N'PRS_CONTENT'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta loìiskâs izdzçðanas laiks', N'user', N'dbo', N'table', N'Personalizations', N'column', N'PRS__DELETE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Pçdçjo izmaiòu veikðanas laiks', N'user', N'dbo', N'table', N'Personalizations', N'column', N'PRS__UPDATE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Optimistiskâs bloíçðanas skaitîtâjs', N'user', N'dbo', N'table', N'Personalizations', N'column', N'PRS__LOCK_VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta aktuâlâ versija', N'user', N'dbo', N'table', N'Personalizations', N'column', N'PRS__VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta izmaiòu versijas numurs', N'user', N'dbo', N'table', N'Personalizations', N'column', N'PRS__SOURCE'
GO
UPDATE _SysParameters SET PRM_VALUE = '37' WHERE PRM_NAME LIKE ('VERSION_%_DB')  