<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Biaya_Registrasi_Prodi_By_Reza_Ramadhan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbProdi = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRegistrasi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("News706 BT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "tugas 6"
        '
        'cmbProdi
        '
        Me.cmbProdi.FormattingEnabled = True
        Me.cmbProdi.Items.AddRange(New Object() {"Manajemen", "Akuntansi", "Ilmu Komunikasi", "Peternakan", "Teknik Industri", "Teknik Informatika"})
        Me.cmbProdi.Location = New System.Drawing.Point(46, 137)
        Me.cmbProdi.Name = "cmbProdi"
        Me.cmbProdi.Size = New System.Drawing.Size(234, 30)
        Me.cmbProdi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "memilih prodi"
        '
        'txtRegistrasi
        '
        Me.txtRegistrasi.Location = New System.Drawing.Point(46, 214)
        Me.txtRegistrasi.Name = "txtRegistrasi"
        Me.txtRegistrasi.Size = New System.Drawing.Size(234, 30)
        Me.txtRegistrasi.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "biaya registrasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(42, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Creat by Reza Ramadhan"
        '
        'Biaya_Registrasi_Prodi_By_Reza_Ramadhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(330, 326)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRegistrasi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbProdi)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Biaya_Registrasi_Prodi_By_Reza_Ramadhan"
        Me.Text = "Biaya Registrasi Prodi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbProdi As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRegistrasi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
