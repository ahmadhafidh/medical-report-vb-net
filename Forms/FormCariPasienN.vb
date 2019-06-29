Public Class FormCariPasienN
    Dim pasien As New pasien

    Private Sub FormCariPasienN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Private Sub loadData()
        tabelPasien.DataSource = pasien.selectAll()
        tabelPasien.Refresh()
    End Sub

    Private Sub btnCariPasien_Click(sender As Object, e As EventArgs) Handles btnCariPasien.Click
        tabelPasien.DataSource = pasien.selectByNama(txtCariPasien.Text)
        tabelPasien.Refresh()
    End Sub

    Private Sub tabelPasien_DoubleClick(sender As Object, e As EventArgs) Handles tabelPasien.DoubleClick
        FormNewPasien.idPasien = tabelPasien.CurrentRow.Cells(0).Value
        FormNewPasien.txtNama.Text = tabelPasien.CurrentRow.Cells(1).Value
        FormNewPasien.txtUmur.Text = tabelPasien.CurrentRow.Cells(2).Value
        FormNewPasien.txtAlamat.Text = tabelPasien.CurrentRow.Cells(3).Value
        If tabelPasien.CurrentRow.Cells(4).Value = "laki-laki" Then
            FormNewPasien.rbtnL.Checked = True
        Else
            FormNewPasien.rbtnP.Checked = True
        End If
        FormNewPasien.txtTelp.Text = tabelPasien.CurrentRow.Cells(5).Value
        Me.Close()
    End Sub

    
End Class