Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Laporan

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        


    End Sub

    Private Sub reportViewver_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCariPasien_Click(sender As Object, e As EventArgs) Handles btnCariPasien.Click
        If cmbTgl.SelectedIndex = -1 Then
            MsgBox("Pilih Bulan Dahulu")
        Else
            Dim report As New rptLaporan

            'Dim user As String = "root"
            'Dim pass As String = ""
            'report.SetDatabaseLogon(user, pass)
            'report.SetParameterValue("@tgl", "9")

            'report.AddressOf()
            'report.SetParameterValue("tgl1", cmbTgl.SelectedItem)
            reportViewver.ReportSource = report
            reportViewver.Refresh()
        End If
    End Sub
End Class