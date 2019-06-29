<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariPasien
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabelPasien = New System.Windows.Forms.DataGridView()
        Me.btnCariPasien = New System.Windows.Forms.Button()
        Me.txtCariPasien = New System.Windows.Forms.TextBox()
        CType(Me.tabelPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabelPasien
        '
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabelPasien.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabelPasien.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.tabelPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabelPasien.DefaultCellStyle = DataGridViewCellStyle15
        Me.tabelPasien.Location = New System.Drawing.Point(12, 61)
        Me.tabelPasien.Name = "tabelPasien"
        Me.tabelPasien.Size = New System.Drawing.Size(833, 381)
        Me.tabelPasien.TabIndex = 0
        '
        'btnCariPasien
        '
        Me.btnCariPasien.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnCariPasien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCariPasien.FlatAppearance.BorderSize = 0
        Me.btnCariPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariPasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariPasien.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCariPasien.Location = New System.Drawing.Point(782, 17)
        Me.btnCariPasien.Name = "btnCariPasien"
        Me.btnCariPasien.Size = New System.Drawing.Size(63, 29)
        Me.btnCariPasien.TabIndex = 31
        Me.btnCariPasien.Text = "CARI"
        Me.btnCariPasien.UseVisualStyleBackColor = False
        '
        'txtCariPasien
        '
        Me.txtCariPasien.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariPasien.Location = New System.Drawing.Point(448, 17)
        Me.txtCariPasien.Name = "txtCariPasien"
        Me.txtCariPasien.Size = New System.Drawing.Size(328, 28)
        Me.txtCariPasien.TabIndex = 30
        '
        'FormCariPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HerbalDaunSendok.My.Resources.Resources.pw_maze_white__2X
        Me.ClientSize = New System.Drawing.Size(857, 473)
        Me.Controls.Add(Me.btnCariPasien)
        Me.Controls.Add(Me.txtCariPasien)
        Me.Controls.Add(Me.tabelPasien)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCariPasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARI DATA PASIEN"
        Me.TopMost = True
        CType(Me.tabelPasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabelPasien As System.Windows.Forms.DataGridView
    Friend WithEvents btnCariPasien As System.Windows.Forms.Button
    Friend WithEvents txtCariPasien As System.Windows.Forms.TextBox
End Class
