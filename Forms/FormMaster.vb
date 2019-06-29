Imports HerbalDaunSendok.Load

Public Class FormMaster
    Dim l As New Load
    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        l.Show()
        FormNewPasien.Show()
        l.Hide()
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        l.Show()
        FormTerapi.Show()
        l.Hide()

    End Sub

    Private Sub Panel14_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel14.MouseClick
        MsgBox("Maaf fitur Laporan dalam proses maintance")

        'l.Show()
        'Laporan.Show()
        l.Hide()
    End Sub

    Private Sub FormMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pasien As New pasien
        Dim jumlah As Integer = pasien.selectAll().Count
        txtJumPasien.Text = jumlah
    End Sub
    

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub
End Class