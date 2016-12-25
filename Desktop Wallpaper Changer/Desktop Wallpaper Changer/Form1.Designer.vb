<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSetDesktopBackground
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSetDesktopBackground))
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnChanger = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(48, 386)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(113, 46)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnChanger
        '
        Me.btnChanger.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChanger.Location = New System.Drawing.Point(279, 386)
        Me.btnChanger.Name = "btnChanger"
        Me.btnChanger.Size = New System.Drawing.Size(371, 46)
        Me.btnChanger.TabIndex = 1
        Me.btnChanger.Text = "Set as Desktop Background"
        Me.btnChanger.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.White
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(652, 356)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 2
        Me.PictureBox.TabStop = False
        '
        'formSetDesktopBackground
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(676, 444)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.btnChanger)
        Me.Controls.Add(Me.btnLoad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formSetDesktopBackground"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DESKTOP BACKGROUND CHANGER"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnChanger As System.Windows.Forms.Button
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox

End Class
