''' <summary>Darījuma partnera veidi</summary>
Public Enum TaxpayerTypeEnum

    ''' <summary>Darījumu partneris reģistrēts kā NM</summary>
    IsTaxpayer = 1
    ''' <summary>Juridiska persona nav NM</summary>
    NotTaxpayer_JP = 2
    ''' <summary>Fiziska persona nav NM</summary>
    NotTaxpayer_FP = 3
End Enum


Public Class TaxpayerType
    Inherits Core.EnumWrapper(Of TaxpayerTypeEnum)

    Sub New(ByVal value As TaxpayerTypeEnum)
        MyBase.New(value)
    End Sub
    Sub New()
        MyBase.New()
    End Sub
    ' Constant predefined values

    ''' <summary>Darījumu partneris reģistrēts kā NM</summary>
    Public Shared ReadOnly IsTaxpayer As TaxpayerType = New TaxpayerType(TaxpayerTypeEnum.IsTaxpayer)
    ''' <summary>Juridiska persona nav NM</summary>
    Public Shared ReadOnly NotTaxpayer_JP As TaxpayerType = New TaxpayerType(TaxpayerTypeEnum.NotTaxpayer_JP)
    ''' <summary>Fiziska persona nav NM</summary>
    Public Shared ReadOnly NotTaxpayer_FP As TaxpayerType = New TaxpayerType(TaxpayerTypeEnum.NotTaxpayer_FP)

    ''' <summary>
    ''' Optimized ListSource (provided constant elements are already translated)
    ''' </summary>
    Public Overloads Shared ReadOnly Property ListSource() As IList
        Get
            If _listHolder Is Nothing Then
                _listHolder = New ArrayList
                _listHolder.Add(IsTaxpayer)
                _listHolder.Add(NotTaxpayer_JP)
                _listHolder.Add(NotTaxpayer_FP)
            End If
            Return _listHolder
        End Get
    End Property
    Public Shared ReadOnly Property WithoutEmpty() As IList
        Get
            Dim _list As ArrayList
            _list = New ArrayList
            _list.Add(NotTaxpayer_JP)
            _list.Add(NotTaxpayer_FP)
            Return _list
        End Get
    End Property

End Class
