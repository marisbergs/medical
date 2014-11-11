
if exists(select * from tempdb.dbo.sysobjects where name like '#tmp_BinaryContent%')
  drop table #tmp_BinaryContent

create table #tmp_BinaryContent (
	[BCO_ID] [uniqueidentifier] NOT NULL primary key,
	[BCO_CONTENT] [image] NOT NULL)

BULK INSERT #tmp_BinaryContent FROM '%path%\res.bin'
with (FORMATFILE = '%path%\bcp.fmt')

INSERT INTO BinaryContent
 (BCO_ID, BCO_CONTENT)
SELECT BCO_ID, BCO_CONTENT
FROM #tmp_BinaryContent
WHERE NOT EXISTS (
  select *
  from BinaryContent
  where BinaryContent.BCO_ID = #tmp_BinaryContent.BCO_ID)

drop table #tmp_BinaryContent
