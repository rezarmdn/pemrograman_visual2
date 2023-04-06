<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konversi_Fahrenheit_Ke_Reamur
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
        Me.TextFahrenheit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextReamur = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "konversi Fahrenheit Ke Reamur"
        '
        'B_Hitung
        '
        Me.B_Hitung.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Hitung.Location = New System.Drawing.Point(162, 182)
        Me.B_Hitung.Name = "B_Hitung"
        Me.B_Hitung.Size = New System.Drawing.Size(168, 35)
        Me.B_Hitung.TabIndex = 1
        Me.B_Hitung.Text = "Hitung"
        Me.B_Hitung.UseVisualStyleBackColor = True
        '
        'TextFahrenheit
        '
        Me.TextFahrenheit.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFahrenheit.Location = New System.Drawing.Point(162, 146)
        Me.TextFahrenheit.Name = "TextFahrenheit"
        Me.TextFahrenheit.Size = New System.Drawing.Size(168, 30)
        Me.TextFahrenheit.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Suhu Fahrenheit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(201, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Reamur"
        '
        'TextReamur
        '
        Me.TextReamur.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextReamur.Location = New System.Drawing.Point(162, 251)
        Me.TextReamur.Name = "TextReamur"
        Me.TextReamur.Size = New System.Drawing.Size(168, 30)
        Me.TextReamur.TabIndex = 4
        '
        'Konversi_Fahrenheit_Ke_Reamur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(508, 327)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextReamur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextFahrenheit)
        Me.Controls.Add(Me.B_Hitung)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Konversi_Fahrenheit_Ke_Reamur"
        Me.Text = "Tugas 3 Konversi Fahrenheit Ke reamur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents B_Hitung As Button
    Friend WithEvents TextFahrenheit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextReamur As TextBox
End Class
