Imports System.Data.SqlClient
Imports HerbalDaunSendok

Public Class penyakit
    Private Property _idPenyakit As Integer
    Private Property _idPasien As Integer
    Private Property _tgl As String
    Private Property _sys As String
    Private Property _dia As String
    Private Property _pul As String
    Private Property _gd As String
    Private Property _labDarah As String
    Private Property _diagnosa As String
    Private Property _terapisHerbal As String

    Public Property idPenyakit() As Integer
        Set(value As Integer)
            _idPenyakit = value
        End Set
        Get
            Return _idPenyakit
        End Get
    End Property
    Public Property idPasien() As Integer
        Set(value As Integer)
            _idPasien = value
        End Set
        Get
            Return _idPasien
        End Get
    End Property
    Public Property tgl() As String
        Set(value As String)
            _tgl = value
        End Set
        Get
            Return _tgl
        End Get
    End Property

    Public Property sys() As String
        Set(value As String)
            _sys = value
        End Set
        Get
            Return _sys
        End Get
    End Property

    Public Property dia() As String
        Set(value As String)
            _dia = value
        End Set
        Get
            Return _dia
        End Get
    End Property
    Public Property pul() As String
        Set(value As String)
            _pul = value
        End Set
        Get
            Return _pul
        End Get
    End Property
    Public Property gd() As String
        Set(value As String)
            _gd = value
        End Set
        Get
            Return _gd
        End Get
    End Property

    Public Property labDarah() As String
        Set(value As String)
            _labDarah = value
        End Set
        Get
            Return _labDarah
        End Get
    End Property
    Public Property diagnosa() As String
        Set(value As String)
            _diagnosa = value
        End Set
        Get
            Return _diagnosa
        End Get
    End Property
    Public Property terapisHerbal() As String
        Set(value As String)
            _terapisHerbal = value
        End Set
        Get
            Return _terapisHerbal
        End Get
    End Property
    Public Function insert() As Boolean
        Try
            If idPasien = 0 Then
                sql = "INSERT INTO Penyakit VALUES (null,(SELECT max(idPasien)as idPasien FROM pasien),'" + tgl.ToString + "','" + sys.ToString + "', '" + dia.ToString + "', '" + pul.ToString + "', '" + gd.ToString + "', '" + labDarah.ToString + "', '" + diagnosa.ToString + "', '" + terapisHerbal.ToString + "')"
            Else
                sql = "INSERT INTO Penyakit VALUES (null," & idPasien & ",curdate(),'" + sys.ToString + "', '" + dia.ToString + "', '" + pul.ToString + "', '" + gd.ToString + "', '" + labDarah.ToString + "', '" + diagnosa.ToString + "', '" + terapisHerbal.ToString + "')"
            End If
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Public Function selectByNama(id As String) As List(Of penyakit)
        Dim listTerapi As New List(Of penyakit)
        sql = "SELECT * FROM Penyakit WHERE idPasien =4"
        dtTable = get_dttable(sql)
        listTerapi = (From row As DataRow In dtTable.Rows
                    Select New penyakit() With
                           {.idPenyakit = row("idPenyakit"),
                            .tgl = row("tgl"),
                            .sys = row("sys"),
                            .dia = row("dia"),
                            .pul = row("pul"),
                            .gd = row("gd"),
                            .labDarah = row("labdarah"),
                            .diagnosa = row("diagnosa"),
        .terapisHerbal = row("terapisherbal")
                            }).ToList
        Return listTerapi

    End Function


    Public Function delete() As Boolean
        Try
            sql = "DELETE FROM Penyakit WHERE idPenyakit = " & idPenyakit & ""
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    Public Function update() As Boolean
        Try
            sql = "UPDATE penyakit SET sys = '" + sys.ToString + "', dia = '" + dia.ToString + "', pul= '" + pul.ToString + "', gd= '" + gd.ToString + "', labdarah = '" + labDarah.ToString + "',diagnosa = '" + diagnosa.ToString + "', terapisherbal = '" + terapisHerbal.ToString + "'WHERE idpenyakit= " & idPenyakit.ToString & ""
            CRUD_data(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

End Class
