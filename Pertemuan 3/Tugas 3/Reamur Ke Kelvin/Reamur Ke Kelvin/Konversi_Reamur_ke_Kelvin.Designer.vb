<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konversi_Reamur_ke_Kelvin
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
        Me.B_Hitung = New System.Windows.Forms.Button()
        Me.TextReamur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextKelvin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Konversi Reamur Ke Kelvin"
        '
        'B_Hitung
        '
        Me.B_Hitung.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Hitung.Location = New System.Drawing.Point(179, 195)
        Me.B_Hitung.Name = "B_Hitung"
        Me.B_Hitung.Size = New System.Drawing.Size(123, 31)
        Me.B_Hitung.TabIndex = 1
        Me.B_Hitung.Text = "Hitung"
        Me.B_Hitung.UseVisualStyleBackColor = True
        '
        'TextReamur
        '
        Me.TextReamur.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextReamur.Location = New System.Drawing.Point(151, 135)
        Me.TextReamur.Name = "TextReamur"
        Me.TextReamur.Size = New System.Drawing.Size(180, 30)
        Me.TextReamur.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Suhu Reamur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(204, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kelvin"
        '
        'TextKelvin
        '
        Me.TextKelvin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextKelvin.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKelvin.Location = New System.Drawing.Point(151, 271)
        Me.TextKelvin.Name = "TextKelvin"
        Me.TextKelvin.Size = New System.Drawing.Size(180, 30)
        Me.TextKelvin.TabIndex = 4
        '
        'Konversi_Reamur_ke_Kelvin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(479, 355)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextKelvin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextReamur)
        Me.Controls.Add(Me.B_Hitung)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Konversi_Reamur_ke_Kelvin"
        Me.Text = "Tugas 3 Konversi Reamur Ke Kelvin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents B_Hitung As Button
    Friend WithEvents TextReamur As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextKelvin As TextBox
End Class
