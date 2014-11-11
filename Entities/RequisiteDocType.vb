Option Strict On

''' <summary>
''' Neuzrādito rkvizītu dokumenti
''' </summary>
Public Enum RequisiteDocTypeEnum
    CashRegister
    ReceiptBook
    Journal
    ZReport
End Enum

''' <summary>
''' Neuzrādito rkvizītu dokumenti
''' </summary>
Public Class RequisiteDocType
    Inherits Core.EnumWrapper(Of RequisiteDocTypeEnum)

    Sub New(ByVal value As RequisiteDocTypeEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub

    ''' <summary>Kases aparāts</summary>
    Public Shared ReadOnly CashRegister As RequisiteDocType = New RequisiteDocType(RequisiteDocTypeEnum.CashRegister)
    ''' <summary>Kvīšu grāmatiņa</summary>
    Public Shared ReadOnly ReceiptBook As RequisiteDocType = New RequisiteDocType(RequisiteDocTypeEnum.ReceiptBook)
    ''' <summary>EKA žurnāls</summary>
    Public Shared ReadOnly Journal As RequisiteDocType = New RequisiteDocType(RequisiteDocTypeEnum.Journal)
    ''' <summary>"Z" pārskats</summary>
    Public Shared ReadOnly ZReport As RequisiteDocType = New RequisiteDocType(RequisiteDocTypeEnum.ZReport)
End Class
