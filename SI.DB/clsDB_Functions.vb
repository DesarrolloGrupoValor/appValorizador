Imports System.Security.Cryptography
Imports System.IO

Public Class clsDB_Functions


    Private CadenaConexion As String

    'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")


    Private Sub prAccess()
        'CadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
        Dim oDB_Functions As New clsDB_Functions
        CadenaConexion = oDB_Functions.obtenerCadenaConexion("VA")
    End Sub

    Public Function AES_Encrypt(ByVal sCadena As String) As String

        Dim encrypted As String = ""
        Try

            Dim bytes() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes("ZeroCool")

            Dim cryptoProvider As New DESCryptoServiceProvider
            Dim memoryStream As New MemoryStream(Convert.FromBase64String(sCadena))
            Dim cryptoStream As New CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write)
            Dim writer As New StreamWriter(cryptoStream)
            'writer.Write(input)
            'writer.Flush()
            cryptoStream.FlushFinalBlock()
            'writer.Flush()
            encrypted = Convert.ToBase64String(memoryStream.GetBuffer(), 0, Convert.ToInt16(memoryStream.Length))


        Catch ex As Exception
            encrypted = ""
        End Try
        Return encrypted
    End Function

    Public Function AES_Decrypt(ByVal sCadena As String) As String

        Dim decrypted As String = ""
        Try

            Dim bytes() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes("ZeroCool")

            Dim cryptoProvider As New DESCryptoServiceProvider()
            Dim MemoryStream As New MemoryStream(Convert.FromBase64String(sCadena)) ' FromBase64String(input)

            Dim cryptoStream As New CryptoStream(MemoryStream, cryptoProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read)
            Dim reader As New StreamReader(cryptoStream)
            decrypted = reader.ReadToEnd()

        Catch ex As Exception

            decrypted = ""
        End Try

        Return decrypted
    End Function




    ''' <summary>
    ''' fn_encriptarConexion
    ''' Encripta o desEncripta una cadena, es utilizado para la conexion a la BD
    ''' </summary>
    ''' <param name="bEncriptar"></param>
    ''' <param name="sCadena"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fn_encriptar(ByVal bEncriptar As String, ByVal sCadena As String)
        Dim sEncriptado As String = ""

        For nContar = 0 To sCadena.Length - 1

            Select Case bEncriptar
                Case "E"
                    sEncriptado = sEncriptado + Chr(Asc(sCadena.Substring(nContar, 1)) + (nContar + 1) * 2)
                Case "D"
                    sEncriptado = sEncriptado + Chr(Asc(sCadena.Substring(nContar, 1)) - (nContar + 1) * 2)
                Case "N"
                    sEncriptado = sCadena
            End Select

            ''If bEncriptar Then
            ''    sEncriptado = sEncriptado + Chr(Asc(sCadena.Substring(nContar, 1)) + (nContar + 1) * 2)
            ''Else
            ''    sEncriptado = sEncriptado + Chr(Asc(sCadena.Substring(nContar, 1)) - (nContar + 1) * 2)
            ''End If

        Next

        Return sEncriptado

    End Function

    Public Function obtenerCadenaConexion(ByVal sBaseDatos As String)
        Dim sCadenaConexion As String = ""
        Select Case sBaseDatos
            Case "VA"
                sCadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexion")
            Case "EN"
                sCadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionEN")
            Case "IN"
                sCadenaConexion = System.Configuration.ConfigurationManager.AppSettings("SQLConexionIN")
        End Select

        'Dim lsUsuario(), lsContraseña() As String
        Dim sServidor, sBD, sUsuario, sContraseña, sTimeout As String
        Dim nServidor, nBD, nUsuario, nContraseña, nLongitud, nTimeout As Integer


        nServidor = InStr(sCadenaConexion, "Data Source=")
        nBD = InStr(sCadenaConexion, "Initial Catalog=")
        nUsuario = InStr(sCadenaConexion, "User Id=")
        nContraseña = InStr(sCadenaConexion, "Password=")
        nTimeout = InStr(sCadenaConexion, "Connect Timeout=")
        nLongitud = Len(sCadenaConexion)

        sServidor = sCadenaConexion.Substring(nServidor - 1, nBD - 1)
        sBD = sCadenaConexion.Substring(nBD - 1, nUsuario - nBD)
        sUsuario = sCadenaConexion.Substring(nUsuario - 1, nContraseña - nUsuario)
        sContraseña = sCadenaConexion.Substring(nContraseña - 1, nTimeout - nContraseña)

        sTimeout = sCadenaConexion.Substring(nTimeout - 1, nLongitud - nTimeout + 1)

        nUsuario = InStr(sUsuario, "=")
        nLongitud = Len(sUsuario)
        sUsuario = "User Id=" + fn_encriptar("D", sUsuario.Substring(nUsuario, nLongitud - nUsuario - 1)) + ";"

        nContraseña = InStr(sContraseña, "=")
        nLongitud = Len(sContraseña)
        sContraseña = "Password=" + fn_encriptar("D", sContraseña.Substring(nContraseña, nLongitud - nContraseña - 1)) + ";"

        ''lsUsuario = sCadenaConexion.Split(";")(2).Split("=")
        ''lsContraseña = sCadenaConexion.Split(";")(3).Split("=")

        ''sUsuario = lsUsuario(0) + "=" + fn_encriptar(False, lsUsuario(1))
        ''sContraseña = lsContraseña(0) + "=" + fn_encriptar(False, IIf(lsContraseña.Length = 3, lsContraseña(1) + "=" + lsContraseña(2), lsContraseña(1)))

        sCadenaConexion = sServidor + sBD + sUsuario + sContraseña + sTimeout

        Return sCadenaConexion
    End Function

End Class
