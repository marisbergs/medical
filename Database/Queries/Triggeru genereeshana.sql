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

