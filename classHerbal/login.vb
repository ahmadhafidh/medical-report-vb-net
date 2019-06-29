Public Class login
    Private Property _idAdmin As Integer
    Private Property _userName As String
    Private Property _password As String

    Public Property idAdmin() As Integer
        Set(value As Integer)
            _idAdmin = value
        End Set
        Get
            Return _idAdmin
        End Get
    End Property
    Public Property userName() As String
        Set(value As String)
            _userName = value
        End Set
        Get
            Return _userName
        End Get
    End Property
    Public Property password() As String
        Set(value As String)
            _password = value
        End Set
        Get
            Return _password
        End Get
    End Property
    Public Function cekLogin() As Boolean


        Try
            sql = "select * from Login where username='" + userName.ToString + "' and password='" + password.ToString + "'"
            konkeksiDB()
            conn.Open()

            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            dtReader = cmd.ExecuteReader

            While dtReader.Read()
                idAdmin = Integer.Parse(dtReader("idAdmin"))
                userName = dtReader("username").ToString
                password = dtReader("password").ToString
            End While

            If idAdmin > 0 Then
                Return True
            Else
                Return False
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function
End Class
