<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDashboard
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
        Me.MulaiDiagnosisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataPenyakitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataGejalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataAturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SaddleBrown
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MulaiDiagnosisToolStripMenuItem, Me.OlahDataToolStripMenuItem, Me.LAporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1020, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MulaiDiagnosisToolStripMenuItem
        '
        Me.MulaiDiagnosisToolStripMenuItem.Name = "MulaiDiagnosisToolStripMenuItem"
        Me.MulaiDiagnosisToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.MulaiDiagnosisToolStripMenuItem.Text = "Mulai Diagnosis"
        '
        'OlahDataToolStripMenuItem
        '
        Me.OlahDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OlahDataPenyakitToolStripMenuItem, Me.OlahDataGejalaToolStripMenuItem, Me.OlahDataAturanToolStripMenuItem})
        Me.OlahDataToolStripMenuItem.Name = "OlahDataToolStripMenuItem"
        Me.OlahDataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.OlahDataToolStripMenuItem.Text = "Data"
        '
        'OlahDataPenyakitToolStripMenuItem
        '
        Me.OlahDataPenyakitToolStripMenuItem.Name = "OlahDataPenyakitToolStripMenuItem"
        Me.OlahDataPenyakitToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OlahDataPenyakitToolStripMenuItem.Text = "Olah Data Penyakit"
        '
        'OlahDataGejalaToolStripMenuItem
        '
        Me.OlahDataGejalaToolStripMenuItem.Name = "OlahDataGejalaToolStripMenuItem"
        Me.OlahDataGejalaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OlahDataGejalaToolStripMenuItem.Text = "Olah Data Gejala"
        '
        'OlahDataAturanToolStripMenuItem
        '
        Me.OlahDataAturanToolStripMenuItem.Name = "OlahDataAturanToolStripMenuItem"
        Me.OlahDataAturanToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OlahDataAturanToolStripMenuItem.Text = "Olah Data Aturan"
        '
        'LAporanToolStripMenuItem
        '
        Me.LAporanToolStripMenuItem.Name = "LAporanToolStripMenuItem"
        Me.LAporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LAporanToolStripMenuItem.Text = "Laporan"
        '
        'formDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemPakarPenyakitLambung.My.Resources.Resources.bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1020, 580)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formDashboard"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MulaiDiagnosisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LAporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataPenyakitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataGejalaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataAturanToolStripMenuItem As ToolStripMenuItem
End Class
