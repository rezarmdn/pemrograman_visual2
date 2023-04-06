<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class konversi_celcius_ke_fahrenheit
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
        Me.TextCelciusFahrenheit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextKonversiFahrenheit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Konversi Celcius Ke Fahrenheit"
        '
        'B_Hitung
        '
        Me.B_Hitung.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Hitung.Location = New System.Drawing.Point(138, 169)
        Me.B_Hitung.Name = "B_Hitung"
        Me.B_Hitung.Size = New System.Drawing.Size(144, 39)
        Me.B_Hitung.TabIndex = 1
        Me.B_Hitung.Text = "Hitung"
        Me.B_Hitung.UseVisualStyleBackColor = True
        '
        'TextCelciusFahrenheit
        '
        Me.TextCelciusFahrenheit.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCelciusFahrenheit.Location = New System.Drawing.Point(135, 112)
        Me.TextCelciusFahrenheit.Name = "TextCelciusFahrenheit"
        Me.TextCelciusFahrenheit.Size = New System.Drawing.Size(147, 30)
        Me.TextCelciusFahrenheit.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(149, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fahrenheit"
        '
        'TextKonversiFahrenheit
        '
        Me.TextKonversiFahrenheit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextKonversiFahrenheit.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKonversiFahrenheit.Location = New System.Drawing.Point(135, 261)
        Me.TextKonversiFahrenheit.Name = "TextKonversiFahrenheit"
        Me.TextKonversiFahrenheit.Size = New System.Drawing.Size(147, 30)
        Me.TextKonversiFahrenheit.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Suhu"
        '
        'konversi_celcius_ke_fahrenheit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(452, 502)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextKonversiFahrenheit)
        Me.Controls.Add(Me.TextCelciusFahrenheit)
        Me.Controls.Add(Me.B_Hitung)
        Me.Controls.Add(Me.Label1)
        Me.Name = "konversi_celcius_ke_fahrenheit"
        Me.Text = "Tugas 3 Konversi Calcius Ke Fahrenheit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents B_Hitung As Button
    Friend WithEvents TextCelciusFahrenheit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextKonversiFahrenheit As TextBox
    Friend WithEvents Label2 As Label
End Class
