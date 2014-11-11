Imports Core.Bll
Imports Core.Dal
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class DnsClassifierMapper
    Public root As String
    Public type As String
    Public xml_id As String
    Public xml_parent_id As String
    Public custom_sql As String
    Public tableFields() As String
    Public xmlFields() As String
    Public dataTypes() As String
    Public fieldTransforms() As DictionaryEntry
    Public Function XmlFieldsWithDataTypes() As String
        Dim result(xmlFields.Length - 1) As String

        For i As Integer = 0 To xmlFields.Length - 1
            result(i) = xmlFields(i) & " " & dataTypes(i)
        Next
        Return String.Join(",", result)
    End Function

    Public Function XmlFieldsAssignedToTableFields() As String
        Dim result(xmlFields.Length - 1) As String

        For i As Integer = 0 To xmlFields.Length - 1
            result(i) = tableFields(i) & " = " & xmlFields(i)
        Next
        Return String.Join(",", result)
    End Function


    Public Function GetSqlCommandString() As String
        If Not custom_sql Is Nothing Then
            Return custom_sql
        End If

        Dim tableFieldList As String = String.Join(",", tableFields)
        '' parameters:
        '' {0} - tableFieldList: a comma separated list of table fields to insert/update (excluding the cls_type_id)
        '' {1} - type: the name of classifierType == discriminator value
        '' {2} - root: xml root path
        '' {3} - XMLFieldsWithDataTypes: a comma separated list of xmlfields with according datatypes used in openxml with clause
        '' {4} - xml_id: the name of the xml id column which is mapped to classifiers as external_id
        '' {5} - XmlFieldsAssignedToTableFields: a comma separated list of xml fields assigned to table fields used in update clause to update existing records
        Dim result As String = String.Format( _
            "declare @idoc int " & _
            "exec sp_xml_preparedocument @idoc OUTPUT, @doc " & _
            "insert into Classifiers( CLS_TYPE_ID, {0} )" & _
            "select '{1}', * from openxml (@idoc, '{2}',2) with ({3})" & _
            "where not exists (select * from Classifiers where([{4}] = CLS__EXTERNAL_ID and CLS_TYPE_ID = '{1}'))" & _
            "update Classifiers set {5} from openxml (@idoc, '{2}',2) with({3})" & _
            "where CLS__EXTERNAL_ID = {4} and CLS_TYPE_ID = '{1}' ", _
            tableFieldList, type, root, XmlFieldsWithDataTypes(), xml_id, XmlFieldsAssignedToTableFields())
        If Not (xml_parent_id Is Nothing) Then
            Dim fromXmlClause As String = String.Format("openxml (@idoc, '{0}',2) with ({1}", root, XmlFieldsWithDataTypes)
            fromXmlClause &= ", " & xml_parent_id.ToString() & " int)"
            result &= String.Format( _
            "update Classifiers set CLS_PARENT_ID = ( select c1.CLS_ID from Classifiers as c1 where c1.CLS_TYPE_ID='{1}' and c1.CLS__EXTERNAL_ID = ( select {2} from {3} where {4} = Classifiers.CLS__EXTERNAL_ID )) where CLS_TYPE_ID = '{1}' " & _
            "update Classifiers set CLS_PARENT_ID = null where CLS_PARENT_ID = CLS_ID and CLS_TYPE_ID = '{1}' " _
            , tableFieldList, type, xml_parent_id, fromXmlClause, xml_id)
        End If
        result &= "exec sp_xml_removedocument @idoc"
        Return result
    End Function

End Class



Public Class Synchronizer


    Public Function SynchronizeClassifiers(ByVal session As ISession) As Core.Result

        Dim result As New Core.Result
        'Dim conn As SqlConnection = CType(session.Connection, SqlConnection)


        'Dim dns_item_update As WHReport = Entities(Of WHReport).GetAll(session, New Expressions.Eq("Code", "DNS_Items"))(0)
        'result += dns_item_update.PerformClassifierUpdate(conn)

        'Dim WHReportTypes As Entities(Of WHReport) = Entities(Of WHReport).GetAll(session, New Expressions.Eq("Code", "Classifiers"))
        'If WHReportTypes.Count <> 1 Then
        '    Return result
        'End If

        'Dim tpaisCriteria As New List(Of Core.Dal.Expressions.CriterionBase)()
        'tpaisCriteria.Add(New Core.Dal.Expressions.Eq("Parents", WHReportTypes(0)))
        'Dim classifiersToSynchronize As IList(Of WHReport) = session.CreateAndBuildCriteria(Of WHReport)(tpaisCriteria).AddOrder(New NHibernate.Expression.Order("DecimalValue", True)).List(Of WHReport)()




        'For Each item As WHReport In classifiersToSynchronize
        '    result += item.PerformClassifierUpdate(conn)
        'Next
        Return result
    End Function
End Class
