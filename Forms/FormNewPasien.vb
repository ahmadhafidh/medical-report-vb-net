Imports HerbalDaunSendok.pasien
Public Class FormNewPasien

    Dim pasien As New pasien
    Public idPasien As Integer
    Dim formaster As FormMaster


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim penyakit As New penyakit
        Dim jk As String
        If cekEmpty() = True Or txtTerapi.Text = "" Then
            MsgBox("Semua Data Harus di isi")
        Else


            If rbtnL.Checked = True Then
                jk = "laki-laki"
            Else
                jk = "perempuan"
            End If

            pasien.nama = txtNama.Text
            pasien.umur = txtUmur.Text
            pasien.alamat = txtAlamat.Text
            pasien.jk = jk
            pasien.phone = txtTelp.Text
            pasien.insert()


            penyakit.sys = txtSys.Text
            penyakit.dia = txtDia.Text
            penyakit.pul = txtPul.Text
            penyakit.gd = txtGd.Text
            penyakit.labDarah = txtLab.Text
            penyakit.diagnosa = txtDiagnosa.Text
            penyakit.terapisHerbal = txtTerapi.Text
            penyakit.tgl = txtTgl.Text
            penyakit.insert()
            MsgBox("Data Berhasil Tersimpan")
            reset()

            'loadData()

        End If
    End Sub
    Sub reset()
        txtNama.Text = ""
        txtUmur.Text = ""
        txtAlamat.Text = ""
        rbtnL.Checked = False
        rbtnP.Checked = False
        txtTelp.Text = ""
        txtTgl.Text = DateTime.Now.ToString("yyyy-MM-dd")

        txtSys.Text = ""
        txtDia.Text = ""
        txtPul.Text = ""
        txtGd.Text = ""
        txtLab.Text = ""
        txtDiagnosa.Text = ""
        txtTerapi.Text = ""
    End Sub

    Private Sub FormNewPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loadData()
        txtTgl.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub
  
    
    Private Function cekEmpty() As Boolean
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtAlamat.Text = "" Or txtTelp.Text = "" Then
            'Or txtSys.Text = "" Or txtDia.Text = "" Or txtGd.Text = "" Or txtLab.Text = "" Or txtDiagnosa.Text = "" 
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cekEmpty() = True Then
            MsgBox("Pilih Pasien Terlebih Dahulu")
        Else
            Dim jk As String
            If rbtnL.Checked = True Then
                jk = "laki-laki"
            Else
                jk = "perempuan"
            End If
            pasien.idPasien = Val(idPasien.ToString)
            pasien.nama = txtNama.Text
            pasien.umur = txtUmur.Text
            pasien.alamat = txtAlamat.Text
            pasien.jk = jk
            pasien.phone = txtTelp.Text
            pasien.update()
            MsgBox("Data Berhasi di Update")
            reset()
            'formaster.loadPasen()
        End If
    End Sub

    Private Sub btnCariPasien_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If cekEmpty() = True Then
            MsgBox("Pilih Pasien Terlebih Dahulu")
        Else
            If MsgBox("Anda Yakin Ingin ingin menghapus data ?", MsgBoxStyle.OkCancel, "Delete Data") = MsgBoxResult.Ok Then
                pasien.idPasien = idPasien
                pasien.delete()
                MsgBox("Data Berhasil Di Delete")
                reset()
                'formaster.loadPasen()
                'loadData()
            End If
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Private Sub txtUmur_MouseLeave(sender As Object, e As EventArgs) Handles txtUmur.MouseLeave
        Try
            IsNumeric(txtUmur.Text)
        Catch ex As Exception
            MsgBox("Harus Angka")
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormCariPasienN.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DatePicker1.ValueChanged

        txtTgl.Text = DatePicker1.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtTgl.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub
End Class
