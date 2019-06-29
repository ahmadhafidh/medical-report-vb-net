Imports HerbalDaunSendok
Public Class FormCariPasien
    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormCariPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Private Sub loadData()
        tabelPasien.DataSource = New pasien().selectAll
        tabelPasien.Refresh()
    End Sub

    Private Sub btnCariPasien_Click(sender As Object, e As EventArgs) Handles btnCariPasien.Click
        Dim pasien As New pasien
        tabelPasien.DataSource = pasien.selectByNama(txtCariPasien.Text)
        tabelPasien.Refresh()

    End Sub

    Private Sub tabelPasien_DoubleClick(sender As Object, e As EventArgs) Handles tabelPasien.DoubleClick

        FormTerapi.getTerapiByName(tabelPasien.CurrentRow.Cells(0).Value)
        FormTerapi.idPasen = tabelPasien.CurrentRow.Cells(0).Value
        FormTerapi.txtNama.Text = tabelPasien.CurrentRow.Cells(1).Value
        FormTerapi.txtUmur.Text = tabelPasien.CurrentRow.Cells(2).Value
        FormTerapi.txtAlamat.Text = tabelPasien.CurrentRow.Cells(3).Value
        If tabelPasien.CurrentRow.Cells(4).Value = "laki-laki" Then
            FormTerapi.rbtnL.Checked = True
        Else
            FormTerapi.rbtnP.Checked = True
        End If
        FormTerapi.txtTelp.Text = tabelPasien.CurrentRow.Cells(4).Value

        Me.Close()
    End Sub

    
   
End Class