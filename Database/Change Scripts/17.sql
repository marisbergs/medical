UPDATE CashOperationMoney SET COU_MONEY_VALUE=NULL
GO
ALTER TABLE CashOperationMoney ALTER COLUMN COU_MONEY_VALUE decimal(18,2) 
GO
ALTER TABLE Documents ADD 
    DOC_DEPUTY_ID uniqueidentifier NULL 
    constraint FK_DOC_DEPUTY_ID references Users(USR_ID)
GO
ALTER TABLE GambleEquipments ALTER COLUMN GME_PARTICIPATION_FEE decimal(18,2) NULL
GO
ALTER TABLE GambleEquipments ALTER COLUMN GME_CREDIT_ACQUIRED decimal(18,2) NULL
GO
ALTER TABLE GambleEquipments ALTER COLUMN GME_CREDIT_LOST decimal(18,2) NULL
GO
ALTER TABLE GambleEquipments ALTER COLUMN GME_JACKPOT decimal(18,2) NULL
GO
ALTER TABLE GambleEquipments ALTER COLUMN GME_CREDIT_ACQUIRED_WON decimal(18,2) NULL
GO
ALTER TABLE GambleEquipments ALTER COLUMN GME_CREDIT_LOST_WON decimal(18,2) NULL
GO
ALTER TABLE GambleEquipments ALTER COLUMN GME_JACKPOT_WON decimal(18,2) NULL
GO
ALTER TABLE AccountingSimpleRecords ADD ASI_SOFTWARE bit NULL DEFAULT 0
GO
ALTER TABLE AccountingSimpleRecords ADD ASI_MANUAL bit NULL DEFAULT 0
GO
ALTER TABLE AccountingSimpleRecords DROP column ASI_ACCOUNTING_TYPE
GO
exec sp_addextendedproperty N'MS_Description', N'Reìistir tiek aizpildîti elektroniski', N'user', N'dbo', N'table', N'AccountingSimpleRecords', N'column', N'ASI_SOFTWARE'
GO
exec sp_addextendedproperty N'MS_Description', N'Reìistir tiek aizpildîti manuâli', N'user', N'dbo', N'table', N'AccountingSimpleRecords', N'column', N'ASI_MANUAL'
GO
exec sp_addextendedproperty N'MS_Description', N'Vietas izpildîtâjs', N'user', N'dbo', N'table', N'Documents', N'column', N'DOC_DEPUTY_ID'
GO
UPDATE _SysParameters SET PRM_VALUE = '17' WHERE PRM_NAME LIKE ('VERSION_%_DB') 