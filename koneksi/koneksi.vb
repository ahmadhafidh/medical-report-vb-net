Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Configuration

Imports System.Data

Module koneksi
    Dim computername As String = System.Windows.Forms.SystemInformation.ComputerName
    'Public conn As SqlConnection
    Public dtAdapter As MySqlDataAdapter = Nothing
    Public dtReader As MySqlDataReader = Nothing
    Public dtRow As DataRow = Nothing
    Public dtSet As DataSet = Nothing
    Public dtTable As DataTable = Nothing
    Public cmd As MySqlCommand = Nothing
    Public sql As String = Nothing
    Public posisi As Integer
    Public conn As MySqlConnection
    'Dim strcon As String = "Data Source=SONYVAIO;Initial Catalog=TerapiHerbal;User ID=sa;Password=admin123;Pooling=False"
    'Dim strcon As String = "data source=" + computername + ";initial catalog=TerapiHerbal;integrated security=true"
    'piye gawene Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
    'Dim strcon As String = Server=SONYVAIO;Database=TerapiHerbal;Trusted_Connection=True;

    Dim strcon As String = ConfigurationManager.ConnectionStrings("myConnection").ToString

    Public Sub konkeksiDB()
        conn = New MySqlConnection
        conn.ConnectionString = strcon
        Try
            'conn = New SqlConnection(strcon)
            conn.Open()
            conn.Close()
        Catch ex As Exception
            conn.Close()
            'MsgBox("gagal" + ex.ToString)
        End Try
    End Sub
End Module
