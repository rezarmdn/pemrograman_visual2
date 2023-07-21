<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formpemesanan
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
        Me.Text_Nama_Pemesan = New System.Windows.Forms.TextBox()
        Me.Text_Email = New System.Windows.Forms.TextBox()
        Me.Text_No_Hp = New System.Windows.Forms.TextBox()
        Me.Text_Tanggal_Lahir = New System.Windows.Forms.TextBox()
        Me.Text_Bayar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.B_Submit = New System.Windows.Forms.Button()
        Me.B_Clear = New System.Windows.Forms.Button()
        Me.B_Hapus = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Text_Nama_Pemesan
        '
        Me.Text_Nama_Pemesan.Location = New System.Drawing.Point(61, 53)
        Me.Text_Nama_Pemesan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Text_Nama_Pemesan.Name = "Text_Nama_Pemesan"
        Me.Text_Nama_Pemesan.Size = New System.Drawing.Size(216, 27)
        Me.Text_Nama_Pemesan.TabIndex = 0
        '
        'Text_Email
        '
        Me.Text_Email.Location = New System.Drawing.Point(61, 148)
        Me.Text_Email.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Text_Email.Name = "Text_Email"
        Me.Text_Email.Size = New System.Drawing.Size(216, 27)
        Me.Text_Email.TabIndex = 1
        '
        'Text_No_Hp
        '
        Me.Text_No_Hp.Location = New System.Drawing.Point(61, 231)
        Me.Text_No_Hp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Text_No_Hp.Name = "Text_No_Hp"
        Me.Text_No_Hp.Size = New System.Drawing.Size(216, 27)
        Me.Text_No_Hp.TabIndex = 2
        '
        'Text_Tanggal_Lahir
        '
        Me.Text_Tanggal_Lahir.Location = New System.Drawing.Point(61, 314)
        Me.Text_Tanggal_Lahir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Text_Tanggal_Lahir.Name = "Text_Tanggal_Lahir"
        Me.Text_Tanggal_Lahir.Size = New System.Drawing.Size(216, 27)
        Me.Text_Tanggal_Lahir.TabIndex = 3
        '
        'Text_Bayar
        '
        Me.Text_Bayar.Location = New System.Drawing.Point(61, 398)
        Me.Text_Bayar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Text_Bayar.Name = "Text_Bayar"
        Me.Text_Bayar.Size = New System.Drawing.Size(216, 27)
        Me.Text_Bayar.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama Pemesanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 209)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "No Hp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 292)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tanggal lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 376)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Bayar"
        '
        'B_Submit
        '
        Me.B_Submit.Location = New System.Drawing.Point(850, 46)
        Me.B_Submit.Name = "B_Submit"
        Me.B_Submit.Size = New System.Drawing.Size(117, 38)
        Me.B_Submit.TabIndex = 11
        Me.B_Submit.Text = "Submit"
        Me.B_Submit.UseVisualStyleBackColor = True
        '
        'B_Clear
        '
        Me.B_Clear.Location = New System.Drawing.Point(604, 46)
        Me.B_Clear.Name = "B_Clear"
        Me.B_Clear.Size = New System.Drawing.Size(117, 38)
        Me.B_Clear.TabIndex = 12
        Me.B_Clear.Text = "Clear"
        Me.B_Clear.UseVisualStyleBackColor = True
        '
        'B_Hapus
        '
        Me.B_Hapus.Location = New System.Drawing.Point(350, 46)
        Me.B_Hapus.Name = "B_Hapus"
        Me.B_Hapus.Size = New System.Drawing.Size(117, 38)
        Me.B_Hapus.TabIndex = 13
        Me.B_Hapus.Text = "Hapus"
        Me.B_Hapus.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Yellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Yellow
        Me.DataGridView1.Location = New System.Drawing.Point(367, 102)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(600, 312)
        Me.DataGridView1.TabIndex = 28
        '
        'Pemesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 492)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.B_Hapus)
        Me.Controls.Add(Me.B_Clear)
        Me.Controls.Add(Me.B_Submit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Text_Bayar)
        Me.Controls.Add(Me.Text_Tanggal_Lahir)
        Me.Controls.Add(Me.Text_No_Hp)
        Me.Controls.Add(Me.Text_Email)
        Me.Controls.Add(Me.Text_Nama_Pemesan)
        Me.Font = New System.Drawing.Font("News706 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Pemesanan"
        Me.Text = "Pemesanan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Text_Nama_Pemesan As TextBox
    Friend WithEvents Text_Email As TextBox
    Friend WithEvents Text_No_Hp As TextBox
    Friend WithEvents Text_Tanggal_Lahir As TextBox
    Friend WithEvents Text_Bayar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents B_Submit As Button
    Friend WithEvents B_Clear As Button
    Friend WithEvents B_Hapus As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
