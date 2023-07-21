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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPendataan = New System.Windows.Forms.ToolStripMenuItem()
        Me.Kendaraan = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JalurRuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianTiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuPendataan})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(694, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginBar, Me.LogoutBar, Me.ExitBar})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginBar
        '
        Me.LoginBar.Name = "LoginBar"
        Me.LoginBar.Size = New System.Drawing.Size(112, 22)
        Me.LoginBar.Text = "Login"
        '
        'LogoutBar
        '
        Me.LogoutBar.Name = "LogoutBar"
        Me.LogoutBar.Size = New System.Drawing.Size(112, 22)
        Me.LogoutBar.Text = "Logout"
        '
        'ExitBar
        '
        Me.ExitBar.Name = "ExitBar"
        Me.ExitBar.Size = New System.Drawing.Size(112, 22)
        Me.ExitBar.Text = "Exit"
        '
        'MenuPendataan
        '
        Me.MenuPendataan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Kendaraan, Me.PemesananToolStripMenuItem, Me.JalurRuteToolStripMenuItem, Me.AgenToolStripMenuItem, Me.PembelianTiketToolStripMenuItem})
        Me.MenuPendataan.Name = "MenuPendataan"
        Me.MenuPendataan.Size = New System.Drawing.Size(78, 20)
        Me.MenuPendataan.Text = " pendataan"
        '
        'Kendaraan
        '
        Me.Kendaraan.Name = "Kendaraan"
        Me.Kendaraan.Size = New System.Drawing.Size(180, 22)
        Me.Kendaraan.Text = "kendaraan"
        '
        'PemesananToolStripMenuItem
        '
        Me.PemesananToolStripMenuItem.Name = "PemesananToolStripMenuItem"
        Me.PemesananToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PemesananToolStripMenuItem.Text = "pemesanan"
        '
        'JalurRuteToolStripMenuItem
        '
        Me.JalurRuteToolStripMenuItem.Name = "JalurRuteToolStripMenuItem"
        Me.JalurRuteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JalurRuteToolStripMenuItem.Text = "jalur rute"
        '
        'AgenToolStripMenuItem
        '
        Me.AgenToolStripMenuItem.Name = "AgenToolStripMenuItem"
        Me.AgenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgenToolStripMenuItem.Text = "agen"
        '
        'PembelianTiketToolStripMenuItem
        '
        Me.PembelianTiketToolStripMenuItem.Name = "PembelianTiketToolStripMenuItem"
        Me.PembelianTiketToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PembelianTiketToolStripMenuItem.Text = "pembelian tiket"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 448)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "App Jasa Travel By Reza Ramadhan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginBar As ToolStripMenuItem
    Friend WithEvents LogoutBar As ToolStripMenuItem
    Friend WithEvents MenuPendataan As ToolStripMenuItem
    Friend WithEvents Kendaraan As ToolStripMenuItem
    Friend WithEvents ExitBar As ToolStripMenuItem
    Friend WithEvents PemesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JalurRuteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianTiketToolStripMenuItem As ToolStripMenuItem
End Class
