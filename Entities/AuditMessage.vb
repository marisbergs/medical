Imports Core.Bll

''' <summary>
''' Notikumu veidi (notikumu žurnālam)
''' </summary>
Public Class AuditMessage
    Inherits HierClassifier

    Public Shared ReadOnly AttachmentSave As New Guid("476AFFAF-870F-4DF3-9174-BA7558EAC9FF")
    Public Shared ReadOnly CorrespondenceSave As New Guid("58B7AC96-F251-409E-BD7B-688270B0FB88")
    Public Shared ReadOnly DocumentHistorySetOwner As New Guid("A92DCE9A-686F-4C06-819A-5D720323B999")
    Public Shared ReadOnly DocumentHistorySetStatusDraft As New Guid("1DF16BDE-F4C7-45C4-A6AE-E6F11F3E7D68")
    Public Shared ReadOnly ExecutionDocument As New Guid("9A786E35-E10E-4C7B-8649-80D7A86EE591")
    Public Shared ReadOnly EmployerSave As New Guid("A73E8D38-92AB-4EDF-B354-0D0E74279B4E")
    Public Shared ReadOnly TimberSentDocumentSave As New Guid("50E978A8-1F44-4817-9E38-A88F9CDA4CD0")
    Public Shared ReadOnly CMCaseCommentAdded As New Guid("d87dc6de-e56e-4c79-8f16-f50e60d23100")
    Public Shared ReadOnly CMCaseCommentDeleted As New Guid("DF7CF561-E4AD-4F75-9E1C-ABEDAF3DC929")
    Public Shared ReadOnly CMCaseOpen As New Guid("152994ae-c1dd-4bea-af64-b3deaf138191")
    Public Shared ReadOnly CMCaseDelete As New Guid("e9b350d9-0ea9-466b-aadf-1190d643b700")
    Public Shared ReadOnly CMCaseCreate As New Guid("a91b292b-d05f-4824-b124-4a592b467437")
    Public Shared ReadOnly CMCaseStatusChange As New Guid("c74a4e89-3c57-4e4f-877d-6cd78d314505")

    Public Shared ReadOnly AuthorizationVisitTaxPayerSave As New Guid("6EA98AD8-2CBE-4147-8AC2-B8DC9FD64ACE")
    Public Shared ReadOnly DecisionInspectionSave As New Guid("84A3FB39-C506-456C-9843-CD2042038E81")
    Public Shared ReadOnly DecisionObservationSave As New Guid("14031D34-CC56-4A56-B3E9-214C3F7FB5C0")
    Public Shared ReadOnly DecisionThematicInspectionSave As New Guid("38EBB4E0-1E8E-41B0-AA14-A15EC8414FD2")
    Public Shared ReadOnly DecisionDealCompareSave As New Guid("62077FBC-BAA0-4493-83E4-32DFE57A2D37")
    Public Shared ReadOnly DecisionDutyInspectionSave As New Guid("891B219C-73D2-4D60-B3DA-0C8B37EA1B4D")
    Public Shared ReadOnly TimberCheckOnRoadSave As New Guid("55088444-64BD-4904-8E7E-B1BE88A75302")
    Public Shared ReadOnly TimberReceivedDocumentSave As New Guid("727C2E58-21D2-4DB8-9ABF-C01D3EEE3534")
    Public Shared ReadOnly ConstructionSave As New Guid("666961E0-9E45-442C-B66B-DF06BE471C65")
    Public Shared ReadOnly FixedAssetSave As New Guid("1C9FDA4E-8331-457E-86AE-43F004DF53A6")
    Public Shared ReadOnly MandatoryFormSave As New Guid("113BC559-E706-4BF7-B3AE-F7A9523A4ED3")
    Public Shared ReadOnly MetalSave As New Guid("EEE0FECB-730D-45E7-B9EA-F6FE5E2AE5A1")
    Public Shared ReadOnly RealEstateSave As New Guid("3D03F58A-0CF3-4334-9700-7F9C7AC9477D")
    Public Shared ReadOnly SrsNumberSave As New Guid("49A60EB9-A05E-4F5A-884E-3D1F5C316CA3")
    Public Shared ReadOnly TimberStorageCheckSave As New Guid("F79173BA-FDD0-4FD8-9E43-D247D88F2265")
    Public Shared ReadOnly CharacterStatementSave As New Guid("887DC6FC-AAA4-4202-AA01-75F6B12EDEA6")
    Public Shared ReadOnly TimberStackMeasureSave As New Guid("E92FF587-5B8E-4BE8-8D77-26252ADFE4B8")
    Public Shared ReadOnly RiskDutiesSave As New Guid("CA99A3D7-2709-4F7F-8E0C-3DFF1BB18F75")
    Public Shared ReadOnly StateDutiesSave As New Guid("506C9832-3D6A-4A55-B02E-63C7170D7730")
    Public Shared ReadOnly GamblingSave As New Guid("C1153000-2853-45A8-A9EA-8135F4255A76")
    Public Shared ReadOnly EndDecisionHaltSave As New Guid("7BF54FBB-98B5-44B2-81E4-2F23826C6B32")
    Public Shared ReadOnly EndDecisionSave As New Guid("2F609FB7-1625-4763-A3B3-937811343863")
    Public Shared ReadOnly InfoAboutStatedSave As New Guid("4A1083A4-6B12-4A1D-96EB-4EA59F902AE1")

    Public Shared ReadOnly ActivityWasOpened As New Guid("46d9845f-0a8f-4315-ac0a-5311c0fa9eb8")
    Public Shared ReadOnly ActivitySave As New Guid("2131E14C-C996-419E-B791-4883E38370C5")
    Public Shared ReadOnly ActivityAdd As New Guid("00F1C8A1-EC03-4136-9150-AA32A03A82DF")
    Public Shared ReadOnly TiActSave As New Guid("1A62E8BC-F4FB-44BE-98B0-37E30DBC0597")
    Public Shared ReadOnly TiActEndSave As New Guid("7EDF2549-1462-44BB-AB44-5A608D0F5163")
    Public Shared ReadOnly InspectionActSave As New Guid("2DD7FDE8-38E4-4AC9-997C-DE005E20E163")
    Public Shared ReadOnly ObservationActSave As New Guid("736BE7C5-4FDA-4EAD-ABB8-1570F45B2B8B")
    Public Shared ReadOnly EAAct1_4Save As New Guid("08FBD5A4-8A86-44F7-BCCA-9F42A9C1F56E")
    Public Shared ReadOnly EAAct2Save As New Guid("7BA98810-F49F-43EA-A06E-5BFAAC74061F")
    Public Shared ReadOnly EAAct3Save As New Guid("BEABD059-6DAE-431D-B08D-C01E07F30C97")
    Public Shared ReadOnly SpecialActSave As New Guid("F01653D5-37C1-48F5-A3E4-9702594E7E27")
    Public Shared ReadOnly SpecialActEndSave As New Guid("13716160-E2B5-4647-AAB6-38C54BCFCE36")
    Public Shared ReadOnly TcdPlanDelete As New Guid("7D3219F0-9BB8-48E6-8C54-2383E4559480")
    Public Shared ReadOnly RoleCreate As New Guid("246f6174-291a-4ed9-89d6-8e5adc6b0abb")
    Public Shared ReadOnly RoleDelete As New Guid("49c519e3-6c74-4374-bd57-b4ae168afae0")
    Public Shared ReadOnly RolePermissionsChange As New Guid("a7bfc23d-6119-4d29-9d78-5194dc9d0d9c")
    Public Shared ReadOnly RoleRename As New Guid("e8707769-0a46-461d-b034-73ce3d05d17c")

    Public Shared ReadOnly OrganizationSave As New Guid("6E225C09-A8FA-4B59-AC90-03047698C9E4")
    Public Shared ReadOnly OrganizationDelete As New Guid("C310A390-CC67-488E-9F34-F4C17124DF91")

    Public Shared ReadOnly UserDelete As New Guid("CF752083-0990-4323-AF9F-BD08962CA785")
    Public Shared ReadOnly UserLockOut As New Guid("5B135E76-A1E1-4226-A9BB-CC4EA65EDEEC")
    Public Shared ReadOnly UserAdd As New Guid("61237990-24B9-4555-BF9C-DB108FF094A4")
    Public Shared ReadOnly UserChangeLogonAndRole As New Guid("FE9E6CCC-6844-4002-B5AE-B775F3DC6271")
    Public Shared ReadOnly UserUnavailabilityInfoChanged As New Guid("F931F9A0-A195-41DB-97B1-B6129E427CBD")
    Public Shared ReadOnly UserBasicInfoChanged As New Guid("C47E5A2F-4919-4339-9FA9-3CE60795D78D")
    Public Shared ReadOnly UserAdditionalInfoChanged As New Guid("B3CE3657-9A05-4C3B-8BBE-6002D66B7859")
    Public Shared ReadOnly UserReplacementAddedOrChanged As New Guid("CC727508-43D4-4888-A68B-A1E36FE9F5C8")
    Public Shared ReadOnly UserReplacementDeleted As New Guid("7E630610-6AC1-4741-B80C-EFD154E41117")
    Public Shared ReadOnly UserAuthorizationChanged As New Guid("9EAE933F-7F1E-4F72-8A8F-C85ADB1011BD")

    Public Shared ReadOnly LogonFailedAD As New Guid("68ce0c18-8abf-4e6c-adbe-85a50b5945da")
    Public Shared ReadOnly LogonFailedTPAIS As New Guid("119bb015-002b-4f7e-99fe-24f1ad608317")
    Public Shared ReadOnly LogonSucceeded As New Guid("233100cc-1742-47a7-9ac3-cb35fc74261a")
    Public Shared ReadOnly LogonImpersonates As New Guid("199c9a65-54a9-4376-a065-7a3a9cc67e6d")

    Public Shared ReadOnly ViolationSave As New Guid("d9c3ba60-f1d2-43ba-882d-d2020dba5684")

    Public Shared ReadOnly AVProtocolSave As New Guid("A807494A-3732-46E5-9E05-E6E1A4DB9583")
    Public Shared ReadOnly LocalDBUpdateSuccess As New Guid("4043dacd-8302-416d-b692-9250f67c0a69")
    Public Shared ReadOnly LocalDBUpdateFailure As New Guid("1b336b21-3a62-4cf6-9962-941971db44b0")
    Public Shared ReadOnly LocalDBRestoredFromBackup As New Guid("66e7a5d8-494c-4e05-88dc-8eb23ff8fc85")
    Public Shared ReadOnly ActsWithoutAlgorithmSave As New Guid("6E5C6740-40D8-4769-BE44-C34EED86664C")
    Public Shared ReadOnly QualitySave As New Guid("24583420-EC3E-4974-AD9B-EF92DA0B7145")

    Public Shared ReadOnly SynchronizationMessage As New Guid("5613c0cd-ed74-4cc7-8812-ba74bfe78507")

    Public Shared ReadOnly NoticeViolationsSave As New Guid("14B6C85F-AFDE-44AB-8D32-277502BC85CB")
    Public Shared ReadOnly NoticePenaltiesSave As New Guid("868F6255-760B-4FDE-A189-E96F4EC1C6B3")

    Public Shared ReadOnly ClassifierDelete As New Guid("AAB7739B-AC1E-4D83-BB46-36E034E172F7")

    Public Shared ReadOnly AppealSave As New Guid("2BDB08B4-8DED-4316-85C9-FD7DC6445351")

    Public Shared ReadOnly AuditLogExported As New Guid("8D700BB0-A2FF-47F7-B401-48A48ADDF8FA")
    Public Shared ReadOnly AuditLogImported As New Guid("328AF5FD-AAED-4417-B79D-09E736A7DBB5")

    Public Shared ReadOnly TcdPlanChange As New Guid("11F52DA6-4BB0-4726-AD76-979CA96F807A")
    Public Shared ReadOnly TcdPlanChangeStatus As New Guid("D533D7E7-F365-4615-A854-118FE09E9E04")
    Public Shared ReadOnly TcdPlanAddCMCase As New Guid("4CB611BE-3150-4B27-AEB2-81A3D66D129A")
    Public Shared ReadOnly TcdPlanRemoveCMCase As New Guid("1C4CD173-01B0-4FD3-A92D-28D65BD44C74")
    Public Shared ReadOnly TcdPlanAddNew As New Guid("B5D61E85-300F-4C28-AC06-0D6CF7395781")

    Public Shared ReadOnly TemplateOpen As New Guid("1DA35D00-05E7-4D6A-8C8C-3D57236A5FC1")
    Public Shared ReadOnly TemplateCreate As New Guid("082BA48F-71D9-441D-9981-3D0D4E1E34B9")
    Public Shared ReadOnly TemplateChange As New Guid("0073AA53-C83C-4FCA-942B-BB8513F8429C")
    Public Shared ReadOnly TemplateDelete As New Guid("53D22A57-5F00-4B9E-A0D4-F962C591F30F")

    Public Shared ReadOnly WarehouseRequestSave As New Guid("B1BEC195-0CCC-4E8F-B032-5843DF9C0576")
    Public Shared ReadOnly WholesaleSave As New Guid("AE612B6F-7B74-4E18-8FDF-3AA237A34709")
    Public Shared ReadOnly WaybillsSave As New Guid("D1C9F972-F8E1-4B13-B116-79BA0105CCDD")
    Public Shared ReadOnly CashOperationsSave As New Guid("85E68E06-A168-4339-B4D9-C92AF95CD03D")

    Private _notifications As Core.Dal.IChildCollection(Of Entities.LogEntryConfig)

    Public Overridable ReadOnly Property ReturFalse() As Boolean
        Get
            Return False
        End Get
    End Property

    Public Overridable Property Notifications() As Core.Dal.IChildCollection(Of Entities.LogEntryConfig)
        Get
            Return _notifications
        End Get
        Set(ByVal value As Core.Dal.IChildCollection(Of Entities.LogEntryConfig))
            Assign("Notifications", value, _notifications)
            If Not (_notifications Is Nothing) Then
                _notifications.Parent = Me
            End If
        End Set
    End Property


    Public Overridable Property Priority() As PriorityType
        Get
            If CType(DecimalValue, Integer) = 2 Then
                Return PriorityType.High
            Else
                Return PriorityType.Low
            End If
        End Get
        Set(ByVal value As PriorityType)
            Select Case value
                Case PriorityType.High
                    DecimalValue = 2
                Case Else
                    DecimalValue = 1
            End Select
        End Set
    End Property

    Public Overridable Property CurrentUser() As Boolean
        Get
            If Text Is Nothing Then Return Nothing
            Return (Text = "1")
        End Get
        Set(ByVal value As Boolean)
            Text = CStr(IIf(value, "1", "0"))
        End Set
    End Property


    Public Overrides ReadOnly Property CanEdit() As Boolean
        Get
            Return CanDo("Logging.Management")
        End Get
    End Property

End Class


' Уныкоде
