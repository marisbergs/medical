UPDATE StateDuties SET SDU_OTHER_INFORMATION = NULL
GO
ALTER TABLE StateDuties ALTER COLUMN SDU_OTHER_INFORMATION nvarchar(3900) NULL
GO
ALTER TABLE StateDuties ADD 
    SDU_MISS_PAYMENT_TYPE_ID uniqueidentifier NULL 
    constraint FK_SDU_MISS_PAYMENT_TYPE_ID references Classifiers(CLS_ID)
GO
ALTER TABLE StateDuties ADD 
    SDU_MISS_ACCOUNT_ID uniqueidentifier NULL 
    constraint FK_SDU_MISS_ACCOUNT_ID references Classifiers(CLS_ID)
GO
ALTER TABLE StateDuties ADD 
    SDU_PENAL_PAYMENT_TYPE_ID uniqueidentifier NULL 
    constraint FK_SDU_PENAL_PAYMENT_TYPE_ID references Classifiers(CLS_ID)
GO
ALTER TABLE StateDuties ADD 
    SDU_PENAL_ACCOUNT_ID uniqueidentifier NULL 
    constraint FK_PENAL_MISS_ACCOUNT_ID references Classifiers(CLS_ID)
GO
ALTER TABLE CashOperationMoney ADD 
    COU_ADD_MANUALY bit NULL DEFAULT 0
GO
UPDATE EAAct2Inventories SET EAI_MONEY_VALUE=NULL 
GO
ALTER TABLE TimberCheckOnRoad ALTER COLUMN TCR_CAR_NUMBER nvarchar(20) NULL
GO
ALTER TABLE EAAct2Inventories ALTER COLUMN EAI_MONEY_VALUE decimal(18,2) NULL
GO
exec sp_addextendedproperty N'MS_Description', N'Cita nauda', N'user', N'dbo', N'table', N'CashOperationMoney', N'column', N'COU_ADD_MANUALY'
GO
exec sp_addextendedproperty N'MS_Description', N'Nokavçtâ maksâjuma veids', N'user', N'dbo', N'table', N'StateDuties', N'column', N'SDU_MISS_PAYMENT_TYPE_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Nokavçtâ maksâjuma konta numurs', N'user', N'dbo', N'table', N'StateDuties', N'column', N'SDU_MISS_ACCOUNT_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Sodanaudas maksâjuma veids', N'user', N'dbo', N'table', N'StateDuties', N'column', N'SDU_PENAL_PAYMENT_TYPE_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Sodanaudas maksâjuma konta numurs', N'user', N'dbo', N'table', N'StateDuties', N'column', N'SDU_PENAL_ACCOUNT_ID'
GO
Create table AppealFiles (
APF_ID uniqueidentifier NOT NULL constraint PK_AppealFiles primary key clustered,
APF_DOC_ID uniqueidentifier NOT NULL
  constraint FK_APF_DOC_ID references Documents(DOC_ID),
APF_FILE_ID uniqueidentifier not null
  constraint FK_APF_FILE_ID references BinaryFiles(BFI_ID),
[APF__DELETE_TIME] [datetime] NULL ,
[APF__UPDATE_TIME] [datetime] NOT NULL CONSTRAINT [DF_AppealFiles_APF__UPDATE_TIME] DEFAULT (getdate()),
[APF__LOCK_VERSION] [int] NOT NULL CONSTRAINT [DF_AppealFiles_APF__LOCK_VERSION] DEFAULT (1),
[APF__VERSION] [int] NOT NULL CONSTRAINT [DF_AppealFiles_APF__VERSION] DEFAULT (0),
[APF__SOURCE] [uniqueidentifier] NULL
)
GO
create index IX_AppealFiles_APF_DOC_ID on AppealFiles(APF_DOC_ID)
go
create index IX_AppealFiles_APF_FILE_ID on AppealFiles(APF_FILE_ID)
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
exec sp_addextendedproperty N'MS_Description', N'Dokumenta identifikators (Documents)', N'user', N'dbo', N'table', N'AppealFiles', N'column', N'APF_DOC_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Faila identifikators(BinaryFile)', N'user', N'dbo', N'table', N'AppealFiles', N'column', N'APF_FILE_ID'
GO

UPDATE _SysParameters SET PRM_VALUE = '19' WHERE PRM_NAME LIKE ('VERSION_%_DB')  