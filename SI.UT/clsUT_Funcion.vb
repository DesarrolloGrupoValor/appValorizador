Imports System.Collections.Generic
Imports SI.UT
Imports System.Configuration

Namespace SI.UT
    Public Class clsUT_Funcion
        Public Shared Function DbValueToNullable(Of T As Structure)(ByVal dbValue As Object) As Nullable(Of T)

            Dim returnValue As Nullable(Of T) = Nothing

            If (Not (dbValue Is Nothing)) AndAlso (Not (dbValue Is DBNull.Value)) Then
                returnValue = CType(dbValue, T)
            End If

            Return returnValue
        End Function

        Public Shared Function FechaNull(ByVal dFecha As Object) As DateTime
            If IsDBNull(dFecha) OrElse (dFecha = "#12:00:00 AM#") OrElse Not IsDate(dFecha) OrElse IsNothing(dFecha) Then
                Return "#1/1/1900#"
            Else
                Return dFecha
            End If
        End Function

        Public Shared Function FechaNullVista(ByVal dFecha As Object) As String
            If dFecha = "#1/1/1900#" OrElse IsDBNull(dFecha) OrElse (dFecha = "#12:00:00 AM#") OrElse Not IsDate(dFecha) OrElse IsNothing(dFecha) Then
                Return ""
            Else
                Return dFecha
            End If
        End Function
        Public Shared Function getConfig(ByVal key As String)
            Dim strValue As String = ""
            strValue = ConfigurationManager.AppSettings.Get(key)
            Return strValue
        End Function
        Public Shared Sub setConfig(ByVal key As String, ByVal value As String)
            ' ConfigurationManager.AppSettings.Remove(key)
            ' ConfigurationManager.AppSettings.Add(key, value)
            Dim cnf As System.Configuration.Configuration

            cnf = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim configSettings As KeyValueConfigurationCollection = cnf.AppSettings.Settings()
            Dim keyValueElement As KeyValueConfigurationElement
            For Each keyValueElement In configSettings
                If keyValueElement.Key = key Then
                    keyValueElement.Value = value
                End If

            Next
            cnf.Save()
          

        End Sub
    End Class
End Namespace

