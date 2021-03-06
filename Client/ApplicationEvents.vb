Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Globalization
Imports System.Threading
Imports Core.UI
Imports System.Windows.Forms


Namespace My

    Class MyApplication

        Private Sub SetFormats()
            Dim cultureInfo As CultureInfo = CType(Thread.CurrentThread.CurrentCulture.Clone(), CultureInfo)

            Dim dtfi As DateTimeFormatInfo = cultureInfo.DateTimeFormat
            dtfi.SetAllDateTimePatterns(New String() {"dd.MM.yyyy"}, "d"c)
            dtfi.SetAllDateTimePatterns(New String() {"yyyy'.gada 'd.MMMM"}, "D"c)
            dtfi.DateSeparator = "."
            dtfi.SetAllDateTimePatterns(New String() {"HH:mm"}, "T"c)

            Dim nfi As NumberFormatInfo = cultureInfo.NumberFormat
            nfi.NumberDecimalSeparator = ","
            nfi.NumberGroupSeparator = " "
            nfi.NumberGroupSizes = New Integer() {3}
            nfi.NumberDecimalDigits = 2

            Thread.CurrentThread.CurrentCulture = cultureInfo
        End Sub

        Private Sub SetImplementors()
            Core.Logger.SetDatabaseAppender(New Entities.DatabaseAppender())
        End Sub

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            SetFormats()
            SetImplementors()
        End Sub

        Private Sub OnThreadException(ByVal sender As Object, ByVal e As ThreadExceptionEventArgs) Handles Me.UnhandledException
            MessageBox.Show(e.Exception.ToString())
        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            If TypeOf e.Exception Is Core.CriticalException Then
                MsgBox.Show(CType(e.Exception, Core.CriticalException).Message)
                e.ExitApplication = False
            ElseIf TypeOf e.Exception Is Core.TpaisException Then
                MsgBox.Show(CType(e.Exception, Core.TpaisException).Message)
                e.ExitApplication = False
            Else
                MsgBox.Show(Core.ErrMsg.GetText(Core.Err.UnhandledException) + ": " + e.Exception.ToString())
                e.ExitApplication = False
            End If
        End Sub
    End Class

End Namespace
' Lūdzu, Юникод

