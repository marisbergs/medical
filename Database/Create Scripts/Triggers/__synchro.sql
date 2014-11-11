IF EXISTS (SELECT * FROM sysobjects WHERE type = 'TR' AND name = 'BinaryFiles_synchro')
	BEGIN
		DROP  Trigger BinaryFiles_synchro
	END
GO

CREATE TRIGGER BinaryFiles_synchro
ON BinaryFiles
FOR INSERT, UPDATE 
AS 
BEGIN
  SET NOCOUNT ON

  Declare @WorkstationID uniqueidentifier,
          @CurrentVersion int,
          @Update_SOURCE bit

  SET @Update_SOURCE = 0
  IF UPDATE(BFI__SOURCE) SET @Update_SOURCE = 1

  SELECT @WorkstationID = SYC_WORKSTATION_ID,
         @CurrentVersion = SYC_CURRENT_VERSION
  FROM _SynchroConfig

  UPDATE BinaryFiles
  SET BFI__UPDATE_TIME = getdate(),
      BFI__VERSION =
        CASE
          WHEN
            @WorkstationID <> 'CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC' -- not central server
            AND @Update_SOURCE = 1 AND NOT inserted.BFI__SOURCE IS NULL -- synchronization
              THEN inserted.BFI__VERSION
          ELSE @CurrentVersion
        END,
      BFI__SOURCE =
          CASE
            WHEN @Update_SOURCE = 1 THEN ISNULL(inserted.BFI__SOURCE, @WorkstationID)
            ELSE @WorkstationID
          END
  FROM BinaryFiles inner join inserted 
       on BinaryFiles.BFI_ID = inserted.BFI_ID
END
GO

