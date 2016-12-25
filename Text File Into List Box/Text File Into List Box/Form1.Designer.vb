<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTextFileIntoListBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTextFileIntoListBox))
        Me.lstTextFileContents = New System.Windows.Forms.ListBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstTextFileContents
        '
        Me.lstTextFileContents.FormattingEnabled = True
        Me.lstTextFileContents.ItemHeight = 20
        Me.lstTextFileContents.Location = New System.Drawing.Point(12, 133)
        Me.lstTextFileContents.Name = "lstTextFileContents"
        Me.lstTextFileContents.Size = New System.Drawing.Size(964, 324)
        Me.lstTextFileContents.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(231, 77)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(189, 32)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(795, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(181, 32)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFile"
        Me.OpenFile.Filter = "Text Files|*.txt"
        '
        'txtAdress
        '
        Me.txtAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdress.Location = New System.Drawing.Point(12, 12)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(759, 32)
        Me.txtAdress.TabIndex = 3
        '
        'formTextFileIntoListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(988, 475)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lstTextFileContents)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "formTextFileIntoListBox"
        Me.Text = "OPEN TEXT FILE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTextFileContents As System.Windows.Forms.ListBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtAdress As System.Windows.Forms.TextBox

End Class
