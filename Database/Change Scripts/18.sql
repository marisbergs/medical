 Create table WWDocumentsRequisites (
WDR_ID uniqueidentifier NOT NULL constraint PK_WWDocumentsRequisites primary key clustered,
WDR_DOC_ID uniqueidentifier NOT NULL
  constraint FK_WDR_DOC_ID references WWBase(WHS_ID),
WDR_REQUISITE_ID uniqueidentifier not null
  constraint FK_WDR_REQUISITE_ID references Classifiers(CLS_ID),
[WDR__DELETE_TIME] [datetime] NULL ,
[WDR__UPDATE_TIME] [datetime] NOT NULL CONSTRAINT [DF_WWDocumentsRequisites_WDR__UPDATE_TIME] DEFAULT (getdate()),
[WDR__LOCK_VERSION] [int] NOT NULL CONSTRAINT [DF_WWDocumentsRequisites_WDR__LOCK_VERSION] DEFAULT (1),
[WDR__VERSION] [int] NOT NULL CONSTRAINT [DF_WWDocumentsRequisites_WDR__VERSION] DEFAULT (0),
[WDR__SOURCE] [uniqueidentifier] NULL
)
GO

ALTER TABLE SpecialActs ALTER COLUMN SPA_ESTABLISHED nvarchar(3800) NULL

exec sp_addextendedproperty N'MS_Description', N'Preèu pavaddokumentu reìistrâcija un preèu reìistrâcija un uzskaite vairumtirdzniecîbâ tabula preèu reìistrâ nenorâdîtie NA noteiktie rekvizîti', N'user', N'dbo', N'table', N'WWDocumentsRequisites'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta sistçmas identifikators', N'user', N'dbo', N'table', N'WWDocumentsRequisites', N'column', N'WDR_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Dokumenta ID (WWBase)', N'user', N'dbo', N'table', N'WWDocumentsRequisites', N'column', N'WDR_DOC_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Rekvizîta ID', N'user', N'dbo', N'table', N'WWDocumentsRequisites', N'column', N'WDR_REQUISITE_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta loìiskâs izdzçðanas laiks', N'user', N'dbo', N'table', N'WWDocumentsRequisites', N'column', N'WDR__DELETE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Pçdçjo izmaiòu veikðanas laiks', N'user', N'dbo', N'table', N'WWDocumentsRequisites', N'column', N'WDR__UPDATE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Optimistiskâs bloíçðanas skaitîtâjs', N'user', N'dbo', N'table', N'WWDocumentsRequisites', N'column', N'WDR__LOCK_VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta aktuâlâ versija', N'user', N'dbo', N'table', N'WWDocumentsRequisites', N'column', N'WDR__VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta izmaiòu versijas numurs', N'user', N'dbo', N'table', N'WWDocumentsRequisites', N'column', N'WDR__SOURCE'
GO

create index IX_WWDocumentsRequisites_WDR_DOC_ID on WWDocumentsRequisites(WDR_DOC_ID)
go
create index IX_WWDocumentsRequisites_WDR_REQUISITE_ID on WWDocumentsRequisites(WDR_REQUISITE_ID)
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

UPDATE _SysParameters SET PRM_VALUE = '18' WHERE PRM_NAME LIKE ('VERSION_%_DB')
GO

