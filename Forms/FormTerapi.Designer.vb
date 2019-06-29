<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTerapi
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtPul = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.rbtnP = New System.Windows.Forms.RadioButton()
        Me.rbtnL = New System.Windows.Forms.RadioButton()
        Me.txtTerapi = New System.Windows.Forms.TextBox()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtDiagnosa = New System.Windows.Forms.TextBox()
        Me.txtLab = New System.Windows.Forms.TextBox()
        Me.txtGd = New System.Windows.Forms.TextBox()
        Me.txtSys = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tabelPasien = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnCariPasien = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.idPenyakit = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtTgl = New System.Windows.Forms.Label()
        Me.txtTelp = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.Label()
        Me.txtUmur = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.tabelPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPul
        '
        Me.txtPul.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPul.Location = New System.Drawing.Point(724, 93)
        Me.txtPul.Name = "txtPul"
        Me.txtPul.Size = New System.Drawing.Size(401, 28)
        Me.txtPul.TabIndex = 56
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(704, 94)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(15, 23)
        Me.Label28.TabIndex = 55
        Me.Label28.Text = ":"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(565, 95)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 23)
        Me.Label29.TabIndex = 54
        Me.Label29.Text = "PUL"
        '
        'rbtnP
        '
        Me.rbtnP.AutoSize = True
        Me.rbtnP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnP.Location = New System.Drawing.Point(289, 153)
        Me.rbtnP.Name = "rbtnP"
        Me.rbtnP.Size = New System.Drawing.Size(109, 24)
        Me.rbtnP.TabIndex = 53
        Me.rbtnP.TabStop = True
        Me.rbtnP.Text = "Perempuan"
        Me.rbtnP.UseVisualStyleBackColor = True
        '
        'rbtnL
        '
        Me.rbtnL.AutoSize = True
        Me.rbtnL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnL.Location = New System.Drawing.Point(181, 153)
        Me.rbtnL.Name = "rbtnL"
        Me.rbtnL.Size = New System.Drawing.Size(84, 24)
        Me.rbtnL.TabIndex = 52
        Me.rbtnL.TabStop = True
        Me.rbtnL.Text = "Laki-laki"
        Me.rbtnL.UseVisualStyleBackColor = True
        '
        'txtTerapi
        '
        Me.txtTerapi.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerapi.Location = New System.Drawing.Point(724, 252)
        Me.txtTerapi.Name = "txtTerapi"
        Me.txtTerapi.Size = New System.Drawing.Size(401, 28)
        Me.txtTerapi.TabIndex = 51
        '
        'txtDia
        '
        Me.txtDia.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDia.Location = New System.Drawing.Point(724, 53)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(401, 28)
        Me.txtDia.TabIndex = 50
        '
        'txtDiagnosa
        '
        Me.txtDiagnosa.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnosa.Location = New System.Drawing.Point(724, 209)
        Me.txtDiagnosa.Name = "txtDiagnosa"
        Me.txtDiagnosa.Size = New System.Drawing.Size(401, 28)
        Me.txtDiagnosa.TabIndex = 49
        '
        'txtLab
        '
        Me.txtLab.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLab.Location = New System.Drawing.Point(724, 170)
        Me.txtLab.Name = "txtLab"
        Me.txtLab.Size = New System.Drawing.Size(401, 28)
        Me.txtLab.TabIndex = 48
        '
        'txtGd
        '
        Me.txtGd.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGd.Location = New System.Drawing.Point(724, 131)
        Me.txtGd.Name = "txtGd"
        Me.txtGd.Size = New System.Drawing.Size(401, 28)
        Me.txtGd.TabIndex = 47
        '
        'txtSys
        '
        Me.txtSys.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSys.Location = New System.Drawing.Point(724, 16)
        Me.txtSys.Name = "txtSys"
        Me.txtSys.Size = New System.Drawing.Size(401, 28)
        Me.txtSys.TabIndex = 46
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(149, 235)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(15, 23)
        Me.Label26.TabIndex = 44
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(57, 236)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(87, 23)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "TANGGAL"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(704, 252)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(15, 23)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(565, 254)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(133, 23)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "TERAPI HERBAL"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(704, 210)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(15, 23)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = ":"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(565, 210)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(98, 23)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "DIAGNOSA"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.Controls.Add(Me.tabelPasien)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Location = New System.Drawing.Point(61, 347)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1064, 232)
        Me.Panel4.TabIndex = 7
        '
        'tabelPasien
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabelPasien.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tabelPasien.ColumnHeadersHeight = 30
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabelPasien.DefaultCellStyle = DataGridViewCellStyle2
        Me.tabelPasien.Location = New System.Drawing.Point(0, 3)
        Me.tabelPasien.Name = "tabelPasien"
        Me.tabelPasien.RowHeadersWidth = 35
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tabelPasien.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.tabelPasien.Size = New System.Drawing.Size(1064, 183)
        Me.tabelPasien.TabIndex = 28
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(0, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 40)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "SIMPAN"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(916, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 40)
        Me.Button3.TabIndex = 58
        Me.Button3.Text = "HAPUS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnCariPasien
        '
        Me.btnCariPasien.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnCariPasien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCariPasien.FlatAppearance.BorderSize = 0
        Me.btnCariPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariPasien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariPasien.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCariPasien.Location = New System.Drawing.Point(702, 295)
        Me.btnCariPasien.Name = "btnCariPasien"
        Me.btnCariPasien.Size = New System.Drawing.Size(101, 40)
        Me.btnCariPasien.TabIndex = 27
        Me.btnCariPasien.Text = "TAMBAH"
        Me.btnCariPasien.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(704, 170)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 23)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = ":"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(565, 171)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(105, 23)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "LAB.DARAH"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(704, 132)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 23)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(565, 132)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 23)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "GD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(704, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 23)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(565, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 23)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "DIA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(704, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 23)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(565, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 23)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "SYS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(149, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 23)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(57, 195)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 23)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "TELP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(149, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 23)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(57, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 23)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "JK (L/P)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(149, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(57, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "ALAMAT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(149, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(57, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "UMUR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(149, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(57, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NAMA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 10)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-3, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1366, 58)
        Me.Panel2.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(1103, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 29)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "CARI PASIEN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA PASIEN TERAPI"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.idPenyakit)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.btnReset)
        Me.Panel3.Controls.Add(Me.txtTgl)
        Me.Panel3.Controls.Add(Me.txtTelp)
        Me.Panel3.Controls.Add(Me.btnCariPasien)
        Me.Panel3.Controls.Add(Me.txtAlamat)
        Me.Panel3.Controls.Add(Me.txtUmur)
        Me.Panel3.Controls.Add(Me.txtNama)
        Me.Panel3.Controls.Add(Me.txtPul)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.rbtnP)
        Me.Panel3.Controls.Add(Me.rbtnL)
        Me.Panel3.Controls.Add(Me.txtTerapi)
        Me.Panel3.Controls.Add(Me.txtDia)
        Me.Panel3.Controls.Add(Me.txtDiagnosa)
        Me.Panel3.Controls.Add(Me.txtLab)
        Me.Panel3.Controls.Add(Me.txtGd)
        Me.Panel3.Controls.Add(Me.txtSys)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(33, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1185, 579)
        Me.Panel3.TabIndex = 9
        '
        'idPenyakit
        '
        Me.idPenyakit.AutoSize = True
        Me.idPenyakit.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPenyakit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.idPenyakit.Location = New System.Drawing.Point(565, 295)
        Me.idPenyakit.Name = "idPenyakit"
        Me.idPenyakit.Size = New System.Drawing.Size(105, 23)
        Me.idPenyakit.TabIndex = 68
        Me.idPenyakit.Text = "LAB.DARAH"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(809, 295)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(101, 40)
        Me.btnUpdate.TabIndex = 67
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(1023, 295)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(101, 40)
        Me.btnReset.TabIndex = 65
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'txtTgl
        '
        Me.txtTgl.AutoSize = True
        Me.txtTgl.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtTgl.Location = New System.Drawing.Point(180, 237)
        Me.txtTgl.Name = "txtTgl"
        Me.txtTgl.Size = New System.Drawing.Size(16, 23)
        Me.txtTgl.TabIndex = 63
        Me.txtTgl.Text = "-"
        '
        'txtTelp
        '
        Me.txtTelp.AutoSize = True
        Me.txtTelp.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtTelp.Location = New System.Drawing.Point(180, 194)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(16, 23)
        Me.txtTelp.TabIndex = 62
        Me.txtTelp.Text = "-"
        '
        'txtAlamat
        '
        Me.txtAlamat.AutoSize = True
        Me.txtAlamat.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAlamat.Location = New System.Drawing.Point(180, 106)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(16, 23)
        Me.txtAlamat.TabIndex = 60
        Me.txtAlamat.Text = "-"
        '
        'txtUmur
        '
        Me.txtUmur.AutoSize = True
        Me.txtUmur.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUmur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtUmur.Location = New System.Drawing.Point(180, 66)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(16, 23)
        Me.txtUmur.TabIndex = 59
        Me.txtUmur.Text = "-"
        '
        'txtNama
        '
        Me.txtNama.AutoSize = True
        Me.txtNama.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtNama.Location = New System.Drawing.Point(180, 25)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(16, 23)
        Me.txtNama.TabIndex = 58
        Me.txtNama.Text = "-"
        '
        'FormTerapi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HerbalDaunSendok.My.Resources.Resources.pw_maze_white__2X
        Me.ClientSize = New System.Drawing.Size(1250, 681)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormTerapi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORM TERAPI PASIEN"
        Me.Panel4.ResumeLayout(False)
        CType(Me.tabelPasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPul As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents rbtnP As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnL As System.Windows.Forms.RadioButton
    Friend WithEvents txtTerapi As System.Windows.Forms.TextBox
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents txtDiagnosa As System.Windows.Forms.TextBox
    Friend WithEvents txtLab As System.Windows.Forms.TextBox
    Friend WithEvents txtGd As System.Windows.Forms.TextBox
    Friend WithEvents txtSys As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tabelPasien As System.Windows.Forms.DataGridView
    Friend WithEvents btnCariPasien As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtTgl As System.Windows.Forms.Label
    Friend WithEvents txtTelp As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.Label
    Friend WithEvents txtUmur As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents idPenyakit As System.Windows.Forms.Label
End Class
