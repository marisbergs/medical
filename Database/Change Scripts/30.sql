ALTER TABLE CMCaseViolations ADD
	CVI_IS_COPY bit NULL default 0
GO
exec sp_addextendedproperty N'MS_Description', N'Vai p�rk�pums ir kopija (Nepiecie�ams priek� p�rk�pumu kop��anas starp veidlap�m)', N'user', N'dbo', N'table', N'CMCaseViolations', N'column', N'CVI_IS_COPY'
GO

Create table InfoAboutEmployers(
IAM_ID uniqueidentifier NOT NULL constraint PK_InfoAboutEmployers primary key clustered
  constraint FK_IAM_ID references Documents(DOC_ID),
IAM_VOLUME_OF_PRODUCTION NVARCHAR(100) NULL,
[IAM_SHIFT] [tinyint] NULL ,
[IAM_SHIFT_COUNT] [int] NULL ,
[IAM_FIRST_SHIFT_COUNT] [int] NULL ,
[IAM_SECOND_SHIFT_COUNT] [int] NULL ,
[IAM_NIGHT_SHIFT_COUNT] [int] NULL ,
[IAM_WORKTIME_REGISTRATION] [tinyint] NULL ,
[IAM_OVERTIME] [tinyint] NULL ,
[IAM_OVERTIME_REGISTRED] [tinyint] NULL ,
[IAM_SHOW_REGISTRATION] [tinyint] NULL ,
[IAM_PROCESS_EXPLANATION] [tinyint] NULL ,
[IAM_EXPLANATION_ADDED_TIACT] [tinyint] NULL ,
[IAM_SHOW_WORK_SAFETY_JORNAL] [tinyint] NULL ,
[IAM_EMPLOYEE_NOTIN_JORNAL] [tinyint] NULL ,
IAM_COLLECTIVE_AGREEMENT [tinyint] NULL
)
GO
exec sp_addextendedproperty N'MS_Description', N'Inform�cija par darba dev�ju (veik�anas veidlapa)', N'user', N'dbo', N'table', N'InfoAboutEmployers'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta sist�mas identifikators', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Sara�ot�s produkcijas apjoms m�nes�', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_VOLUME_OF_PRODUCTION'
GO
exec sp_addextendedproperty N'MS_Description', N'Darbs tiek organiz�ts mai��s', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_SHIFT'
GO
exec sp_addextendedproperty N'MS_Description', N'Mai�u skaits', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_SHIFT_COUNT'
GO
exec sp_addextendedproperty N'MS_Description', N'1. mai�as darbinieku skaits', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_FIRST_SHIFT_COUNT'
GO
exec sp_addextendedproperty N'MS_Description', N'2. mai�as darbinieku skaits', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_SECOND_SHIFT_COUNT'
GO
exec sp_addextendedproperty N'MS_Description', N'Nakts mai�as darbinieku skaits', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_NIGHT_SHIFT_COUNT'
GO
exec sp_addextendedproperty N'MS_Description', N'Darba laika uzskaites tabele', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_WORKTIME_REGISTRATION'
GO
exec sp_addextendedproperty N'MS_Description', N'Darbinieks tiek nodarbin�ts virsstund�s', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_OVERTIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Virsstundas tiek re�istr�tas', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_OVERTIME_REGISTRED'
GO
exec sp_addextendedproperty N'MS_Description', N'Darbalaika uzskaites tabeles atrodas p�rbaud�maj� objekt�', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_SHOW_REGISTRATION'
GO
exec sp_addextendedproperty N'MS_Description', N'Sniegti paskaidrojumi par ra�o�anas procesu', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_PROCESS_EXPLANATION'
GO
exec sp_addextendedproperty N'MS_Description', N'Paskaidrojumi pievienoti TP aktam', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_EXPLANATION_ADDED_TIACT'
GO
exec sp_addextendedproperty N'MS_Description', N'Skat�ts darba dro��bas �urn�ls', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_SHOW_WORK_SAFETY_JORNAL'
GO
exec sp_addextendedproperty N'MS_Description', N'Objekt� atrodas darbinieki, kas nav re�istr�ti darba dro��bas �urn�l�', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_EMPLOYEE_NOTIN_JORNAL'
GO
exec sp_addextendedproperty N'MS_Description', N'Nosl�gts darba kopl�gums', N'user', N'dbo', N'table', N'InfoAboutEmployers', N'column', N'IAM_COLLECTIVE_AGREEMENT'
GO

Create table InfoAboutEmployerEmployees(
IEE_ID uniqueidentifier NOT NULL constraint PK_InfoAboutEmployerEmployees primary key clustered,
IEE_DOC_ID uniqueidentifier NOT NULL
  constraint FK_IEE_DOC_ID references InfoAboutEmployers(IAM_ID),
IEE_NAME_SURNAME NVARCHAR(250) NULL,
[IEE__DELETE_TIME] [datetime] NULL ,
[IEE__UPDATE_TIME] [datetime] NOT NULL CONSTRAINT [DF_InfoAboutEmployerEmployees_IEE__UPDATE_TIME] DEFAULT (getdate()),
[IEE__LOCK_VERSION] [int] NOT NULL CONSTRAINT [DF_InfoAboutEmployerEmployees_IEE__LOCK_VERSION] DEFAULT (1),
[IEE__VERSION] [int] NOT NULL CONSTRAINT [DF_InfoAboutEmployerEmployees_IEE__VERSION] DEFAULT (0),
[IEE__SOURCE] [uniqueidentifier] NULL
)
GO

exec sp_addextendedproperty N'MS_Description', N'Inform�cijas par darba dev�ju p�rbaud� darba dro��bas �urn�l� nere�istr�tie darba ��m�ji', N'user', N'dbo', N'table', N'InfoAboutEmployerEmployees'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta sist�mas identifikators', N'user', N'dbo', N'table', N'InfoAboutEmployerEmployees', N'column', N'IEE_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Dokumenta ID (InfoAboutEmployers)', N'user', N'dbo', N'table', N'InfoAboutEmployerEmployees', N'column', N'IEE_DOC_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'V�rds uzv�rds', N'user', N'dbo', N'table', N'InfoAboutEmployerEmployees', N'column', N'IEE_NAME_SURNAME'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta lo�isk�s izdz��anas laiks', N'user', N'dbo', N'table', N'InfoAboutEmployerEmployees', N'column', N'IEE__DELETE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'P�d�jo izmai�u veik�anas laiks', N'user', N'dbo', N'table', N'InfoAboutEmployerEmployees', N'column', N'IEE__UPDATE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Optimistisk�s blo���anas skait�t�js', N'user', N'dbo', N'table', N'InfoAboutEmployerEmployees', N'column', N'IEE__LOCK_VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta aktu�l� versija', N'user', N'dbo', N'table', N'InfoAboutEmployerEmployees', N'column', N'IEE__VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta izmai�u versijas numurs', N'user', N'dbo', N'table', N'InfoAboutEmployerEmployees', N'column', N'IEE__SOURCE'
GO
create index IX_InfoAboutEmployerEmployees_IEE_DOC_ID on InfoAboutEmployerEmployees(IEE_DOC_ID)
go

Create table InfoAboutEmployerProductionMachines(
IEP_ID uniqueidentifier NOT NULL constraint PK_InfoAboutEmployerProductionMachines primary key clustered,
IEP_DOC_ID uniqueidentifier NOT NULL
  constraint FK_IEP_DOC_ID references InfoAboutEmployers(IAM_ID),
IEP_NAME NVARCHAR(250) NULL,
IEP_USING BIT NULL DEFAULT 0,
IEP_STAFF_COUNT NVARCHAR(100) NULL,
IEP_POWER NVARCHAR(100) NULL,
IEP_WORK_TIME NVARCHAR(100) NULL,
IEP_NOTES NVARCHAR(1000) NULL,
[IEP__DELETE_TIME] [datetime] NULL ,
[IEP__UPDATE_TIME] [datetime] NOT NULL CONSTRAINT [DF_InfoAboutEmployerProductionMachines_IEP__UPDATE_TIME] DEFAULT (getdate()),
[IEP__LOCK_VERSION] [int] NOT NULL CONSTRAINT [DF_InfoAboutEmployerProductionMachines_IEP__LOCK_VERSION] DEFAULT (1),
[IEP__VERSION] [int] NOT NULL CONSTRAINT [DF_InfoAboutEmployerProductionMachines_IEP__VERSION] DEFAULT (0),
[IEP__SOURCE] [uniqueidentifier] NULL
)
GO
exec sp_addextendedproperty N'MS_Description', N'Inform�cijas par darba dev�ju p�rbaud� ra�o�an� izmantot�s iek�rtas', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta sist�mas identifikators', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Dokumenta ID (InfoAboutEmployers)', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP_DOC_ID'
GO
exec sp_addextendedproperty N'MS_Description', N'Iek�rtas nosaukums', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP_NAME'
GO
exec sp_addextendedproperty N'MS_Description', N'Izmanto ra�o�anas proces�', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP_USING'
GO
exec sp_addextendedproperty N'MS_Description', N'Apkalpojo�o darbinieku skaits', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP_STAFF_COUNT'
GO
exec sp_addextendedproperty N'MS_Description', N'Iek�rtas jauda', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP_POWER'
GO
exec sp_addextendedproperty N'MS_Description', N'Iek�rtas nodarbin�to stundu skaits dienakt�', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP_WORK_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Piez�mes', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP_NOTES'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta lo�isk�s izdz��anas laiks', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP__DELETE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'P�d�jo izmai�u veik�anas laiks', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP__UPDATE_TIME'
GO
exec sp_addextendedproperty N'MS_Description', N'Optimistisk�s blo���anas skait�t�js', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP__LOCK_VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta aktu�l� versija', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP__VERSION'
GO
exec sp_addextendedproperty N'MS_Description', N'Ieraksta izmai�u versijas numurs', N'user', N'dbo', N'table', N'InfoAboutEmployerProductionMachines', N'column', N'IEP__SOURCE'
GO
create index IX_InfoAboutEmployerProductionMachines_IEP_DOC_ID on InfoAboutEmployerProductionMachines(IEP_DOC_ID)
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
    -- ir da�as iz��mumu tabulas:
    AND NOT so.name in (
      'ATS_IZM', -- PK sast�v no 2 laukiem
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
ALTER TABLE Documents ADD
	DOC_CORRECTION_TYPE TINYINT NULL
go
exec sp_addextendedproperty N'MS_Description', N'Labo�anas veids: 1 - Labots->NM, 2 - Labots->DNS, 3 - Labots->NM, Labots->DNS', N'user', N'dbo', N'table', N'Documents', N'column', N'DOC_CORRECTION_TYPE'
GO
UPDATE _SysParameters SET PRM_VALUE = '30' WHERE PRM_NAME LIKE ('VERSION_%_DB')      