SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO
ALTER    PROCEDURE dbo.spSimpleTableCopyToLocal 
	(
	@centralWatermarkLow integer,
	@centralWatermarkHigh integer,
	@centralServerSchema nvarchar(80),
	@tableName nvarchar(80),
	@tablePrefix nvarchar(10),
	@selfRefFieldName1 nvarchar(80) = '',
	@selfRefFieldName2 nvarchar(80) = '',
	@selfRefFieldName3 nvarchar(80) = '',
	@pkField1 nvarchar(80) = NULL,
	@pkField2 nvarchar(80) = NULL,
	@pkField3 nvarchar(80) = NULL
	)
AS
	/* SET NOCOUNT ON */
	
	DECLARE @sql NVARCHAR(4000)
	DECLARE @insSql NVARCHAR(4000)

	IF @centralWatermarkHigh = 0 BEGIN
		-- Special case: whole table has to be copied
		SET @sql = N'TRUNCATE TABLE dbo.' + @tableName + N' INSERT INTO dbo.' + @tableName + N' SELECT * FROM ' + @centralServerSchema + N'.dbo.' + @tableName
		PRINT @sql
		EXECUTE sp_executesql @sql
		RETURN
	END
	
	If @pkField1 IS NULL
		SET @pkField1 = @tablePrefix + N'_ID'
	
	IF EXISTS (SELECT * FROM tempdb.dbo.sysobjects WHERE name='##c')
		DROP TABLE ##c
		
	SET @sql = N'SELECT * INTO ##c FROM ' + @centralServerSchema + N'.dbo.' + @tableName + N' WHERE ' + @tablePrefix + N'__VERSION BETWEEN @low AND @high'
    PRINT @sql
    EXECUTE sp_executesql @sql, N'@low INTEGER, @high INTEGER', @low = @centralWatermarkLow, @high = @centralWatermarkHigh
	
	SET @sql = N'CREATE UNIQUE INDEX UX_c_temp ON ##c(' + @pkField1 + COALESCE(N',' + @pkField2, '') + N')'
    PRINT @sql
    EXECUTE sp_executesql @sql
    
	DECLARE _columns CURSOR READ_ONLY FOR
		select name, DATALENGTH(autoval) from syscolumns where id = (select id from sysobjects where name=@tableName and xtype='U') order by colorder
	DECLARE @insertColumns NVARCHAR(4000)
	DECLARE @updateColumns NVARCHAR(4000)
	DECLARE @setIdentityInsert NVARCHAR(120)
	SET @setIdentityInsert = NULL
	SET @insertColumns = N''
	SET @updateColumns = N''
	DECLARE @colName NVARCHAR(80)
	DECLARE @autoval INTEGER
	OPEN _columns
	FETCH NEXT FROM _columns INTO @colName, @autoval
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF @autoval IS NOT NULL AND @setIdentityInsert IS NULL
			SET @setIdentityInsert = N' SET IDENTITY_INSERT ' + @tableName
		IF @colName NOT IN (@selfRefFieldName1, @selfRefFieldName2, @selfRefFieldName3, N'FULLTEXTDATE')
			SET @insertColumns = @insertColumns + N', ' + @colName
		IF @colName NOT IN (@pkField1, ISNULL(@pkField2,'!'), N'FULLTEXTDATE')
			SET @updateColumns = @updateColumns + N', ' + @colName + N'=c.' + @colName
		FETCH NEXT FROM _columns INTO @colName, @autoval
	END
	CLOSE _columns
	DEALLOCATE _columns
	
	
	
	SET @insSql = COALESCE(@setIdentityInsert + N' ON ', '') + N'INSERT INTO ' + @tableName + N'(' + SUBSTRING(@insertColumns,3,4000) + N')'
				  + N' SELECT ' + SUBSTRING(REPLACE(@insertColumns,', ', ', c.'),3,4000)
	              + N' FROM ##c c LEFT OUTER JOIN ' + @tableName + N' l' +
	              + N' ON c.' + @pkField1 + N' = l.' + @pkField1 + COALESCE(N' AND c.' + @pkField2 + N' = l.' + @pkField2, '')
				  + N' WHERE l.' + @pkField1 + N' IS NULL'
				  + COALESCE(@setIdentityInsert + N' OFF', '')
	PRINT @insSql
	EXECUTE sp_executesql @insSql

	SET @sql = N'UPDATE ' + @tableName + N' SET ' + SUBSTRING(@updateColumns, 3, 4000)
				  + N' FROM ##c c INNER JOIN ' + @tableName + N' l' +
	              + N' ON c.' + @pkField1 + N' = l.' + @pkField1 + COALESCE(N' AND c.' + @pkField2 + N' = l.' + @pkField2, '')
	PRINT @sql
	EXECUTE sp_executesql @sql
	
	DROP TABLE ##c

	DECLARE @centralCount as int
	DECLARE @localCount as int
	SET @sql = N'SELECT * INTO ##c FROM dbo.' + @tableName
	EXECUTE sp_executesql @sql
	SELECT @localCount = COUNT(*) FROM ##c
	DROP TABLE ##c

	SET @sql = N'SELECT * INTO ##c FROM ' + @centralServerSchema + N'.dbo.' + @tableName
	EXECUTE sp_executesql @sql
	SELECT @centralCount = COUNT(*) FROM ##c
	PRINT @localCount
	PRINT @centralCount
	if (@localCount<@centralCount)
	BEGIN
		EXECUTE sp_executesql @insSql
	END
	DROP TABLE ##c
		
	RETURN


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

ALTER TABLE CMCaseViolationResponsibleRules ALTER COLUMN CRR_PENALTY decimal(18,2) NULL
GO
ALTER TABLE StatementPenaltyRules ALTER COLUMN SPL_PENALTY decimal(18,2) NULL
GO
ALTER TABLE StatementViolationDetails ADD 
    SVD_ARTICLE_ID uniqueidentifier NULL 
    constraint FK_SVD_ARTICLE_ID references Classifiers(CLS_ID)
GO
exec sp_addextendedproperty N'MS_Description', N'NIS izzi�as LAPK pants', N'user', N'dbo', N'table', N'StatementViolationDetails', N'column', N'SVD_ARTICLE_ID'
GO
ALTER TABLE StatementViolationDetails ADD 
    SVD_EXTERNAL_VIOLATION_ID uniqueidentifier NULL 
    constraint FK_SVD_EXTERNAL_VIOLATION_ID references Classifiers(CLS_ID)
GO
exec sp_addextendedproperty N'MS_Description', N'NIS izzi�as p�rk�pums', N'user', N'dbo', N'table', N'StatementViolationDetails', N'column', N'SVD_EXTERNAL_VIOLATION_ID'
GO
ALTER TABLE StatementViolationDetails ALTER COLUMN SVD_VIOLATION_THEME_ID uniqueidentifier NULL
GO
UPDATE _SysParameters SET PRM_VALUE = '20' WHERE PRM_NAME LIKE ('VERSION_%_DB')  

 