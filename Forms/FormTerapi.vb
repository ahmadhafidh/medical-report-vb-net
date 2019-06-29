Imports System.Data.SqlClient

Public Class FormTerapi
    Private countAwal As Integer
    Private countAkhir As Integer
    Public idPasen As Integer
    Private penyakit As New penyakit
    Private tambah As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormCariPasien.Show()
    End Sub

    Private Sub FormTerapi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTgl.Text = DateTime.Now.ToString("yyyy-MM-dd")
        tabelPasien.ColumnCount = 10
        tabelPasien.Columns(0).Name = "NO"
        tabelPasien.Columns(1).Name = "ID TERAPI"
        tabelPasien.Columns(2).Name = "TGL"
        tabelPasien.Columns(3).Name = "SYS"
        tabelPasien.Columns(4).Name = "DIA"
        tabelPasien.Columns(5).Name = "PUL"
        tabelPasien.Columns(6).Name = "GD"
        tabelPasien.Columns(7).Name = "LAB DARAH"
        tabelPasien.Columns(8).Name = "DIAGNOSA"
        tabelPasien.Columns(9).Name = "TERAPIS HERBAL"
        'getTerapiByName("4")
    End Sub
    Private Sub addTerapi()
        Dim n As Integer = tabelPasien.Rows.Add()
        tabelPasien.Rows.Item(n).Cells(0).Value = (n + 1)
        tabelPasien.Rows.Item(n).Cells(1).Value = getPrimaryKey.ToString()
        tabelPasien.Rows.Item(n).Cells(2).Value = txtTgl.Text
        tabelPasien.Rows.Item(n).Cells(3).Value = txtSys.Text
        tabelPasien.Rows.Item(n).Cells(4).Value = txtDia.Text
        tabelPasien.Rows.Item(n).Cells(5).Value = txtPul.Text
        tabelPasien.Rows.Item(n).Cells(6).Value = txtGd.Text
        tabelPasien.Rows.Item(n).Cells(7).Value = txtLab.Text
        tabelPasien.Rows.Item(n).Cells(8).Value = txtDiagnosa.Text
        tabelPasien.Rows.Item(n).Cells(9).Value = txtTerapi.Text
        n += 1

    End Sub
    Public Sub getTerapiByName(idPasien As Integer)
        tabelPasien.Rows.Clear()
        Dim sql As String = "SELECT * FROM Penyakit WHERE idPasien =" & idPasien & ""
        Dim n As Integer = tabelPasien.Rows.Count - 1

        Try
            konkeksiDB()
            conn.Open()
            'cmd = New SqlCommand(sql, conn)
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            dtReader = cmd.ExecuteReader
            While dtReader.Read()
                tabelPasien.Rows.Add()
                tabelPasien.Rows.Item(n).Cells(0).Value = (n + 1)
                tabelPasien.Rows.Item(n).Cells(1).Value = dtReader("idPenyakit")
                'tabelPasien.Rows.Item(n).Cells(2).Value = DateTime.ParseExact(dtReader("tgl"), "ddd mm yy",
                tabelPasien.Rows.Item(n).Cells(2).Value = "1995-02-03"
                tabelPasien.Rows.Item(n).Cells(3).Value = dtReader("sys")
                tabelPasien.Rows.Item(n).Cells(4).Value = dtReader("dia")
                tabelPasien.Rows.Item(n).Cells(5).Value = dtReader("pul")
                tabelPasien.Rows.Item(n).Cells(6).Value = dtReader("gd")
                tabelPasien.Rows.Item(n).Cells(7).Value = dtReader("labdarah")
                tabelPasien.Rows.Item(n).Cells(8).Value = dtReader("diagnosa")
                tabelPasien.Rows.Item(n).Cells(9).Value = dtReader("terapisherbal")
                n += 1
            End While
            countAwal = n
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try

    End Sub
    Function getPrimaryKey() As Integer
        Dim id As Integer
        Dim sql As String = "SELECT MAX(idPenyakit)+1 AS id FROM penyakit"
        Try
            konkeksiDB()
            conn.Open()
            'cmd = New SqlCommand(sql, conn)
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            dtReader = cmd.ExecuteReader
            While dtReader.Read()
                id = dtReader("id")
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try
        Return id
    End Function
    Private Function cekEmpty() As Boolean
        If txtSys.Text = "" Or txtDia.Text = "" Or txtGd.Text = "" Or txtLab.Text = "" Or txtDiagnosa.Text = "" Then
            Return True
        Else
            Return False
        End If

    End Function
    Private Sub btnCariPasien_Click(sender As Object, e As EventArgs) Handles btnCariPasien.Click
        If txtAlamat.Text = "-" Then
            MsgBox("Harap Pilih Pasien Terlebih Dahulu")
        Else
            If cekEmpty() = True Then
                MsgBox("Harap Masukan Data Terapi")
            Else
                tambah = True
                addTerapi()
                reset()
            End If
            End If


    End Sub

    Private Sub txtSys_Leave(sender As Object, e As EventArgs) Handles txtSys.Leave
        'txtDia.Focus()
    End Sub

    Private Sub txtDia_Leave(sender As Object, e As EventArgs) Handles txtDia.Leave
        txtPul.Focus()
    End Sub

    Private Sub txtPul_Leave(sender As Object, e As EventArgs) Handles txtPul.Leave
        txtGd.Focus()
    End Sub

    Private Sub txtGd_Leave(sender As Object, e As EventArgs) Handles txtGd.Leave
        txtLab.Focus()
    End Sub

    Private Sub txtLab_Leave(sender As Object, e As EventArgs) Handles txtLab.Leave
        txtDiagnosa.Focus()
    End Sub

    Private Sub txtDiagnosa_Leave(sender As Object, e As EventArgs) Handles txtDiagnosa.Leave
        txtTerapi.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If tambah = True Then

            Dim countAkhir = (tabelPasien.RowCount.ToString - 2)
            Dim a As Integer

            For a = countAwal To countAkhir
                penyakit.idPasien = idPasen
                penyakit.sys = tabelPasien.Item(3, a).Value.ToString

                penyakit.dia = tabelPasien.Item(4, a).Value.ToString
                penyakit.pul = tabelPasien.Item(5, a).Value.ToString
                penyakit.gd = tabelPasien.Item(6, a).Value.ToString
                penyakit.labDarah = tabelPasien.Item(7, a).Value.ToString
                penyakit.diagnosa = tabelPasien.Item(8, a).Value.ToString
                penyakit.terapisHerbal = tabelPasien.Item(9, a).Value.ToString
                penyakit.insert()
            Next
            MsgBox("Data Berhasil Di Simpan")
            reset()
            txtNama.Text = "-"
            txtUmur.Text = "-"
            txtAlamat.Text = "-"
            rbtnL.Checked = False
            rbtnL.Checked = False
            txtTelp.Text = "-"
            tabelPasien.Rows.Clear()
        Else
            MsgBox("Data Belum DI Masukkan")
        End If
    End Sub
    Sub reset()
        txtSys.Text = ""
        txtDia.Text = ""
        txtPul.Text = ""
        txtGd.Text = ""
        txtLab.Text = ""
        txtDiagnosa.Text = ""
        txtTerapi.Text = ""
    End Sub


    Private Sub tabelPasien_DoubleClick(sender As Object, e As EventArgs) Handles tabelPasien.DoubleClick
        penyakit.idPenyakit = Val(tabelPasien.CurrentRow.Cells(1).Value)
        idPenyakit.Text = tabelPasien.CurrentRow.Cells(1).Value
        txtSys.Text = tabelPasien.CurrentRow.Cells(3).Value
        txtDia.Text = tabelPasien.CurrentRow.Cells(4).Value
        txtPul.Text = tabelPasien.CurrentRow.Cells(5).Value
        txtGd.Text = tabelPasien.CurrentRow.Cells(6).Value
        txtLab.Text = tabelPasien.CurrentRow.Cells(7).Value
        txtDiagnosa.Text = tabelPasien.CurrentRow.Cells(8).Value
        txtTerapi.Text = tabelPasien.CurrentRow.Cells(9).Value

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If cekEmpty() = True Then
            MsgBox("Harap Pilih Terapi Terlebih Dahulu")
        Else
            If MsgBox("Anda Yakin Ingin ingin menghapus data ?", MsgBoxStyle.OkCancel, "Delete Data") = MsgBoxResult.Ok Then
                penyakit.delete()
                getTerapiByName(idPasen)
                tabelPasien.Refresh()
                reset()
            End If
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cekEmpty() = True Then
            MsgBox("Data Tidak Boleh Kosong")
        Else
            penyakit.idPenyakit = idPenyakit.Text
            penyakit.sys = txtSys.Text
            penyakit.dia = txtDia.Text
            penyakit.pul = txtPul.Text
            penyakit.gd = txtGd.Text
            penyakit.labDarah = txtLab.Text
            penyakit.diagnosa = txtDiagnosa.Text
            penyakit.terapisHerbal = txtTerapi.Text
            penyakit.update()
            getTerapiByName(idPasen)
            tabelPasien.Refresh()
            MsgBox("Data Berhasi di Update")
            reset()
        End If
    End Sub

    Private Sub tabelPasien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelPasien.CellContentClick

    End Sub
End Class