SELECT distinct substring(sc.name, 1, charindex('_', sc.name)) as prefix, so.name as tbl_name
FROM sysobjects so inner join syscolumns sc
     on so.id = sc.id
WHERE so.xtype = 'U'
ORDER BY 1, 2
