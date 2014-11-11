ALTER TABLE StateDutyServices ADD
	SDS_NOT_FROM_TAXPAYER BIT DEFAULT 0	
GO
exec sp_addextendedproperty N'MS_Description', N'paz�me ka nokav�juma nauda neattiecas uz nodok�u maks�t�ju', N'user', N'dbo', N'table', N'StateDutyServices', N'column', N'SDS_NOT_FROM_TAXPAYER'
GO
ALTER TABLE CMCaseViolationResponsibleRules ADD
	CRR_MAIN_ROLE BIT DEFAULT 0	
GO
exec sp_addextendedproperty N'MS_Description', N'Pamata normat�vais akts, ja ir vair�ki vien�di panti. Priek� APL', N'user', N'dbo', N'table', N'CMCaseViolationResponsibleRules', N'column', N'CRR_MAIN_ROLE'
GO
ALTER TABLE QualityNotes ADD
	QLN_SECOND BIT DEFAULT 0	
GO
exec sp_addextendedproperty N'MS_Description', N'Piez�me attiecas uz otreiz�jo nov�rt�jumu', N'user', N'dbo', N'table', N'QualityNotes', N'column', N'QLN_SECOND'
GO
UPDATE _SysParameters SET PRM_VALUE = '31' WHERE PRM_NAME LIKE ('VERSION_%_DB')    