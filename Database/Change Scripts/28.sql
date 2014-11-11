ALTER TABLE dbo.ClassifierTypes ALTER COLUMN CLT_VALUE_PROMPT nvarchar(50) NULL
GO
ALTER TABLE ViolationResponsibleRules ADD
	VRR_EXT_ARTICLE_ID uniqueidentifier NULL
	constraint FK_VRR_EXT_ARTICLE_ID references Classifiers(CLS_ID)
GO
exec sp_addextendedproperty N'MS_Description', N'NIS izziòâ izmantojamâ pantu klasifikatora ID (ExtArticle)', N'user', N'dbo', N'table', N'ViolationResponsibleRules', N'column', N'VRR_EXT_ARTICLE_ID'
GO

Create table MitigatingCircumstances(
EDM_ID uniqueidentifier NOT NULL constraint PK_MitigatingCircumstances primary key clustered,
EDM_DOC_ID uniqueidentifier NOT NULL
  constraint FK_EDM_DOC_ID references EndDecisionResponsibilities(EDE_ID),
EDM_MITIGATION_ID uniqueidentifier not null
  constraint FK_EDM_MITIGATION_ID references Classifiers(CLS_ID),
EDM_NOTES NVARCHAR(3000) NULL,
[EDM__DELETE_TIME] [datetime] NULL ,
[EDM__UPDATE_TIME] [datetime] NOT NULL CONSTRAINT [DF_MitigatingCircumstances_EDM__UPDATE_TIME] DEFAULT (getdate()),
[EDM__LOCK_VERSION] [int] NOT NULL CONSTRAINT [DF_MitigatingCircumstances_EDM__LOCK_VERSION] DEFAULT (1),
[EDM__VERSION] [int] NOT NULL CONSTRAINT [DF_MitigatingCircumstances_EDM__VERSION] DEFAULT (0),
[EDM__SOURCE] [uniqueidentifier] NULL
)
GO

exec sp_addextendedproperty N'MS_Description', N'Lçmums administratîvâ pârkâpuma lietâ tabula vainu mîkstinoði apstâkïi', N'user', N'dbo', N'table', N'MitigatingCircumstances'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta sistçmas identifikators', N'user', N'dbo', N'table', N'MitigatingCircumstances', N'column', N'EDM_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Dokumenta ID (EndDecisionResponsibilities)', N'user', N'dbo', N'table', N'MitigatingCircumstances', N'column', N'EDM_DOC_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Vainu mîkstinoðâ apstâkïa ID', N'user', N'dbo', N'table', N'MitigatingCircumstances', N'column', N'EDM_MITIGATION_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Piezîmes', N'user', N'dbo', N'table', N'MitigatingCircumstances', N'column', N'EDM_NOTES'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta loìiskâs izdzçðanas laiks', N'user', N'dbo', N'table', N'MitigatingCircumstances', N'column', N'EDM__DELETE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Pçdçjo izmaiòu veikðanas laiks', N'user', N'dbo', N'table', N'MitigatingCircumstances', N'column', N'EDM__UPDATE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Optimistiskâs bloíçðanas skaitîtâjs', N'user', N'dbo', N'table', N'MitigatingCircumstances', N'column', N'EDM__LOCK_VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta aktuâlâ versija', N'user', N'dbo', N'table', N'MitigatingCircumstances', N'column', N'EDM__VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta izmaiòu versijas numurs', N'user', N'dbo', N'table', N'MitigatingCircumstances', N'column', N'EDM__SOURCE'
GO

create index IX_MitigatingCircumstances_EDM_DOC_ID on MitigatingCircumstances(EDM_DOC_ID)
go
create index IX_MitigatingCircumstances_EDM_MITIGATION_ID on MitigatingCircumstances(EDM_MITIGATION_ID)
go

Create table AggravatingCircumstances(
EDG_ID uniqueidentifier NOT NULL constraint PK_AggravatingCircumstances primary key clustered,
EDG_DOC_ID uniqueidentifier NOT NULL
  constraint FK_EDG_DOC_ID references EndDecisionResponsibilities(EDE_ID),
EDG_AGGRAVATING_ID uniqueidentifier not null
  constraint FK_EDG_AGGRAVATING_ID references Classifiers(CLS_ID),
EDG_NOTES NVARCHAR(3000) NULL,
[EDG__DELETE_TIME] [datetime] NULL ,
[EDG__UPDATE_TIME] [datetime] NOT NULL CONSTRAINT [DF_AggravatingCircumstances_EDG__UPDATE_TIME] DEFAULT (getdate()),
[EDG__LOCK_VERSION] [int] NOT NULL CONSTRAINT [DF_AggravatingCircumstances_EDG__LOCK_VERSION] DEFAULT (1),
[EDG__VERSION] [int] NOT NULL CONSTRAINT [DF_AggravatingCircumstances_EDG__VERSION] DEFAULT (0),
[EDG__SOURCE] [uniqueidentifier] NULL
)
GO

exec sp_addextendedproperty N'MS_Description', N'Lçmums administratîvâ pârkâpuma lietâ tabula vainu pastiprinoði apstâkïi', N'user', N'dbo', N'table', N'AggravatingCircumstances'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta sistçmas identifikators', N'user', N'dbo', N'table', N'AggravatingCircumstances', N'column', N'EDG_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Dokumenta ID (EndDecisionResponsibilities)', N'user', N'dbo', N'table', N'AggravatingCircumstances', N'column', N'EDG_DOC_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Vainu pastiprinoðâ apstâkïa ID', N'user', N'dbo', N'table', N'AggravatingCircumstances', N'column', N'EDG_NOTES'
GO
exec sp_addextendedproperty N'MS_Description', N'Piezîmes', N'user', N'dbo', N'table', N'AggravatingCircumstances', N'column', N'EDG_AGGRAVATING_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta loìiskâs izdzçðanas laiks', N'user', N'dbo', N'table', N'AggravatingCircumstances', N'column', N'EDG__DELETE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Pçdçjo izmaiòu veikðanas laiks', N'user', N'dbo', N'table', N'AggravatingCircumstances', N'column', N'EDG__UPDATE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Optimistiskâs bloíçðanas skaitîtâjs', N'user', N'dbo', N'table', N'AggravatingCircumstances', N'column', N'EDG__LOCK_VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta aktuâlâ versija', N'user', N'dbo', N'table', N'AggravatingCircumstances', N'column', N'EDG__VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta izmaiòu versijas numurs', N'user', N'dbo', N'table', N'AggravatingCircumstances', N'column', N'EDG__SOURCE'
GO

create index IX_AggravatingCircumstances_EDG_DOC_ID on AggravatingCircumstances(EDG_DOC_ID)
go
create index IX_AggravatingCircumstances_EDG_AGGRAVATING_ID on AggravatingCircumstances(EDG_AGGRAVATING_ID)
go

Declare @trigger_txt nvarchar(4000)
SET @trigger_txt =
N' TRIGGER $table$_synchro
ON $table$
FOR INSERT, UPDATE 
AS 
BEGIN
  SET NOCOUNT ON

  Declare @WorkstationID uniqueidentifier,
          @CurrentVersion int,
          @Update_SOURCE bit

  SET @Update_SOURCE = 0
  IF UPDATE($COL__SOURCE$) SET @Update_SOURCE = 1

  SELECT @WorkstationID = SYC_WORKSTATION_ID,
         @CurrentVersion = SYC_CURRENT_VERSION
  FROM _SynchroConfig

  UPDATE $table$
  SET $COL__UPDATE_TIME$ = getdate(),
      $COL__VERSION$ =
        CASE
          WHEN
            @WorkstationID <> ''CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC'' -- not central server
            AND @Update_SOURCE = 1 AND NOT inserted.$COL__SOURCE$ IS NULL -- synchronization
              THEN inserted.$COL__VERSION$
          ELSE @CurrentVersion
        END,
      $COL__SOURCE$ =
          CASE
            WHEN @Update_SOURCE = 1 THEN ISNULL(inserted.$COL__SOURCE$, @WorkstationID)
            ELSE @WorkstationID
          END
  FROM $table$ inner join inserted 
       on $table$.$COL_ID$ = inserted.$COL_ID$
END'

Declare @tbl nvarchar(100),
        @vers_col nvarchar(100),
        @src_col nvarchar(100),
        @upd_col nvarchar(100),
        @id_col nvarchar(100),
        @sql nvarchar(4000)
Declare c CURSOR
FOR
  SELECT so.name, v.name, s.name, ut.name, pk.name
  FROM sysobjects so
       inner join syscolumns v on so.id = v.id and v.name like '%VERSION' AND NOT v.name like '%LOCK_VERSION'
       inner join syscolumns s on so.id = s.id and s.name like '%SOURCE'
       inner join syscolumns ut on so.id = ut.id and ut.name like '%UPDATE_TIME'
       inner join syscolumns pk on so.id = pk.id and pk.colid = 1
  WHERE so.xtype = 'U'
    -- ir daþas izòçmumu tabulas:
    AND NOT so.name in (
      'ATS_IZM', -- PK sastâv no 2 laukiem
      'BILDES')


OPEN c

FETCH NEXT FROM c INTO @tbl, @vers_col, @src_col, @upd_col, @id_col
WHILE (@@FETCH_STATUS = 0)
BEGIN
  SELECT @sql = 'CREATE'
  if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[' + @tbl + '_synchro]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
    SELECT @sql = 'ALTER'

  SELECT @sql = @sql + @trigger_txt
  SELECT @sql = Replace(@sql, '$table$', @tbl)
  SELECT @sql = Replace(@sql, '$COL__VERSION$', @vers_col)
  SELECT @sql = Replace(@sql, '$COL__SOURCE$', @src_col)
  SELECT @sql = Replace(@sql, '$COL__UPDATE_TIME$', @upd_col)
  SELECT @sql = Replace(@sql, '$COL_ID$', @id_col)

--  select @sql
  exec sp_executesql @sql
  
  FETCH NEXT FROM c INTO @tbl, @vers_col, @src_col, @upd_col, @id_col
END

CLOSE c
DEALLOCATE c
GO
ALTER TABLE EndDecisions ADD
	END_COMMENT_ID uniqueidentifier NULL
	constraint FK_END_COMMENT_ID references TextContent(TXT_ID)
GO
exec sp_addextendedproperty N'MS_Description', N'Liels piezîmju lauks', N'user', N'dbo', N'table', N'EndDecisions', N'column', N'END_COMMENT_ID'
GO
ALTER TABLE CMCaseViolationResponsibleRules ADD
	CRR_CONFISCATION BIT NULL DEFAULT 0
GO
exec sp_addextendedproperty N'MS_Description', N'Konfiskâcija', N'user', N'dbo', N'table', N'CMCaseViolationResponsibleRules', N'column', N'CRR_CONFISCATION'
GO
ALTER TABLE CMCaseViolationResponsibleRules ADD
	CRR_21_ARTICLE BIT NULL DEFAULT 0
GO
exec sp_addextendedproperty N'MS_Description', N'21. pants', N'user', N'dbo', N'table', N'CMCaseViolationResponsibleRules', N'column', N'CRR_21_ARTICLE'
GO
ALTER TABLE CMCaseViolationResponsibleRules ADD
	CRR_CONFISCATION_NOTES nvarchar(2000) NULL
GO
exec sp_addextendedproperty N'MS_Description', N'Konfiskâcijas piezîmes', N'user', N'dbo', N'table', N'CMCaseViolationResponsibleRules', N'column', N'CRR_CONFISCATION_NOTES'
GO
ALTER TABLE CMCaseViolationResponsibleRules ADD
	CRR_RECORD_TERMINATION_ID uniqueidentifier NULL
	constraint FK_CRR_RECORD_TERMINATION_ID references Classifiers(CLS_ID)
GO
exec sp_addextendedproperty N'MS_Description', N'Lietvedîbas atcelðanas iemeslu klasifikators (RecordTermination)', N'user', N'dbo', N'table', N'CMCaseViolationResponsibleRules', N'column', N'CRR_RECORD_TERMINATION_ID'
GO
ALTER TABLE CMCaseViolations ADD
	CVI_VIOLATION_TYPE varchar(100) NULL
GO
exec sp_addextendedproperty N'MS_Description', N'Pârkâpuma veids', N'user', N'dbo', N'table', N'CMCaseViolations', N'column', N'CVI_VIOLATION_TYPE'
GO
ALTER TABLE EndDecisions ADD
	END_PAYMENT_TERM datetime NULL
GO
exec sp_addextendedproperty N'MS_Description', N'Soda naudas samaksas termiòð', N'user', N'dbo', N'table', N'EndDecisions', N'column', N'END_PAYMENT_TERM'
GO
ALTER TABLE Violations ADD
	VIO_NOTES NVARCHAR(2000) NULL
GO
exec sp_addextendedproperty N'MS_Description', N'Komentâri', N'user', N'dbo', N'table', N'Violations', N'column', N'VIO_NOTES'
GO
UPDATE _SysParameters SET PRM_VALUE = '28' WHERE PRM_NAME LIKE ('VERSION_%_DB')   