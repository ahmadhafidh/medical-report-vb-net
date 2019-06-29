Imports HerbalDaunSendok.Load
Public Class FormLogin
    Dim l As New Load


    Private Sub btnCariPasien_Click(sender As Object, e As EventArgs) Handles btnCariPasien.Click
        Dim login As New login
        login.userName = txtUsername.Text
        login.password = txtPassword.Text
        txtUsername.Focus()
        If login.userName = "" Or login.password = "" Then
            MsgBox("Username dan Password Harap di isi ")
        Else
            l.Show()
            If login.cekLogin() = True Then
                l.Hide()
                MsgBox("login Berhasil")
                Me.Hide()
                FormMaster.Show()
                l.Hide()

            Else
                l.Hide()
                MsgBox("login Gagal")
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Focus()

            End If
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cekLogin() = False Then
            Me.Close()
        End If

    End Sub
    Function cekLogin() As Boolean
        Try
            konkeksiDB()
            conn.Open()
            Return True
        Catch ex As Exception
            MsgBox("Koneksi Gagal" + ex.ToString)
            Return False
        End Try
    End Function
End Class