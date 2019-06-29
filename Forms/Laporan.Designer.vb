<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCariPasien = New System.Windows.Forms.Button()
        Me.cmbTgl = New System.Windows.Forms.ComboBox()
        Me.txtUserLogin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.reportViewver = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CachedrptLaporan1 = New HerbalDaunSendok.CachedrptLaporan()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 57)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(-4, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(748, 10)
        Me.Panel3.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnCariPasien)
        Me.Panel4.Controls.Add(Me.cmbTgl)
        Me.Panel4.Controls.Add(Me.txtUserLogin)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(-4, 9)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(748, 45)
        Me.Panel4.TabIndex = 10
        '
        'btnCariPasien
        '
        Me.btnCariPasien.BackColor = System.Drawing.Color.White
        Me.btnCariPasien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCariPasien.FlatAppearance.BorderSize = 0
        Me.btnCariPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariPasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariPasien.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCariPasien.Location = New System.Drawing.Point(671, 7)
        Me.btnCariPasien.Name = "btnCariPasien"
        Me.btnCariPasien.Size = New System.Drawing.Size(63, 28)
        Me.btnCariPasien.TabIndex = 28
        Me.btnCariPasien.Text = "SUBMIT"
        Me.btnCariPasien.UseVisualStyleBackColor = False
        '
        'cmbTgl
        '
        Me.cmbTgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTgl.FormattingEnabled = True
        Me.cmbTgl.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cmbTgl.Location = New System.Drawing.Point(536, 7)
        Me.cmbTgl.Name = "cmbTgl"
        Me.cmbTgl.Size = New System.Drawing.Size(121, 28)
        Me.cmbTgl.TabIndex = 1
        Me.cmbTgl.Text = "Pilih Bulan"
        '
        'txtUserLogin
        '
        Me.txtUserLogin.AutoSize = True
        Me.txtUserLogin.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserLogin.Location = New System.Drawing.Point(1363, 23)
        Me.txtUserLogin.Name = "txtUserLogin"
        Me.txtUserLogin.Size = New System.Drawing.Size(61, 23)
        Me.txtUserLogin.TabIndex = 1
        Me.txtUserLogin.Text = "LOGIN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LAPORAN TERAPI"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.reportViewver)
        Me.Panel1.Location = New System.Drawing.Point(2, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(741, 681)
        Me.Panel1.TabIndex = 0
        '
        'reportViewver
        '
        Me.reportViewver.ActiveViewIndex = -1
        Me.reportViewver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportViewver.Cursor = System.Windows.Forms.Cursors.Default
        Me.reportViewver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportViewver.Location = New System.Drawing.Point(0, 0)
        Me.reportViewver.Name = "reportViewver"
        Me.reportViewver.ReuseParameterValuesOnRefresh = True
        Me.reportViewver.Size = New System.Drawing.Size(741, 681)
        Me.reportViewver.TabIndex = 1
        Me.reportViewver.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 732)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAPORAN"
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmbTgl As System.Windows.Forms.ComboBox
    Friend WithEvents txtUserLogin As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents reportViewver As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnCariPasien As System.Windows.Forms.Button
    Friend WithEvents CachedrptLaporan1 As HerbalDaunSendok.CachedrptLaporan
    'Friend WithEvents LaporanBulanan1 As HerbalDaunSendok.laporanBulanan
    'Friend WithEvents laporanBulanan2 As HerbalDaunSendok.laporanBulanan
End Class
