<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextDiagonal1 = New System.Windows.Forms.TextBox()
        Me.TextDiagonal2 = New System.Windows.Forms.TextBox()
        Me.TextKeliling = New System.Windows.Forms.TextBox()
        Me.TextLuas = New System.Windows.Forms.TextBox()
        Me.b_hitung = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textsisi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Latihan 1"
        '
        'TextDiagonal1
        '
        Me.TextDiagonal1.Location = New System.Drawing.Point(199, 142)
        Me.TextDiagonal1.Name = "TextDiagonal1"
        Me.TextDiagonal1.Size = New System.Drawing.Size(100, 20)
        Me.TextDiagonal1.TabIndex = 1
        '
        'TextDiagonal2
        '
        Me.TextDiagonal2.Location = New System.Drawing.Point(199, 168)
        Me.TextDiagonal2.Name = "TextDiagonal2"
        Me.TextDiagonal2.Size = New System.Drawing.Size(100, 20)
        Me.TextDiagonal2.TabIndex = 2
        '
        'TextKeliling
        '
        Me.TextKeliling.Location = New System.Drawing.Point(200, 286)
        Me.TextKeliling.Name = "TextKeliling"
        Me.TextKeliling.Size = New System.Drawing.Size(100, 20)
        Me.TextKeliling.TabIndex = 4
        '
        'TextLuas
        '
        Me.TextLuas.Location = New System.Drawing.Point(200, 260)
        Me.TextLuas.Name = "TextLuas"
        Me.TextLuas.Size = New System.Drawing.Size(100, 20)
        Me.TextLuas.TabIndex = 3
        '
        'b_hitung
        '
        Me.b_hitung.Location = New System.Drawing.Point(199, 220)
        Me.b_hitung.Name = "b_hitung"
        Me.b_hitung.Size = New System.Drawing.Size(99, 34)
        Me.b_hitung.TabIndex = 5
        Me.b_hitung.Text = "Hitung"
        Me.b_hitung.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Diagonal 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Diagonal 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Luas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Keliling"
        '
        'Textsisi
        '
        Me.Textsisi.Location = New System.Drawing.Point(200, 194)
        Me.Textsisi.Name = "Textsisi"
        Me.Textsisi.Size = New System.Drawing.Size(100, 20)
        Me.Textsisi.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "sisi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(488, 490)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Textsisi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.b_hitung)
        Me.Controls.Add(Me.TextKeliling)
        Me.Controls.Add(Me.TextLuas)
        Me.Controls.Add(Me.TextDiagonal2)
        Me.Controls.Add(Me.TextDiagonal1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextDiagonal1 As TextBox
    Friend WithEvents TextDiagonal2 As TextBox
    Friend WithEvents TextKeliling As TextBox
    Friend WithEvents TextLuas As TextBox
    Friend WithEvents b_hitung As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Textsisi As TextBox
    Friend WithEvents Label6 As Label
End Class
