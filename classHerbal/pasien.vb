'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports HerbalDaunSendok

Public Class pasien
    Private Property _idPasien As Integer
    Private Property _nama As String
    Private Property _umur As String
    Private Property _alamat As String
    Private Property _jk As String
    Private Property _phone As String

    Public Property idPasien() As String
        Set(value As String)
            _idPasien = value
        End Set
        Get
            Return _idPasien
        End Get
    End Property
    Public Property nama() As String
        Set(value As String)
            _nama = value
        End Set
        Get
            Return _nama
        End Get
    End Property

    Public Property umur() As String
        Set(value As String)
            _umur = value
        End Set
        Get
            Return _umur
        End Get
    End Property
    Public Property alamat() As String
        Set(value As String)
            _alamat = value
        End Set
        Get
            Return _alamat
        End Get
    End Property
    Public Property jk() As String
        Set(value As String)
            _jk = value
        End Set
        Get
            Return _jk
        End Get
    End Property

    Public Property phone() As String
        Set(value As String)
            _phone = value
        End Set
        Get
            Return _phone
        End Get
    End Property

    Public Function insert() As Boolean
        Try
            sql = "INSERT INTO Pasien VALUES (null,'" + nama.ToString + "', '" + umur.ToString + "', '" + alamat.ToString + "', '" + jk.ToString + "', '" + phone.ToString + "')"
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    
    Public Function update() As Boolean
        Try
            sql = "UPDATE Pasien SET nama = '" + nama.ToString + "', umur = '" + umur.ToString + "', alamat = '" + alamat.ToString + "', jk = '" + jk.ToString + "', phone = '" + phone.ToString + "' WHERE idPasien= " & idPasien.ToString & ""
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Public Function delete() As Boolean
        Try
            sql = "DELETE FROM Pasien WHERE idPasien = " & idPasien & ""
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Public Function selectAll() As List(Of pasien)
        Dim listPasien As New List(Of pasien)
        sql = "SELECT * FROM Pasien "
        dtTable = get_dttable(sql)
        listPasien = (From row As DataRow In dtTable.Rows
                    Select New pasien() With
                           {.idPasien = row("idPasien"),
                            .nama = row("nama"),
                            .umur = row("umur"),
                            .alamat = row("alamat"),
                            .jk = row("jk"),
                            .phone = row("phone")
                            }).ToList
        Return listPasien

    End Function
    Public Function selectByNama(nama As String) As List(Of pasien)
        Dim listPasien As New List(Of pasien)
        sql = "SELECT * FROM Pasien WHERE nama like '%" + nama.ToString + "%'"
        dtTable = get_dttable(sql)
        listPasien = (From row As DataRow In dtTable.Rows
                    Select New pasien() With
                           {.idPasien = row("idPasien"),
                            .nama = row("nama"),
                            .umur = row("umur"),
                            .alamat = row("alamat"),
                            .jk = row("jk"),
        .phone = row("phone")
                            }).ToList
        Return listPasien

    End Function
    Public Function getIdPasien()
        konkeksiDB()
        conn.Open()
        Dim id As Integer
        Try
            sql = "SELECT MAX(idPasien) AS id FROM pasien"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            Dim sqlReader As MySqlDataReader = cmd.ExecuteReader()
            While sqlReader.Read()
                id = Val(sqlReader("id"))
            End While
            Return id
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
        conn.Close()
    End Function
End Class
