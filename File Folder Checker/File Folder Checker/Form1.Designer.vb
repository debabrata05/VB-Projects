<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBrowseFiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formBrowseFiles))
        Me.lstDrives = New System.Windows.Forms.ListBox()
        Me.lstFloders = New System.Windows.Forms.ListBox()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstDrives
        '
        Me.lstDrives.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDrives.FormattingEnabled = True
        Me.lstDrives.ItemHeight = 25
        Me.lstDrives.Location = New System.Drawing.Point(29, 15)
        Me.lstDrives.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lstDrives.Name = "lstDrives"
        Me.lstDrives.Size = New System.Drawing.Size(199, 254)
        Me.lstDrives.TabIndex = 0
        '
        'lstFloders
        '
        Me.lstFloders.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFloders.FormattingEnabled = True
        Me.lstFloders.ItemHeight = 25
        Me.lstFloders.Location = New System.Drawing.Point(254, 15)
        Me.lstFloders.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lstFloders.Name = "lstFloders"
        Me.lstFloders.Size = New System.Drawing.Size(362, 254)
        Me.lstFloders.TabIndex = 1
        '
        'lstFiles
        '
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.ItemHeight = 25
        Me.lstFiles.Location = New System.Drawing.Point(647, 15)
        Me.lstFiles.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(493, 254)
        Me.lstFiles.TabIndex = 2
        '
        'formBrowseFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 295)
        Me.Controls.Add(Me.lstFiles)
        Me.Controls.Add(Me.lstFloders)
        Me.Controls.Add(Me.lstDrives)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "formBrowseFiles"
        Me.Text = "BROWSE FILE"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstDrives As System.Windows.Forms.ListBox
    Friend WithEvents lstFloders As System.Windows.Forms.ListBox
    Friend WithEvents lstFiles As System.Windows.Forms.ListBox

End Class
