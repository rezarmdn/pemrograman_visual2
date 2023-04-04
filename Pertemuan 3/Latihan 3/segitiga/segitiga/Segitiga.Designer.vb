<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Segitiga
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextAlas = New System.Windows.Forms.TextBox()
        Me.TextTinggi = New System.Windows.Forms.TextBox()
        Me.TextSisi1 = New System.Windows.Forms.TextBox()
        Me.TextSisi2 = New System.Windows.Forms.TextBox()
        Me.TextSisi3 = New System.Windows.Forms.TextBox()
        Me.TextLuas = New System.Windows.Forms.TextBox()
        Me.TextKeliling = New System.Windows.Forms.TextBox()
        Me.B_Hitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Segitiga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tinggi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sisi 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sisi 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sisi 3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(68, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Luas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(68, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Keliling"
        '
        'TextAlas
        '
        Me.TextAlas.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAlas.Location = New System.Drawing.Point(190, 99)
        Me.TextAlas.Name = "TextAlas"
        Me.TextAlas.Size = New System.Drawing.Size(149, 30)
        Me.TextAlas.TabIndex = 8
        '
        'TextTinggi
        '
        Me.TextTinggi.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTinggi.Location = New System.Drawing.Point(190, 135)
        Me.TextTinggi.Name = "TextTinggi"
        Me.TextTinggi.Size = New System.Drawing.Size(149, 30)
        Me.TextTinggi.TabIndex = 9
        '
        'TextSisi1
        '
        Me.TextSisi1.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSisi1.Location = New System.Drawing.Point(190, 171)
        Me.TextSisi1.Name = "TextSisi1"
        Me.TextSisi1.Size = New System.Drawing.Size(149, 30)
        Me.TextSisi1.TabIndex = 10
        '
        'TextSisi2
        '
        Me.TextSisi2.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSisi2.Location = New System.Drawing.Point(190, 207)
        Me.TextSisi2.Name = "TextSisi2"
        Me.TextSisi2.Size = New System.Drawing.Size(149, 30)
        Me.TextSisi2.TabIndex = 11
        '
        'TextSisi3
        '
        Me.TextSisi3.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSisi3.Location = New System.Drawing.Point(190, 243)
        Me.TextSisi3.Name = "TextSisi3"
        Me.TextSisi3.Size = New System.Drawing.Size(149, 30)
        Me.TextSisi3.TabIndex = 12
        '
        'TextLuas
        '
        Me.TextLuas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextLuas.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLuas.Location = New System.Drawing.Point(190, 327)
        Me.TextLuas.Name = "TextLuas"
        Me.TextLuas.Size = New System.Drawing.Size(149, 30)
        Me.TextLuas.TabIndex = 13
        '
        'TextKeliling
        '
        Me.TextKeliling.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextKeliling.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKeliling.Location = New System.Drawing.Point(190, 363)
        Me.TextKeliling.Name = "TextKeliling"
        Me.TextKeliling.Size = New System.Drawing.Size(149, 30)
        Me.TextKeliling.TabIndex = 14
        '
        'B_Hitung
        '
        Me.B_Hitung.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Hitung.Location = New System.Drawing.Point(190, 280)
        Me.B_Hitung.Name = "B_Hitung"
        Me.B_Hitung.Size = New System.Drawing.Size(149, 41)
        Me.B_Hitung.TabIndex = 15
        Me.B_Hitung.Text = "Hitung"
        Me.B_Hitung.UseVisualStyleBackColor = True
        '
        'Segitiga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 457)
        Me.Controls.Add(Me.B_Hitung)
        Me.Controls.Add(Me.TextKeliling)
        Me.Controls.Add(Me.TextLuas)
        Me.Controls.Add(Me.TextSisi3)
        Me.Controls.Add(Me.TextSisi2)
        Me.Controls.Add(Me.TextSisi1)
        Me.Controls.Add(Me.TextTinggi)
        Me.Controls.Add(Me.TextAlas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Segitiga"
        Me.Text = "Latihan 3 Segitiga"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextAlas As TextBox
    Friend WithEvents TextTinggi As TextBox
    Friend WithEvents TextSisi1 As TextBox
    Friend WithEvents TextSisi2 As TextBox
    Friend WithEvents TextSisi3 As TextBox
    Friend WithEvents TextLuas As TextBox
    Friend WithEvents TextKeliling As TextBox
    Friend WithEvents B_Hitung As Button
End Class
