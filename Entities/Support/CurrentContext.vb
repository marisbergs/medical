Imports System.Collections.Generic
Imports System.Threading
Imports Core.Bll
Imports Microsoft.Win32

''' <summary>
''' Current context
''' </summary>
Public Class Context

    Private _authenticatedUser As User
    Private _impersonatedUser As User
    Private _permissions As IDictionary
    Private _connectedTo As Core.Dal.ConnectionTarget
    Private _developmentDebugMode As Nullable(Of Boolean)
    Private _iPAddress As String
    Private _localization As Entities(Of Localization)

    Private Shared _instance As Context
    Private Shared ReadOnly lock As New Object

    Private Const REGISTRY_SUBKEY As String = "Software\Lattelecom Technology\TPAIS"

    Public ReadOnly Property DevelopmentDebugMode() As Boolean
        Get
#If DEBUG Then
            If Not _developmentDebugMode.HasValue Then
                Dim tf As String = System.Configuration.ConfigurationManager.AppSettings("developmentDebugMode")
                _developmentDebugMode = Not String.IsNullOrEmpty(tf) AndAlso tf.ToLower = "true"
            End If
            Return _developmentDebugMode.Value
#Else
            Return False
#End If
        End Get
    End Property

    Public Shared ReadOnly Property Current() As Context
        Get
            Monitor.Enter(lock)
            If (_instance Is Nothing) Then
                _instance = New Context()
            End If
            Monitor.Exit(lock)
            Return _instance
        End Get
    End Property
    ''' <summary>
    ''' Informācija par autorizēto lietotāju
    ''' </summary>
    ''' <value><seealso cref="User"/> objekts, kas atbilst autorizētajam lietotājam</value>
    ''' <remarks>Lietotājs, ar kura vārdu un paroli notika pieslēgšanās sistēmai</remarks>
    Public Property AuthenticatedUser() As User
        Get
            Return _authenticatedUser
        End Get
        Private Set(ByVal value As User)
            _authenticatedUser = value
            ImpersonatedUser = _authenticatedUser

        End Set
    End Property


    Private Sub RefreshPermissions()
        Permissions.Clear()
        If Not (_impersonatedUser Is Nothing OrElse _impersonatedUser.Role Is Nothing) Then
            For Each p As Permission In _impersonatedUser.Role.Permissions
                If Me.ConnectedTo = Core.Dal.ConnectionTarget.Central Then
                    Permissions.Add(p.Id, Nothing)
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' Pieslēgšanās sistēmai
    ''' </summary>
    ''' <param name="userName">Lietotāja vārds formā DOMAIN\User</param>
    ''' <param name="password">Lietotāja AD parole</param>
    ''' <param name="session">Starting ISession for the application</param>
    ''' <param name="target">Pieslēgšanās centrālajam vai lokālajam serverim</param>
    ''' <returns>Saraksts ar iespējamajām lietotāja identitātēm</returns>
    Public Function Connect(ByVal userName As String, ByVal password As String, ByRef session As Core.Dal.ISession, ByVal target As Core.Dal.ConnectionTarget) As Core.Bll.Entities(Of User)
        AuthenticatedUser = Nothing

        Core.Dal.Manager.Instance.SetDefaultConnectionTarget(target)
        session = Core.Dal.Manager.Instance.OpenSession()

        If target = Core.Dal.ConnectionTarget.Local Then
            Me.SynchronizationNeeded = True
        End If

        If DevelopmentDebugMode Then
            If userName <> password Then
                session.Close()
                session = Nothing
                Return Nothing
            End If
            'ElseIf Not Core.SecurityHelper.ValidatePassword(userName, password) Then
            '    Core.Logger.DB.Log(session, AuditMessage.LogonFailedAD, userName)
            '    session.Commit()
            '    session.Close()
            '    session = Nothing
            '    Return Nothing
        End If

        Dim result As Core.Bll.Entities(Of User)
        ' Get user info
        Dim searchCriteria As Core.Dal.Expressions.CriterionBase = New Core.Dal.Expressions.Eq("Logon", userName)
        searchCriteria += New Core.Dal.Expressions.IsNull("DeleteTime")
        ''searchCriteria += New Core.Dal.Expressions.Eq("Password", Core.Dal.Manager.Encrypt(password))
        result = Core.Bll.Entities(Of User).GetAll(session, searchCriteria)
        If result.Count = 0 Then
            Return Nothing
        End If
#If DEBUG Then
        If result.Count > 1 Then
            session.Rollback()
            session = Nothing
            Throw New Core.CriticalException("Pārāk daudz aktīvu lietotāju ar vienādiem Logon")
        End If
#End If
        Me.ConnectedTo = target
        If (Core.Dal.Manager.Decrypt(result(0).Password) = password) Then
            AuthenticatedUser = result(0)
            Return result
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Impersonētais lietotājs
    ''' </summary>
    ''' <value><seealso cref="User"/></value>
    Public Property ImpersonatedUser() As User
        Get
            Return _impersonatedUser
        End Get
        Set(ByVal value As User)
            If _authenticatedUser Is Nothing Then Return
            If Not (value Is Nothing) Then
                If Not value.Equals(_authenticatedUser) Then
                    Dim isOK As Boolean = False

                    If Not isOK Then Return
                End If
            End If
            If Not User.Equals(_impersonatedUser, value) Then
                If Not _impersonatedUser Is Nothing Then
                    Core.Logger.DB.LogImmediate(AuditMessage.LogonImpersonates, value)
                End If
                _impersonatedUser = value
                RefreshPermissions()
                Core.Bll.PermissionsChecker.Permissions = Permissions
            End If
        End Set
    End Property

    ''' <summary>
    ''' Permissions of ImpersonatedUser
    ''' </summary>
    ''' <value><seealso cref="IDictionary"/> of Permissions</value>
    Public ReadOnly Property Permissions() As IDictionary
        Get
            If _permissions Is Nothing Then _permissions = New Hashtable()
            Return _permissions
        End Get
    End Property

    Public Property Localization As Entities(Of Localization)
        Get
            Return _localization
        End Get
        Set(value As Entities(Of Localization))
            _localization = value
        End Set
    End Property
    ''' <summary>
    ''' Currently or previously connected server
    ''' </summary>
    ''' <value><seealso cref="Core.Dal.ConnectionTarget"/></value>
    Public Property ConnectedTo() As Core.Dal.ConnectionTarget
        Get
            If _connectedTo Is Nothing Then
                If Not Me.HasLocalServer Then
                    _connectedTo = Core.Dal.ConnectionTarget.Central
                Else
                    Dim rk As RegistryKey = Registry.CurrentUser.OpenSubKey(REGISTRY_SUBKEY)
                    If rk Is Nothing OrElse Not Me.HasLocalServer Then
                        _connectedTo = Core.Dal.ConnectionTarget.Central
                    Else
                        _connectedTo = New Core.Dal.ConnectionTarget()
                        _connectedTo.StringValue = CStr(rk.GetValue("ConnectedTo", "Central"))
                    End If
                End If
            End If
            Return _connectedTo
        End Get
        Private Set(ByVal value As Core.Dal.ConnectionTarget)
            _connectedTo = value
        End Set
    End Property

    ''' <summary>
    ''' Norāda, vai lietotājs ir veiksmīgi pieslēdzies sistēmai
    ''' </summary>
    ''' <value><c>True</c>, ja lietotājs ir pieslēdzies, <c>False</c>, ja nav</value>
    Public ReadOnly Property IsConnected() As Boolean
        Get
            Return Not _connectedTo Is Nothing
        End Get
    End Property

    Private _hasLocalServer As Nullable(Of Boolean)

    Public ReadOnly Property HasLocalServer() As Boolean
        Get
            If Not _hasLocalServer.HasValue Then
                Dim rk As RegistryKey = Registry.LocalMachine.OpenSubKey(REGISTRY_SUBKEY)
                If rk Is Nothing Then
                    _hasLocalServer = False
                Else
                    _hasLocalServer = (CInt(rk.GetValue("LocalServer", 0)) <> 0)
                End If
            End If
            Return _hasLocalServer.Value
        End Get
    End Property

    ''' <summary>
    ''' IP address of current computer
    ''' </summary>
    ''' <value>IP address as string</value>
    Public ReadOnly Property IPAddress() As String
        Get
            If String.IsNullOrEmpty(_iPAddress) Then
                Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())
                _iPAddress = CType(h.AddressList.GetValue(0), System.Net.IPAddress).ToString()
            End If
            Return _iPAddress
        End Get
    End Property


    Public Function GetAuthenticatedUser(ByVal session As Core.Dal.ISession) As User
        If Me.AuthenticatedUser Is Nothing Then
            Return Nothing
        Else
            Return session.Get(Of User)(Me.AuthenticatedUser.Id)
        End If
    End Function

    Public Function GetImpersonatedUser(ByVal session As Core.Dal.ISession) As User
        If Me.ImpersonatedUser Is Nothing Then
            Return Nothing
        Else
            Return session.Get(Of User)(Me.ImpersonatedUser.Id)
        End If
    End Function

    Private _synchronizationNeeded As Nullable(Of Boolean) = Nothing

    Public Property SynchronizationNeeded() As Boolean
        Get
            If Not _synchronizationNeeded.HasValue Then
                If Not Me.HasLocalServer Then
                    _synchronizationNeeded = False
                Else
                    Dim rk As RegistryKey = Registry.CurrentUser.OpenSubKey(REGISTRY_SUBKEY)
                    If rk Is Nothing Then
                        _synchronizationNeeded = True
                    Else
                        _synchronizationNeeded = (CInt(rk.GetValue("Synchronized", 0)) <> 1)
                    End If
                End If
            End If
            Return _synchronizationNeeded.Value
        End Get
        Set(ByVal value As Boolean)
            If Not _synchronizationNeeded.HasValue OrElse _synchronizationNeeded.Value <> value Then
                _synchronizationNeeded = value
            End If
        End Set
    End Property

    Protected Overrides Sub Finalize()
        If Me.HasLocalServer Then
            Dim rk As RegistryKey = Registry.CurrentUser.CreateSubKey(REGISTRY_SUBKEY)
            If Me.HasLocalServer AndAlso _synchronizationNeeded.HasValue Then
                rk.SetValue("Synchronized", IIf(_synchronizationNeeded.Value, 0, 1), RegistryValueKind.DWord)
            End If
            If Not Me.AuthenticatedUser Is Nothing Then
                rk.SetValue("ConnectedTo", Me.ConnectedTo.StringValue, RegistryValueKind.String)
            End If
        End If
        MyBase.Finalize()
    End Sub



End Class
