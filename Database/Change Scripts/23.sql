ALTER TABLE StatementPenaltyRules ADD
	SPL_OTHER_DECISION_ID uniqueidentifier NULL
	constraint FK_SPL_OTHER_DECISION_ID references Classifiers(CLS_ID)
GO
exec sp_addextendedproperty N'MS_Description', N'Lçmuma ID Classifier (OtherDecision)', N'user', N'dbo', N'table', N'StatementPenaltyRules', N'column', N'SPL_OTHER_DECISION_ID'
GO
ALTER TABLE StatementPenaltyRules ADD
	SPL_CONFISCATION bit NULL default 0
GO
exec sp_addextendedproperty N'MS_Description', N'Konfiskâcija', N'user', N'dbo', N'table', N'StatementPenaltyRules', N'column', N'SPL_CONFISCATION'
GO
UPDATE _SysParameters SET PRM_VALUE = '23' WHERE PRM_NAME LIKE ('VERSION_%_DB')    