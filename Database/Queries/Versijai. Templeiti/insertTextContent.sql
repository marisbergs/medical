
if exists(select * from tempdb.dbo.sysobjects where name like '#tmp_BinaryContent')
  drop table #tmp_BinaryContent

create table #tmp_BinaryContent (
	[TXT_ID] [uniqueidentifier] NOT NULL primary key,
	[TXT_CONTENT] [ntext] NOT NULL)

BULK INSERT #tmp_BinaryContent FROM '%path%\classif.bin'
with (FORMATFILE = '%path%\classif.fmt')

INSERT INTO TextContent
 (TXT_ID, TXT_CONTENT)
SELECT TXT_ID, TXT_CONTENT
FROM #tmp_BinaryContent
WHERE NOT EXISTS (
  select *
  from TextContent
  where TextContent.TXT_ID = #tmp_BinaryContent.TXT_ID)

 UPDATE TextContent
 SET TXT_CONTENT=#tmp_BinaryContent.TXT_CONTENT
 FROM TextContent
 JOIN #tmp_BinaryContent on #tmp_BinaryContent.TXT_ID=TextContent.TXT_ID
drop table #tmp_BinaryContent
