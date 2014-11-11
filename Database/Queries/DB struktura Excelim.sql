 /*
Declare @tbl varchar(50)
Declare @res table (
  tblname varchar(50),
  descr sql_variant
)

Declare c CURSOR
FOR
  SELECT name
  FROM sysobjects so
  WHERE xtype = 'U'

OPEN c

FETCH NEXT FROM c INTO @tbl
WHILE (@@FETCH_STATUS = 0)
BEGIN
  insert into @res
  select objname, value
  from ::fn_listextendedproperty (NULL, 'user', 'dbo', 'table', @tbl, default, default)
  FETCH NEXT FROM c INTO @tbl
END

CLOSE c
DEALLOCATE c

select *
from @res
order by tblname
*/
------------------------------------
Declare @tbl varchar(50)
Declare @res table (
  tblname varchar(50),
  colname varchar(50),
  descr sql_variant
)

Declare c CURSOR
FOR
  SELECT name
  FROM sysobjects so
  WHERE xtype = 'U'

OPEN c

FETCH NEXT FROM c INTO @tbl
WHILE (@@FETCH_STATUS = 0)
BEGIN
  insert into @res
  select @tbl, objname, value
  from ::fn_listextendedproperty (NULL, 'user', 'dbo', 'table', @tbl, 'column', default)
  FETCH NEXT FROM c INTO @tbl
END

CLOSE c
DEALLOCATE c

select r.tblname, r.colname,
  st.name + 
    CASE sc.xtype
      WHEN 167 THEN '(' + cast(sc.prec as varchar) + ')' -- varchar
      WHEN 231 THEN '(' + cast(sc.prec as varchar) + ')' -- nvarchar
      WHEN 106 THEN '(' + cast(sc.prec as varchar) + ',' + cast(sc.scale as varchar) + ')' -- decimal
      ELSE ''
    END,
  CASE WHEN sc.isnullable = 1 THEN 'NULL' ELSE 'NOT NULL' END,
  r.descr
--,  CASE WHEN 
from @res r inner join syscolumns sc
     on colname = sc.name
     inner join systypes st
     on sc.xtype =  st.xusertype
order by tblname

