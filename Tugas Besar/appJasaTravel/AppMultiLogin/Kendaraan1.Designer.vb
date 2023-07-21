<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kendaraan1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Text_Harga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.B_simpan = New System.Windows.Forms.Button()
        Me.B_Clear = New System.Windows.Forms.Button()
        Me.B_delete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Text_rute = New System.Windows.Forms.TextBox()
        Me.Text_daya_angkut = New System.Windows.Forms.TextBox()
        Me.Text_Kendaraan = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 46)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(406, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama kendaraan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(406, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Daya Angkut"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(409, 304)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Harga"
        '
        'Text_Harga
        '
        Me.Text_Harga.Location = New System.Drawing.Point(412, 326)
        Me.Text_Harga.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Text_Harga.Name = "Text_Harga"
        Me.Text_Harga.Size = New System.Drawing.Size(250, 25)
        Me.Text_Harga.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(409, 226)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Rute"
        '
        'B_simpan
        '
        Me.B_simpan.Location = New System.Drawing.Point(630, 385)
        Me.B_simpan.Name = "B_simpan"
        Me.B_simpan.Size = New System.Drawing.Size(121, 43)
        Me.B_simpan.TabIndex = 12
        Me.B_simpan.Text = "simpan"
        Me.B_simpan.UseVisualStyleBackColor = True
        '
        'B_Clear
        '
        Me.B_Clear.Location = New System.Drawing.Point(485, 385)
        Me.B_Clear.Name = "B_Clear"
        Me.B_Clear.Size = New System.Drawing.Size(121, 43)
        Me.B_Clear.TabIndex = 13
        Me.B_Clear.Text = "Clear"
        Me.B_Clear.UseVisualStyleBackColor = True
        '
        'B_delete
        '
        Me.B_delete.Location = New System.Drawing.Point(336, 385)
        Me.B_delete.Name = "B_delete"
        Me.B_delete.Size = New System.Drawing.Size(121, 43)
        Me.B_delete.TabIndex = 14
        Me.B_delete.Text = "delete"
        Me.B_delete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Yellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Yellow
        Me.DataGridView1.Location = New System.Drawing.Point(312, 460)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(439, 198)
        Me.DataGridView1.TabIndex = 27
        '
        'Text_rute
        '
        Me.Text_rute.Location = New System.Drawing.Point(409, 258)
        Me.Text_rute.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Text_rute.Name = "Text_rute"
        Me.Text_rute.Size = New System.Drawing.Size(250, 25)
        Me.Text_rute.TabIndex = 28
        '
        'Text_daya_angkut
        '
        Me.Text_daya_angkut.Location = New System.Drawing.Point(409, 183)
        Me.Text_daya_angkut.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Text_daya_angkut.Name = "Text_daya_angkut"
        Me.Text_daya_angkut.Size = New System.Drawing.Size(250, 25)
        Me.Text_daya_angkut.TabIndex = 29
        '
        'Text_Kendaraan
        '
        Me.Text_Kendaraan.Location = New System.Drawing.Point(409, 113)
        Me.Text_Kendaraan.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Text_Kendaraan.Name = "Text_Kendaraan"
        Me.Text_Kendaraan.Size = New System.Drawing.Size(250, 25)
        Me.Text_Kendaraan.TabIndex = 30
        '
        'Kendaraan1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1103, 744)
        Me.Controls.Add(Me.Text_Kendaraan)
        Me.Controls.Add(Me.Text_daya_angkut)
        Me.Controls.Add(Me.Text_rute)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.B_delete)
        Me.Controls.Add(Me.B_Clear)
        Me.Controls.Add(Me.B_simpan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Text_Harga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("News706 BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Kendaraan1"
        Me.Text = "Pendataan Kendaraan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Text_Harga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents B_simpan As Button
    Friend WithEvents B_Clear As Button
    Friend WithEvents B_delete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Text_rute As TextBox
    Friend WithEvents Text_daya_angkut As TextBox
    Friend WithEvents Text_Kendaraan As TextBox
End Class
