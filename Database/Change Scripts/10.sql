alter table AccountingDocuments add
  ACD_GIVEN_DATE1 nvarchar(100)
go

UPDATE AccountingDocuments
SET ACD_GIVEN_DATE1 = CONVERT(nvarchar(100), ACD_GIVEN_DATE, 104)
WHERE NOT ACD_GIVEN_DATE IS NULL
go

alter table AccountingDocuments drop column ACD_GIVEN_DATE
go

sp_rename 'AccountingDocuments.ACD_GIVEN_DATE1', 'ACD_GIVEN_DATE', 'COLUMN'
go

alter table AccountingDocuments alter column ACD_GIVEN_NUMBER nvarchar(100)
go

exec sp_addextendedproperty N'MS_Description', N'Attaisnojuma dokumenta datums', N'user', N'dbo', N'table', N'AccountingDocuments', N'column', N'ACD_GIVEN_DATE'
GO

--Tabulaa DOKUMENTS izveido TIMESTAMP lauku prieksh FULL-TEXT indeksa
ALTER TABLE DOKUMENTS 
ADD FULLTEXTDATE timestamp

UPDATE _SysParameters SET PRM_VALUE = '10' WHERE PRM_NAME LIKE ('VERSION_%_DB')
GO
-- Lūdzu, Юникод